namespace UWPDesign.Helpers
{
    using System;
    using System.Globalization;
    using UWPDesign.Models;
    using Windows.UI;

    public static class ColorExtensionMethods
    {
        public static Color ToColor(this PortableColor portableColor)
        {
            return Color.FromArgb(portableColor.A, portableColor.R, portableColor.G, portableColor.B);
        }

        public static Color ToColor(this string colorString)
        {
            if (colorString.Length != 9)
            {
                throw new ArgumentException(string.Format("Use #AARRGGBB format. Actual: {0}", colorString));
            }

            var a = (byte)Int32.Parse(colorString.Substring(1, 2), NumberStyles.HexNumber);
            var r = (byte)Int32.Parse(colorString.Substring(3, 2), NumberStyles.HexNumber);
            var g = (byte)Int32.Parse(colorString.Substring(5, 2), NumberStyles.HexNumber);
            var b = (byte)Int32.Parse(colorString.Substring(7, 2), NumberStyles.HexNumber);

            return Color.FromArgb(a, r, g, b);
        }
    }
}