namespace Ceiba.OrleansStart.Comms
{
    using System.Collections.Generic;
    using Orleans;

    public interface IStockObserver: IGrainObserver
    {
        void UpdateStocks( IEnumerable<Stock> stocks );
    }
}
