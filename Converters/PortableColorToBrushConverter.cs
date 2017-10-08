namespace UWPDesign.Converters
{
    using Models;
    using System;
    using System.Collections.Generic;
    using Windows.UI;
    using Windows.UI.Xaml.Data;
    using Windows.UI.Xaml.Media;

    public class PortableColorToBrushConverter : IValueConverter
    {
        private static Dictionary<PortableColor, SolidColorBrush> brushesCache = new Dictionary<PortableColor, SolidColorBrush>();

        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (value != null)
            {
                var color = (PortableColor)value;
                if (!brushesCache.ContainsKey(color))
                {
                    brushesCache[color] = new SolidColorBrush(Color.FromArgb(color.A, color.R, color.G, color.B));
                }

                return brushesCache[color];
            }

            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}