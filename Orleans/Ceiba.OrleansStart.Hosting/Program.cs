namespace Ceiba.OrleansStart.Hosting
{
    using System;

    /// <summary>
    /// Orleans test silo host
    /// </summary>
    public class Program
    {
        private static OrleansHostWrapper hostWrapper;

        static void Main( string[] args )
        {
            AppDomain hostDomain = AppDomain.CreateDomain( "OrleansHost", null, new AppDomainSetup
            {
                AppDomainInitializer = InitSilo,
                AppDomainInitializerArguments = args,
            } );

            Console.WriteLine( "Orleans Silo is running.\nPress Enter to terminate..." );
            Console.ReadLine();

            hostDomain.DoCallBack( ShutdownSilo );
        }

        private static void InitSilo( string[] args )
        {
            hostWrapper = new OrleansHostWrapper( args );

            if( !hostWrapper.Run() )
            {
                Console.Error.WriteLine( "Failed to initialize Orleans silo" );
            }
        }

        private static void ShutdownSilo()
        {
            if( hostWrapper != null )
            {
                hostWrapper.Dispose();
                GC.SuppressFinalize( hostWrapper );
            }
        }
    }
}
