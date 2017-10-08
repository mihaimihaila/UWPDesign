namespace UWPDesign.Converters
{
    using Models;
    using System;
    using Windows.UI;
    using Windows.UI.Xaml.Data;

    public class PortableColorToColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (value != null)
            {
                var color = (PortableColor)value;
                return Color.FromArgb(color.A, color.R, color.G, color.B);
            }

            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}