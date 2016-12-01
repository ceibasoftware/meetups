namespace Ceiba.OrleansStart.Core
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Net.Http;
    using System.Threading.Tasks;
    using Comms;
    using Newtonsoft.Json;

    public class MarkitCompanyLookupProvider: ICompanyLookupProvider
    {
        public Task<IEnumerable<Company>> LookupCompany( string name )
        {
            return this.GetCompaniesFromMarkit( name );
        }

        private async Task<IEnumerable<Company>> GetCompaniesFromMarkit( string name )
        {
            var companies = new List<Company>();
            var http = new HttpClient();
            string uri = "http://dev.markitondemand.com/Api/v2/Lookup/json?input=" + name;

            using( HttpResponseMessage response = await http.GetAsync( uri ) )
            {
                string json = await response.Content.ReadAsStringAsync();

                try
                {
                    var result = JsonConvert.DeserializeObject<List<Company>>( json );
                    companies.AddRange( result.Take( 5 ) );
                }
                catch( JsonReaderException )
                {
                    // We ignore serialization exceptions.
                }
            }

            return companies;
        }
    }
}
