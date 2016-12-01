namespace Ceiba.OrleansStart.DesktopClient
{
    using System;
    using System.Windows;
    using System.Windows.Threading;

    public partial class MainWindow: Window
    {
        private readonly DispatcherTimer timer;

        public MainWindow()
        {
            InitializeComponent();

            this.timer = new DispatcherTimer( TimeSpan.FromSeconds( 5 ), DispatcherPriority.Background, this.Timer_Tick, this.Dispatcher );
            this.timer.Start();
        }

        private void Window_Loaded( object sender, RoutedEventArgs e )
        {
        }

        private async void Timer_Tick( object sender, EventArgs e )
        {
            this.timer.Stop();
            await this.viewModel.UpdateAsync();

            this.updateTime.Text = "Last update: " + DateTime.Now.ToString( "dd/MM/yyyy hh:mm:ss" );
            this.timer.Start();
        }
    }
}
