namespace Ceiba.OrleansStart.Comms
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Orleans;

    public interface IStockGrain: IGrainWithStringKey
    {
        Task<StockQuota> GetQuotaAsync( Stock stock );

        Task UpdateStockAsync( StockRequest request );

        Task SubscribeForUpdates( IStockObserver subscriber );

        Task UnsubscribeForUpdates( IStockObserver subscriber );
    }
}
