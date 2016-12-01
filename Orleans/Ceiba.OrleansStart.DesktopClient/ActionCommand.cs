namespace Ceiba.OrleansStart.DesktopClient
{
    using System;
    using System.Windows.Input;

    public class ActionCommand: ICommand
    {
        private Action<object> execute;

        public ActionCommand( Action<object> execute )
        {
            this.execute = execute;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute( object parameter )
        {
            return true;
        }

        public void Execute( object parameter )
        {
            execute( parameter );
        }
    }
}
