namespace Ceiba.OrleansStart.DesktopClient
{
    using Comms;

    public static class StockExtensions
    {
        public static StockItem ToStockItem( this Stock stock )
        {
            return new StockItem
            {
                Provider = stock.Provider,
                Quota = stock.Quota,
                Symbol = stock.Symbol
            };
        }

        public static Stock ToStock( this StockItem item )
        {
            return new Stock
            {
                Provider = item.Provider,
                Quota = item.Quota,
                Symbol = item.Symbol
            };
        }
    }
}
