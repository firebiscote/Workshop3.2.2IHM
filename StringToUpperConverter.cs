using System;
using System.Globalization;
using System.Windows.Data;

namespace Workshop3._2._2IHM
{
    public class StringToUpperConverter : IValueConverter
    {
        private const string errorMessage = "|TEXT>9CAR|";
        private const int maxLenght = 9;
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string text = value.ToString();
            return text.Length < maxLenght ? text.ToUpper() : errorMessage;
        }
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value.ToString();
        }
    }
}
