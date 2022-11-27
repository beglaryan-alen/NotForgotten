using System;
using System.Globalization;
using System.Linq;
using Xamarin.Forms;

namespace NotForgotten.Converters
{
    internal class PercentConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            if (values.Any(x => x == null))
                return null;
            double downloadedSize = double.Parse(values[0].ToString());
            double fileSize = double.Parse(values[1].ToString());
            return (downloadedSize * 100) / fileSize;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
