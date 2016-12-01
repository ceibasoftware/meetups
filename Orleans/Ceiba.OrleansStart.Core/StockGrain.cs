namespace Ceiba.OrleansStart.Core
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Comms;
    using Orleans;

    public class StockGrain: Grain, IStockGrain
    {
        #region Data Members

        private IStockProvider provider;
        private IDictionary<Guid, HashSet<Stock>> userStocks;
        private ObserverSubscriptionManager<IStockObserver> subscribers;

        #endregion

        #region Overrides

        public override Task OnActivateAsync()
        {
            this.userStocks = new Dictionary<Guid, HashSet<Stock>>();
            this.subscribers = new ObserverSubscriptionManager<IStockObserver>();

            return TaskDone.Done;
        }

        #endregion

        #region IStockGrain Members

        public Task<StockQuota> GetQuotaAsync( Stock stock )
        {
            this.provider = StockProviderFactory.Create( stock.Provider );
            return this.provider.GetQuotaAsync( stock.Symbol );
        }

        public async Task UpdateStockAsync( StockRequest request )
        {
            Guid traderId = request.TraderId;

            if( !this.userStocks.ContainsKey( traderId ) )
            {
                ITraderGrain trader = GrainFactory.GetGrain<ITraderGrain>( traderId );
                await trader.FollowStockAsync( this );

                this.userStocks.Add( traderId, new HashSet<Stock>() );
            }

            var stocks = request.Stocks;

            foreach( Stock stock in stocks )
            {
                this.userStocks[traderId].Add( stock );

                var quota = await this.GetQuotaAsync( stock );
                stock.Quota = quota;
            }

            this.subscribers.Notify( notification => notification.UpdateStocks( request.Stocks ) );
        }

        public Task SubscribeForUpdates( IStockObserver subscriber )
        {
            this.subscribers.Subscribe( subscriber );
            return TaskDone.Done;
        }

        public Task UnsubscribeForUpdates( IStockObserver subscriber )
        {
            this.subscribers.Unsubscribe( subscriber );
            return TaskDone.Done;
        }

        #endregion
    }
}
