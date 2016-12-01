namespace Ceiba.OrleansStart.Comms
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Orleans;

    public interface ICompanyLookupGrain: IGrainWithIntegerKey
    {
        Task<IEnumerable<Company>> LookupCompany( string name );
    }
}
