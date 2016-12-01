namespace Ceiba.OrleansStart.DesktopClient
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using Comms;

    public class StockObserver: IStockObserver
    {
        private readonly IUpdatable container;

        public StockObserver( IUpdatable container )
        {
            this.container = container;
        }

        public void UpdateStocks( IEnumerable<Stock> stocks )
        {
            var observables = new ObservableCollection<Stock>( stocks );
            this.container.Update( observables );
        }
    }
}
