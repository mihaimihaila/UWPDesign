namespace UWPDesign.Models
{
    using System.Collections.Generic;

    public enum MaterialColorName
    {
        Red,
        Pink,
        Purple,
        DeepPurple,
        Indigo,
        Blue,
        LightBlue,
        Cyan,
        Teal,
        Green,
        LightGreen,
        Lime,
        Yellow,
        Amber,
        Orange,
        DeepOrange,
        Brown,
        Grey,
        BlueGrey
    }

    public enum MaterialColorVariation
    {
        Variation50,
        Variation100,
        Variation200,
        Variation300,
        Variation400,
        Variation500,
        Variation600,
        Variation700,
        Variation800,
        Variation900,
        VariationA700
    }

    public class MaterialColor
    {
        public Dictionary<MaterialColorVariation, PortableColor> Variations { get; set; }

        public MaterialColor()
        {
            Variations = new Dictionary<MaterialColorVariation, PortableColor>();
        }

        public static PortableColor White = new PortableColor("#FFFFFFFF");

        public static PortableColor Black = new PortableColor("#FF000000");

        public static Dictionary<MaterialColorName, MaterialColor> Colors = new Dictionary<MaterialColorName, MaterialColor>
        {
            {
                MaterialColorName.Red,
                new MaterialColor
                {
                    Variations =
                    {
                        { MaterialColorVariation.Variation50, new PortableColor("#FFFFEBEE") },
                        { MaterialColorVariation.Variation100, new PortableColor("#FFFFCDD2") },
                        { MaterialColorVariation.Variation200, new PortableColor("#FFEF9A9A") },
                        { MaterialColorVariation.Variation300, new PortableColor("#FFE57373") },
                        { MaterialColorVariation.Variation400, new PortableColor("#FFEF5350") },
                        { MaterialColorVariation.Variation500, new PortableColor("#FFF44336") },
                        { MaterialColorVariation.Variation600, new PortableColor("#FFE53935") },
                        { MaterialColorVariation.Variation700, new PortableColor("#FFD32F2F") },
                        { MaterialColorVariation.Variation800, new PortableColor("#FFC62828") },
                        { MaterialColorVariation.Variation900, new PortableColor("#FFB71C1C") },
                        { MaterialColorVariation.VariationA700, new PortableColor("#FFD50000") }
                    }
                }
            },
            {
             MaterialColorName.Pink,
             new MaterialColor
             {
                Variations = new Dictionary<MaterialColorVariation,PortableColor>
                {
                    { MaterialColorVariation.Variation50, new PortableColor("#FFFCE4EC") },
                    { MaterialColorVariation.Variation100, new PortableColor("#FFF8BBD0") },
                    { MaterialColorVariation.Variation200, new PortableColor("#FFF48FB1") },
                    { MaterialColorVariation.Variation300, new PortableColor("#FFF06292") },
                    { MaterialColorVariation.Variation400, new PortableColor("#FFEC407A") },
                    { MaterialColorVariation.Variation500, new PortableColor("#FFE91E63") },
                    { MaterialColorVariation.Variation600, new PortableColor("#FFD81B60") },
                    { MaterialColorVariation.Variation700, new PortableColor("#FFC2185B") },
                    { MaterialColorVariation.Variation800, new PortableColor("#FFAD1457") },
                    { MaterialColorVariation.Variation900, new PortableColor("#FF880E4F") },
                    { MaterialColorVariation.VariationA700, new PortableColor("#FFC51162") }
                }
              }
            },
            {
                MaterialColorName.Purple,
                new MaterialColor
                {
                    Variations = new Dictionary<MaterialColorVariation,PortableColor>
                    {
                        { MaterialColorVariation.Variation50, new PortableColor("#FFF3E5F5") },
                        { MaterialColorVariation.Variation100, new PortableColor("#FFE1BEE7") },
                        { MaterialColorVariation.Variation200, new PortableColor("#FFCE93D8") },
                        { MaterialColorVariation.Variation300, new PortableColor("#FFBA68C8") },
                        { MaterialColorVariation.Variation400, new PortableColor("#FFAB47BC") },
                        { MaterialColorVariation.Variation500, new PortableColor("#FF9C27B0") },
                        { MaterialColorVariation.Variation600, new PortableColor("#FF8E24AA") },
                        { MaterialColorVariation.Variation700, new PortableColor("#FF7B1FA2") },
                        { MaterialColorVariation.Variation800, new PortableColor("#FF6A1B9A") },
                        { MaterialColorVariation.Variation900, new PortableColor("#FF4A148C") },
                        { MaterialColorVariation.VariationA700, new PortableColor("#FFAA00FF") }
                    }
                }
            },
            {
                MaterialColorName.DeepPurple,
                new MaterialColor
                {
                    Variations = new Dictionary<MaterialColorVariation,PortableColor>
                    {
                        { MaterialColorVariation.Variation50, new PortableColor("#FFEDE7F6") },
                        { MaterialColorVariation.Variation100, new PortableColor("#FFD1C4E9") },
                        { MaterialColorVariation.Variation200, new PortableColor("#FFB39DDB") },
                        { MaterialColorVariation.Variation300, new PortableColor("#FF9575CD") },
                        { MaterialColorVariation.Variation400, new PortableColor("#FF7E57C2") },
                        { MaterialColorVariation.Variation500, new PortableColor("#FF673AB7") },
                        { MaterialColorVariation.Variation600, new PortableColor("#FF5E35B1") },
                        { MaterialColorVariation.Variation700, new PortableColor("#FF512DA8") },
                        { MaterialColorVariation.Variation800, new PortableColor("#FF4527A0") },
                        { MaterialColorVariation.Variation900, new PortableColor("#FF311B92") },
                        { MaterialColorVariation.VariationA700, new PortableColor("#FF6200EA") }
                    }
                }
            },
            {
                MaterialColorName.Indigo,
                new MaterialColor
                {
                    Variations = new Dictionary<MaterialColorVariation,PortableColor>
                    {
                        { MaterialColorVariation.Variation50, new PortableColor("#FFE8EAF6") },
                        { MaterialColorVariation.Variation100, new PortableColor("#FFC5CAE9") },
                        { MaterialColorVariation.Variation200, new PortableColor("#FF9FA8DA") },
                        { MaterialColorVariation.Variation300, new PortableColor("#FF7986CB") },
                        { MaterialColorVariation.Variation400, new PortableColor("#FF5C6BC0") },
                        { MaterialColorVariation.Variation500, new PortableColor("#FF3F51B5") },
                        { MaterialColorVariation.Variation600, new PortableColor("#FF3949AB") },
                        { MaterialColorVariation.Variation700, new PortableColor("#FF303F9F") },
                        { MaterialColorVariation.Variation800, new PortableColor("#FF283593") },
                        { MaterialColorVariation.Variation900, new PortableColor("#FF1A237E") },
                        { MaterialColorVariation.VariationA700, new PortableColor("#FF304FFE") }
                    }
                }
            },
            {
                MaterialColorName.Blue,
                new MaterialColor
                {
                    Variations = new Dictionary<MaterialColorVariation,PortableColor>
                    {
                        { MaterialColorVariation.Variation50, new PortableColor("#FFE3F2FD") },
                        { MaterialColorVariation.Variation100, new PortableColor("#FFBBDEFB") },
                        { MaterialColorVariation.Variation200, new PortableColor("#FF90CAF9") },
                        { MaterialColorVariation.Variation300, new PortableColor("#FF64B5F6") },
                        { MaterialColorVariation.Variation400, new PortableColor("#FF42A5F5") },
                        { MaterialColorVariation.Variation500, new PortableColor("#FF2196F3") },
                        { MaterialColorVariation.Variation600, new PortableColor("#FF1E88E5") },
                        { MaterialColorVariation.Variation700, new PortableColor("#FF1976D2") },
                        { MaterialColorVariation.Variation800, new PortableColor("#FF1565C0") },
                        { MaterialColorVariation.Variation900, new PortableColor("#FF0D47A1") },
                        { MaterialColorVariation.VariationA700, new PortableColor("#FF2962FF") }
                    }
                }
            },
            {
                MaterialColorName.LightBlue,
                new MaterialColor
                {
                    Variations = new Dictionary<MaterialColorVariation,PortableColor>
                    {
                        { MaterialColorVariation.Variation50, new PortableColor("#FFE1F5FE") },
                        { MaterialColorVariation.Variation100, new PortableColor("#FFB3E5FC") },
                        { MaterialColorVariation.Variation200, new PortableColor("#FF81D4FA") },
                        { MaterialColorVariation.Variation300, new PortableColor("#FF4FC3F7") },
                        { MaterialColorVariation.Variation400, new PortableColor("#FF29B6F6") },
                        { MaterialColorVariation.Variation500, new PortableColor("#FF03A9F4") },
                        { MaterialColorVariation.Variation600, new PortableColor("#FF039BE5") },
                        { MaterialColorVariation.Variation700, new PortableColor("#FF0288D1") },
                        { MaterialColorVariation.Variation800, new PortableColor("#FF0277BD") },
                        { MaterialColorVariation.Variation900, new PortableColor("#FF01579B") },
                        { MaterialColorVariation.VariationA700, new PortableColor("#FF0091EA") }
                    }
                }
            },
            {
                MaterialColorName.Cyan,
                new MaterialColor
                {
                    Variations = new Dictionary<MaterialColorVariation,PortableColor>
                    {
                        { MaterialColorVariation.Variation50, new PortableColor("#FFE0F7FA") },
                        { MaterialColorVariation.Variation100, new PortableColor("#FFB2EBF2") },
                        { MaterialColorVariation.Variation200, new PortableColor("#FF80DEEA") },
                        { MaterialColorVariation.Variation300, new PortableColor("#FF4DD0E1") },
                        { MaterialColorVariation.Variation400, new PortableColor("#FF26C6DA") },
                        { MaterialColorVariation.Variation500, new PortableColor("#FF00BCD4") },
                        { MaterialColorVariation.Variation600, new PortableColor("#FF00ACC1") },
                        { MaterialColorVariation.Variation700, new PortableColor("#FF0097A7") },
                        { MaterialColorVariation.Variation800, new PortableColor("#FF00838F") },
                        { MaterialColorVariation.Variation900, new PortableColor("#FF006064") },
                        { MaterialColorVariation.VariationA700, new PortableColor("#FF00B8D4") }
                    }
                }
            },
            {
                MaterialColorName.Teal,
                new MaterialColor
                {
                    Variations = new Dictionary<MaterialColorVariation,PortableColor>
                    {
                        { MaterialColorVariation.Variation50, new PortableColor("#FFE0F2F1") },
                        { MaterialColorVariation.Variation100, new PortableColor("#FFB2DFDB") },
                        { MaterialColorVariation.Variation200, new PortableColor("#FF80CBC4") },
                        { MaterialColorVariation.Variation300, new PortableColor("#FF4DB6AC") },
                        { MaterialColorVariation.Variation400, new PortableColor("#FF26A69A") },
                        { MaterialColorVariation.Variation500, new PortableColor("#FF009688") },
                        { MaterialColorVariation.Variation600, new PortableColor("#FF00897B") },
                        { MaterialColorVariation.Variation700, new PortableColor("#FF00796B") },
                        { MaterialColorVariation.Variation800, new PortableColor("#FF00695C") },
                        { MaterialColorVariation.Variation900, new PortableColor("#FF004D40") },
                        { MaterialColorVariation.VariationA700, new PortableColor("#FF00BFA5") }
                    }
                }
            },
            {
                MaterialColorName.Green,
                new MaterialColor
                {
                    Variations = new Dictionary<MaterialColorVariation,PortableColor>
                    {
                        { MaterialColorVariation.Variation50, new PortableColor("#FFE8F5E9") },
                        { MaterialColorVariation.Variation100, new PortableColor("#FFC8E6C9") },
                        { MaterialColorVariation.Variation200, new PortableColor("#FFA5D6A7") },
                        { MaterialColorVariation.Variation300, new PortableColor("#FF81C784") },
                        { MaterialColorVariation.Variation400, new PortableColor("#FF66BB6A") },
                        { MaterialColorVariation.Variation500, new PortableColor("#FF4CAF50") },
                        { MaterialColorVariation.Variation600, new PortableColor("#FF43A047") },
                        { MaterialColorVariation.Variation700, new PortableColor("#FF388E3C") },
                        { MaterialColorVariation.Variation800, new PortableColor("#FF2E7D32") },
                        { MaterialColorVariation.Variation900, new PortableColor("#FF1B5E20") },
                        { MaterialColorVariation.VariationA700, new PortableColor("#FF00C853") }
                    }
                }
            },
            {
                MaterialColorName.LightGreen,
                new MaterialColor
                {
                    Variations = new Dictionary<MaterialColorVariation,PortableColor>
                    {
                        { MaterialColorVariation.Variation50, new PortableColor("#FFF1F8E9") },
                        { MaterialColorVariation.Variation100, new PortableColor("#FFDCEDC8") },
                        { MaterialColorVariation.Variation200, new PortableColor("#FFC5E1A5") },
                        { MaterialColorVariation.Variation300, new PortableColor("#FFAED581") },
                        { MaterialColorVariation.Variation400, new PortableColor("#FF9CCC65") },
                        { MaterialColorVariation.Variation500, new PortableColor("#FF8BC34A") },
                        { MaterialColorVariation.Variation600, new PortableColor("#FF7CB342") },
                        { MaterialColorVariation.Variation700, new PortableColor("#FF689F38") },
                        { MaterialColorVariation.Variation800, new PortableColor("#FF558B2F") },
                        { MaterialColorVariation.Variation900, new PortableColor("#FF33691E") },
                        { MaterialColorVariation.VariationA700, new PortableColor("#FF64DD17") }
                    }
                }
            },
            {
                MaterialColorName.Lime,
                new MaterialColor
                {
                    Variations = new Dictionary<MaterialColorVariation,PortableColor>
                    {
                        { MaterialColorVariation.Variation50, new PortableColor("#FFF9FBE7") },
                        { MaterialColorVariation.Variation100, new PortableColor("#FFF0F4C3") },
                        { MaterialColorVariation.Variation200, new PortableColor("#FFE6EE9C") },
                        { MaterialColorVariation.Variation300, new PortableColor("#FFDCE775") },
                        { MaterialColorVariation.Variation400, new PortableColor("#FFD4E157") },
                        { MaterialColorVariation.Variation500, new PortableColor("#FFCDDC39") },
                        { MaterialColorVariation.Variation600, new PortableColor("#FFC0CA33") },
                        { MaterialColorVariation.Variation700, new PortableColor("#FFAFB42B") },
                        { MaterialColorVariation.Variation800, new PortableColor("#FF9E9D24") },
                        { MaterialColorVariation.Variation900, new PortableColor("#FF827717") },
                        { MaterialColorVariation.VariationA700, new PortableColor("#FFAEEA00") }
                    }
                }
            },
            {
                MaterialColorName.Yellow,
                new MaterialColor
                {
                    Variations = new Dictionary<MaterialColorVariation,PortableColor>
                    {
                        { MaterialColorVariation.Variation50, new PortableColor("#FFFFFDE7") },
                        { MaterialColorVariation.Variation100, new PortableColor("#FFFFF9C4") },
                        { MaterialColorVariation.Variation200, new PortableColor("#FFFFF59D") },
                        { MaterialColorVariation.Variation300, new PortableColor("#FFFFF176") },
                        { MaterialColorVariation.Variation400, new PortableColor("#FFFFEE58") },
                        { MaterialColorVariation.Variation500, new PortableColor("#FFFFEB3B") },
                        { MaterialColorVariation.Variation600, new PortableColor("#FFFDD835") },
                        { MaterialColorVariation.Variation700, new PortableColor("#FFFBC02D") },
                        { MaterialColorVariation.Variation800, new PortableColor("#FFF9A825") },
                        { MaterialColorVariation.Variation900, new PortableColor("#FFF57F17") },
                        { MaterialColorVariation.VariationA700, new PortableColor("#FFFFD600") }
                    }
                }
            },
            {
                MaterialColorName.Amber,
                new MaterialColor
                {
                    Variations = new Dictionary<MaterialColorVariation,PortableColor>
                    {
                        { MaterialColorVariation.Variation50, new PortableColor("#FFFFF8E1") },
                        { MaterialColorVariation.Variation100, new PortableColor("#FFFFECB3") },
                        { MaterialColorVariation.Variation200, new PortableColor("#FFFFE082") },
                        { MaterialColorVariation.Variation300, new PortableColor("#FFFFD54F") },
                        { MaterialColorVariation.Variation400, new PortableColor("#FFFFCA28") },
                        { MaterialColorVariation.Variation500, new PortableColor("#FFFFC107") },
                        { MaterialColorVariation.Variation600, new PortableColor("#FFFFB300") },
                        { MaterialColorVariation.Variation700, new PortableColor("#FFFFA000") },
                        { MaterialColorVariation.Variation800, new PortableColor("#FFFF8F00") },
                        { MaterialColorVariation.Variation900, new PortableColor("#FFFF6F00") },
                        { MaterialColorVariation.VariationA700, new PortableColor("#FFFFAB00") }
                    }
                }
            },
            {
                MaterialColorName.Orange,
                new MaterialColor
                {
                    Variations = new Dictionary<MaterialColorVariation,PortableColor>
                    {
                        { MaterialColorVariation.Variation50, new PortableColor("#FFFFF3E0") },
                        { MaterialColorVariation.Variation100, new PortableColor("#FFFFE0B2") },
                        { MaterialColorVariation.Variation200, new PortableColor("#FFFFCC80") },
                        { MaterialColorVariation.Variation300, new PortableColor("#FFFFB74D") },
                        { MaterialColorVariation.Variation400, new PortableColor("#FFFFA726") },
                        { MaterialColorVariation.Variation500, new PortableColor("#FFFF9800") },
                        { MaterialColorVariation.Variation600, new PortableColor("#FFFB8C00") },
                        { MaterialColorVariation.Variation700, new PortableColor("#FFF57C00") },
                        { MaterialColorVariation.Variation800, new PortableColor("#FFEF6C00") },
                        { MaterialColorVariation.Variation900, new PortableColor("#FFE65100") },
                        { MaterialColorVariation.VariationA700, new PortableColor("#FFFF6D00") }
                    }
                }
            },
            {
                MaterialColorName.DeepOrange,
                new MaterialColor
                {
                    Variations = new Dictionary<MaterialColorVariation,PortableColor>
                    {
                        { MaterialColorVariation.Variation50, new PortableColor("#FFFBE9E7") },
                        { MaterialColorVariation.Variation100, new PortableColor("#FFFFCCBC") },
                        { MaterialColorVariation.Variation200, new PortableColor("#FFFFAB91") },
                        { MaterialColorVariation.Variation300, new PortableColor("#FFFF8A65") },
                        { MaterialColorVariation.Variation400, new PortableColor("#FFFF7043") },
                        { MaterialColorVariation.Variation500, new PortableColor("#FFFF5722") },
                        { MaterialColorVariation.Variation600, new PortableColor("#FFF4511E") },
                        { MaterialColorVariation.Variation700, new PortableColor("#FFE64A19") },
                        { MaterialColorVariation.Variation800, new PortableColor("#FFD84315") },
                        { MaterialColorVariation.Variation900, new PortableColor("#FFBF360C") },
                        { MaterialColorVariation.VariationA700, new PortableColor("#FFDD2C00") }
                    }
                }
            },
            {
                MaterialColorName.Brown,
                new MaterialColor
                {
                    Variations = new Dictionary<MaterialColorVariation,PortableColor>
                    {
                        { MaterialColorVariation.Variation50, new PortableColor("#FFEFEBE9") },
                        { MaterialColorVariation.Variation100, new PortableColor("#FFD7CCC8") },
                        { MaterialColorVariation.Variation200, new PortableColor("#FFBCAAA4") },
                        { MaterialColorVariation.Variation300, new PortableColor("#FFA1887F") },
                        { MaterialColorVariation.Variation400, new PortableColor("#FF8D6E63") },
                        { MaterialColorVariation.Variation500, new PortableColor("#FF795548") },
                        { MaterialColorVariation.Variation600, new PortableColor("#FF6D4C41") },
                        { MaterialColorVariation.Variation700, new PortableColor("#FF5D4037") },
                        { MaterialColorVariation.Variation800, new PortableColor("#FF4E342E") },
                        { MaterialColorVariation.Variation900, new PortableColor("#FF3E2723") }
                    }
                }
            },
            {
                MaterialColorName.Grey,
                new MaterialColor
                {
                    Variations = new Dictionary<MaterialColorVariation,PortableColor>
                    {
                        { MaterialColorVariation.Variation50, new PortableColor("#FFFAFAFA") },
                        { MaterialColorVariation.Variation100, new PortableColor("#FFF5F5F5") },
                        { MaterialColorVariation.Variation200, new PortableColor("#FFEEEEEE") },
                        { MaterialColorVariation.Variation300, new PortableColor("#FFE0E0E0") },
                        { MaterialColorVariation.Variation400, new PortableColor("#FFBDBDBD") },
                        { MaterialColorVariation.Variation500, new PortableColor("#FF9E9E9E") },
                        { MaterialColorVariation.Variation600, new PortableColor("#FF757575") },
                        { MaterialColorVariation.Variation700, new PortableColor("#FF616161") },
                        { MaterialColorVariation.Variation800, new PortableColor("#FF424242") },
                        { MaterialColorVariation.Variation900, new PortableColor("#FF212121") },
                    }
                }
            },
            {
                MaterialColorName.BlueGrey,
                new MaterialColor
                {
                    Variations = new Dictionary<MaterialColorVariation,PortableColor>
                    {
                        { MaterialColorVariation.Variation50, new PortableColor("#FFECEFF1") },
                        { MaterialColorVariation.Variation100, new PortableColor("#FFCFD8DC") },
                        { MaterialColorVariation.Variation200, new PortableColor("#FFB0BEC5") },
                        { MaterialColorVariation.Variation300, new PortableColor("#FF90A4AE") },
                        { MaterialColorVariation.Variation400, new PortableColor("#FF78909C") },
                        { MaterialColorVariation.Variation500, new PortableColor("#FF607D8B") },
                        { MaterialColorVariation.Variation600, new PortableColor("#FF546E7A") },
                        { MaterialColorVariation.Variation700, new PortableColor("#FF455A64") },
                        { MaterialColorVariation.Variation800, new PortableColor("#FF37474F") },
                        { MaterialColorVariation.Variation900, new PortableColor("#FF263238") },
                    }
                }
            }
        };
    }
}