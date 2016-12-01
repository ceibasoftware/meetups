namespace Ceiba.OrleansStart.Core
{
    using System.Net.Http;
    using System.Threading.Tasks;
    using Comms;

    public class YahooStockProvider: IStockProvider
    {
        #region IStockProvider Members

        public Task<StockQuota> GetQuotaAsync( string symbol )
        {
            return GetPriceFromYahooAsync( symbol );
        }

        #endregion

        #region Private Methods

        private async Task<StockQuota> GetPriceFromYahooAsync( string symbol )
        {
            StockQuota quota = null;
            var http = new HttpClient();
            string uri = "http://download.finance.yahoo.com/d/quotes.csv?f=snl1c1p2&e=.csv&s=" + symbol;

            using( HttpResponseMessage response = await http.GetAsync( uri ) )
            {
                string csv = await response.Content.ReadAsStringAsync();
                quota = ParseQuota( csv, symbol );
            }

            return quota;
        }

        private static StockQuota ParseQuota( string csv, string symbol )
        {
            var quota = new StockQuota();

            string[] data = csv.Split( ',' );

            quota.Symbol = data[0].Trim( '"' ).ToUpperInvariant();

            decimal change;
            if( decimal.TryParse( data[3], out change ) )
            {
                quota.Change = change;
            }

            decimal price;
            if( decimal.TryParse( data[2], out price ) )
            {
                quota.Price = price;
            }

            quota.Company = data[1].Trim( '"' );
            quota.Exchange = "NASDAQ";

            return quota;
        }

        #endregion
    }
}
