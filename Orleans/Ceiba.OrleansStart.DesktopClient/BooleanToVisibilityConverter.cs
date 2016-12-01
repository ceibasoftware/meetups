namespace Ceiba.OrleansStart.DesktopClient
{
    using System;
    using System.Globalization;
    using System.Windows;
    using System.Windows.Data;

    public class BooleanToVisibilityConverter: IValueConverter
    {
        public object Convert( object value, Type targetType, object parameter, CultureInfo culture )
        {
            var assertion = (bool) value;
            return assertion ? Visibility.Visible : Visibility.Hidden;
        }

        public object ConvertBack( object value, Type targetType, object parameter, CultureInfo culture )
        {
            throw new NotImplementedException();
        }
    }
}
