namespace UWPDesign.Models
{
    using System;
    using System.Globalization;
    using System.Runtime.Serialization;

    [DataContract(Name = "Color")]
    public struct PortableColor
    {
        public static PortableColor Transparent = new PortableColor("#00000000");
        public byte A { get; set; }
        public byte R { get; set; }
        public byte G { get; set; }
        public byte B { get; set; }

        [DataMember(Name = "ARGB")]
        public string ARGB
        {
            get
            {
                return string.Format("#{0:X2}{1:X2}{2:X2}{3:X2}", A, R, G, B);
            }
        }

        public PortableColor(byte a, byte r, byte g, byte b)
        {
            A = a;
            R = r;
            G = g;
            B = b;
        }

        public PortableColor(string colorString)
        {
            if (colorString.Length != 9)
            {
                throw new ArgumentException(string.Format("Use #AARRGGBB format. Actual: {0}", colorString));
            }

            A = (byte)int.Parse(colorString.Substring(1, 2), NumberStyles.HexNumber);
            R = (byte)int.Parse(colorString.Substring(3, 2), NumberStyles.HexNumber);
            G = (byte)int.Parse(colorString.Substring(5, 2), NumberStyles.HexNumber);
            B = (byte)int.Parse(colorString.Substring(7, 2), NumberStyles.HexNumber);
        }

        public override bool Equals(Object obj)
        {
            return obj is PortableColor && this == (PortableColor)obj;
        }
        public override int GetHashCode()
        {
            return A.GetHashCode() ^ R.GetHashCode() ^ G.GetHashCode() ^ B.GetHashCode();
        }
        public static bool operator ==(PortableColor x, PortableColor y)
        {
            return x.A == y.A && x.R == y.R && x.G == y.G && x.B == y.B;
        }
        public static bool operator !=(PortableColor x, PortableColor y)
        {
            return !(x == y);
        }
    }
}