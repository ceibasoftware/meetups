namespace Ceiba.OrleansStart.Core
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Comms;

    public interface ICompanyLookupProvider
    {
        Task<IEnumerable<Company>> LookupCompany( string name );
    }
}
