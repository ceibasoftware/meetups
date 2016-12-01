namespace Ceiba.OrleansStart.Core
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Comms;
    using Orleans;
    using Orleans.Concurrency;

    [StatelessWorker]
    public class CompanyLookupGrain: Grain, ICompanyLookupGrain
    {
        public Task<IEnumerable<Company>> LookupCompany( string name )
        {
            ICompanyLookupProvider provider = new MarkitCompanyLookupProvider();
            return provider.LookupCompany( name );
        }
    }
}
