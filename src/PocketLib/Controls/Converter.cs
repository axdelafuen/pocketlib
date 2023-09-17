using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace PocketLib.Controls;

public class Converter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if(value == null) {  return false; }
        if(String.IsNullOrEmpty(value.ToString())) { return false; } 
        return true;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}