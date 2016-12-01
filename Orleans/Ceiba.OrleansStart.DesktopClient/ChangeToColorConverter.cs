namespace Ceiba.OrleansStart.DesktopClient
{
    using System;
    using System.Globalization;
    using System.Windows.Data;
    using System.Windows.Media;

    public class ChangeToColorConverter: IValueConverter
    {
        public object Convert( object value, Type targetType, object parameter, CultureInfo culture )
        {
            var money = (decimal) value;

            if( money > 0 )
            {
                Color color = Color.FromRgb( 0, 255, 0 );
                return new SolidColorBrush( color );
            }
            else
            {
                Color color = Color.FromRgb( 255, 0, 0 );
                return new SolidColorBrush( color );
            }
        }

        public object ConvertBack( object value, Type targetType, object parameter, CultureInfo culture )
        {
            throw new NotImplementedException();
        }
    }
}
