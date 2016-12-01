namespace Ceiba.OrleansStart.DesktopClient
{
    using System.Collections.ObjectModel;
    using Comms;

    public interface IUpdatable
    {
        void Update( ObservableCollection<Stock> updates );
    }
}
