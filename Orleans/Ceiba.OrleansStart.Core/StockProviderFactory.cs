namespace Ceiba.OrleansStart.Core
{
    using System;

    internal static class StockProviderFactory
    {
        private const StringComparison stringComparison = StringComparison.OrdinalIgnoreCase;

        public static IStockProvider Create( string name )
        {
            if( name.Equals( "yahoo", stringComparison ) )
            {
                return new YahooStockProvider();
            }

            if( name.Equals( "markit", stringComparison ) )
            {
                return new MarkitStockProvider();
            }

            return null;
        }
    }
}
