namespace Ceiba.OrleansStart.DesktopClient
{
    using System.ComponentModel;
    using Comms;

    public class StockItem: INotifyPropertyChanged
    {
        private StockQuota quota;

        public string Symbol { get; set; }

        public string Provider { get; set; }

        public StockQuota Quota
        {
            get { return this.quota; }
            set
            {
                if( this.quota == null )
                {
                    this.quota = value;
                    this.RaiseOnPropertyChanged( nameof( this.Quota ) );

                    return;
                }

                if( value.Change != this.quota?.Change ||
                    value.Price != this.quota?.Price )
                {
                    this.quota = value;
                    this.RaiseOnPropertyChanged( nameof( this.Quota ) );
                }
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        private void RaiseOnPropertyChanged( string propertyName )
        {
            this.PropertyChanged?.Invoke( this, new PropertyChangedEventArgs( propertyName ) );
        }
    }
}
