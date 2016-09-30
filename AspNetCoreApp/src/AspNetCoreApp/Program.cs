namespace AspNetCoreApp
{
    using System.Threading;
    using Microsoft.ServiceFabric.Services.Runtime;

    public class Program
    {
        //public static void Main(string[] args)
        //{
        //    var host = new WebHostBuilder()
        //        .UseKestrel()
        //        .UseContentRoot(Directory.GetCurrentDirectory())
        //        .UseIISIntegration()
        //        .UseStartup<Startup>()
        //        .Build();

        //    host.Run();
        //}

        // Entry point for the application.
        public static void Main( string[] args )
        {
            ServiceRuntime.RegisterServiceAsync( "AspNetCoreAppType", context => new WebHostingService( context, "ServiceEndpoint" ) ).GetAwaiter().GetResult();
            Thread.Sleep( Timeout.Infinite );
        }
    }
}
