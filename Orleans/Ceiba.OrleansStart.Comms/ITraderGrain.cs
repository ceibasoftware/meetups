namespace Ceiba.OrleansStart.Comms
{
    using System.Threading.Tasks;
    using Orleans;

    public interface ITraderGrain: IGrainWithGuidKey
    {
        Task FollowStockAsync( IStockGrain stock );

        Task<StockQuota> GetQuotaAsync( Stock stock );
    }
}
