namespace Ceiba.OrleansStart.Core
{
    using System.Net.Http;
    using System.Threading.Tasks;
    using Comms;
    using Newtonsoft.Json;

    public class MarkitStockProvider: IStockProvider
    {
        #region IStockProvider Members

        public Task<StockQuota> GetQuotaAsync( string symbol )
        {
            return this.GetPriceFromMarkitAsync( symbol );
        }

        #endregion

        #region Private Methods

        private async Task<StockQuota> GetPriceFromMarkitAsync( string symbol )
        {
            var quota = new StockQuota();
            var http = new HttpClient();
            string uri = "http://dev.markitondemand.com/Api/v2/Quote/json?symbol=" + symbol;

            using( HttpResponseMessage response = await http.GetAsync( uri ) )
            {
                string json = await response.Content.ReadAsStringAsync();

                try
                {
                    quota = JsonConvert.DeserializeObject<StockQuota>( json );
                }
                catch( JsonReaderException )
                {
                    // We ignore serialization exceptions.
                }
            }

            return quota;
        }

        #endregion
    }
}
