namespace Ceiba.OrleansStart.DesktopClient
{
    using System;
    using System.Collections.ObjectModel;
    using System.ComponentModel;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Windows.Input;
    using Comms;
    using Orleans;
    using Orleans.Runtime;
    using Orleans.Runtime.Configuration;

    public class MainViewModel: INotifyPropertyChanged
    {
        #region Data Members

        private string companyLookup;
        private Company selectedCompany;
        private readonly ObservableCollection<StockItem> items;
        private readonly ObservableCollection<Company> companies;

        private readonly Guid currentUser;
        private readonly IStockGrain stockGrain;
        private readonly ITraderGrain traderGrain;
        private readonly ICompanyLookupGrain lookupGrain;
        

        private ICommand followCommand;
        private ICommand lookupCommand;

        #endregion

        #region Construction

        public MainViewModel()
        {
            InitializeSilo();

            this.currentUser = Guid.NewGuid();

            this.items = new ObservableCollection<StockItem>();
            this.companies = new ObservableCollection<Company>();

            this.stockGrain = GrainClient.GrainFactory.GetGrain<IStockGrain>( "NASDAQ" );
            this.traderGrain = GrainClient.GrainFactory.GetGrain<ITraderGrain>( this.currentUser );
            this.lookupGrain = GrainClient.GrainFactory.GetGrain<ICompanyLookupGrain>( 0 );

            this.traderGrain.FollowStockAsync( this.stockGrain ).Wait();
        }

        #endregion

        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        #region Properties

        public Guid CurrentUser
        {
            get { return this.currentUser; }
        }

        public string CompanyLookup
        {
            get { return this.companyLookup; }
            set
            {
                this.companyLookup = value;
                this.RaiseOnPropertyChanged( nameof( CompanyLookup ) );
            }
        }

        public Company SelectedCompany
        {
            get { return this.selectedCompany; }
            set
            {
                this.selectedCompany = value;
                this.RaiseOnPropertyChanged( nameof( this.SelectedCompany ) );
            }
        }

        public ObservableCollection<StockItem> Items
        {
            get { return this.items; }
        }

        public ObservableCollection<Company> Companies
        {
            get { return this.companies; }
        }

        public bool AvailableCompanies
        {
            get { return this.companies.Count == 0; }
        }

        public ICommand LookupCommand
        {
            get
            {
                if( this.lookupCommand == null )
                {
                    this.lookupCommand = new ActionCommand( this.LookupCompany );
                }

                return this.lookupCommand;
            }
        }

        public ICommand FollowCompanyCommand
        {
            get
            {
                if( this.followCommand == null )
                {
                    this.followCommand = new ActionCommand( this.FollowCompany );
                }

                return this.followCommand;
            }
        }

        #endregion

        #region Public Methods

        public async Task UpdateAsync()
        {
            var stockItems = this.Items.ToList();

            foreach( StockItem item in stockItems )
            {
                Stock stock = item.ToStock();
                StockQuota quota = await this.traderGrain.GetQuotaAsync( stock );
                item.Quota = quota;

                this.UpdateStocks( item );
            }
        }

        #endregion

        #region Private Methods

        private void LookupCompany( object name )
        {
            this.Companies.Clear();

            var result = this.lookupGrain.LookupCompany( this.CompanyLookup.Trim() ).Result;

            foreach( Company company in result )
            {
                this.Companies.Add( company );
            }

            this.CompanyLookup = string.Empty;
        }

        private void FollowCompany( object o )
        {
            var stock = new Stock { Provider = "yahoo", Symbol = this.SelectedCompany.Symbol };

            StockQuota quota = this.traderGrain.GetQuotaAsync( stock ).Result;
            StockItem item = stock.ToStockItem();
            item.Quota = quota;

            this.Companies.Clear();
            this.UpdateStocks( item );
        }

        private void UpdateStocks( StockItem stock )
        {
            StockItem followed = this.Items.SingleOrDefault( s => s.Symbol.Equals( stock.Symbol, StringComparison.OrdinalIgnoreCase ) );

            if( followed == null )
            {
                this.Items.Add( stock );
            }
            else
            {
                followed.Quota = stock.Quota;
            }
        }

        private static void InitializeSilo()
        {
            try
            {
                var config = ClientConfiguration.LocalhostSilo();
                GrainClient.Initialize( config );
            }
            catch( SiloUnavailableException )
            {
                // We re-try until silo is available.
                InitializeSilo();
            }
        }

        private void RaiseOnPropertyChanged( string propertyName )
        {
            this.PropertyChanged?.Invoke( this, new PropertyChangedEventArgs( propertyName ) );
        }

        #endregion
    }
}
