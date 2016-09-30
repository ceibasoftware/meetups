namespace WebApi
{
    using System.IO;
    using System.Threading;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.ServiceFabric.Services.Runtime;

    public class Program
    {
        public static void Main(string[] args)
        {
            ServiceRuntime.RegisterServiceAsync( "WebApiType", context => new WebHostingService( context, "ServiceEndpoint" ) ).GetAwaiter().GetResult();
            Thread.Sleep( Timeout.Infinite );
        }
    }
}
