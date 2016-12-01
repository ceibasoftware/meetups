namespace Ceiba.OrleansStart.Core
{
    using System.Threading.Tasks;
    using Comms;

    public interface IStockProvider
    {
        Task<StockQuota> GetQuotaAsync( string symbol );
    }
}