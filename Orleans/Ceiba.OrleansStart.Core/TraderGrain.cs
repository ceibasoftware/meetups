namespace Ceiba.OrleansStart.Core
{
    using System.Threading.Tasks;
    using Comms;
    using Orleans;

    public class TraderGrain: Grain, ITraderGrain
    {
        #region Data Members

        private IStockGrain stockGrain;

        #endregion

        #region ITraderGrain Members

        public Task FollowStockAsync( IStockGrain stock )
        {
            this.stockGrain = stock;
            return TaskDone.Done;
        }

        public Task<StockQuota> GetQuotaAsync( Stock stock )
        {
            return this.stockGrain.GetQuotaAsync( stock );
        }

        #endregion
    }
}
