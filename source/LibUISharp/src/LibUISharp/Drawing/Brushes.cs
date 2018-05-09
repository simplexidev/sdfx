namespace LibUISharp.Drawing
{
    public static class Brushes
    {
        // This list is based on https://www.w3schools.com/colors/colors_hex.asp.
        // Please keep this in order with the above list, and for now, all entries
        // that have alternative spellings (i.e.: keep both Gray and Grey).

        //TODO: Replace "new Color({argb})" with actual color from Colors.
        public static readonly SolidBrush Transparent = new SolidBrush(new Color(0x00000000));
        public static readonly SolidBrush Black = new SolidBrush(new Color(0xFF000000));
        public static readonly SolidBrush Navy = new SolidBrush(new Color(0xFF000080));
        public static readonly SolidBrush DarkBlue = new SolidBrush(new Color(0xFF00008B));
        public static readonly SolidBrush MediumBlue = new SolidBrush(new Color(0xFF0000CD));
        public static readonly SolidBrush Blue = new SolidBrush(new Color(0xFF0000FF));
        public static readonly SolidBrush DarkGreen = new SolidBrush(new Color(0xFF006400));
        public static readonly SolidBrush Green = new SolidBrush(new Color(0xFF008000));
        public static readonly SolidBrush Teal = new SolidBrush(new Color(0xFF008080));
        public static readonly SolidBrush DarkCyan = new SolidBrush(new Color(0xFF008B8B));
        public static readonly SolidBrush DeepSkyBlue = new SolidBrush(new Color(0xFF00BFFF));
        public static readonly SolidBrush DarkTurquoise = new SolidBrush(new Color(0xFF00CED1));
        public static readonly SolidBrush MediumSpringGreen = new SolidBrush(new Color(0xFF00FA9A));
        public static readonly SolidBrush Lime = new SolidBrush(new Color(0xFF00FF00));
        public static readonly SolidBrush SpringGreen = new SolidBrush(new Color(0xFF00FF7F));
        public static readonly SolidBrush Aqua = new SolidBrush(new Color(0xFF00FFFF));
        public static readonly SolidBrush Cyan = Aqua;
        public static readonly SolidBrush MidnightBlue = new SolidBrush(new Color(0xFF191970));
        public static readonly SolidBrush DodgerBlue = new SolidBrush(new Color(0xFF1E90FF));
        public static readonly SolidBrush LightSeaGreen = new SolidBrush(new Color(0xFF20B2AA));
        public static readonly SolidBrush ForestGreen = new SolidBrush(new Color(0xFF228B22));
        public static readonly SolidBrush SeaGreen = new SolidBrush(new Color(0xFF2E8B57));
        public static readonly SolidBrush DarkSlateGray = new SolidBrush(new Color(0xFF2F4F4F));
        public static readonly SolidBrush DarkSlateGrey = DarkSlateGray;
        public static readonly SolidBrush LimeGreen = new SolidBrush(new Color(0xFF32CD32));
        public static readonly SolidBrush MediumSeaGreen = new SolidBrush(new Color(0xFF3CB371));
        public static readonly SolidBrush Turquoise = new SolidBrush(new Color(0xFF40E0D0));
        public static readonly SolidBrush RoyalBlue = new SolidBrush(new Color(0xFF4169E1));
        public static readonly SolidBrush SteelBlue = new SolidBrush(new Color(0xFF4682B4));
        public static readonly SolidBrush DarkSlateBlue = new SolidBrush(new Color(0xFF483D8B));
        public static readonly SolidBrush MediumTurquoise = new SolidBrush(new Color(0xFF48D1CC));
        public static readonly SolidBrush Indigo = new SolidBrush(new Color(0xFF4B0082));
        public static readonly SolidBrush DarkOliveGreen = new SolidBrush(new Color(0xFF556B2F));
        public static readonly SolidBrush CadetBlue = new SolidBrush(new Color(0xFF5F9EA0));
        public static readonly SolidBrush CornflowerBlue = new SolidBrush(new Color(0xFF6495ED));
        public static readonly SolidBrush RebeccaPurple = new SolidBrush(new Color(0xFF663399));
        public static readonly SolidBrush MediumAquaMarine = new SolidBrush(new Color(0xFF66CDAA));
        public static readonly SolidBrush DimGray = new SolidBrush(new Color(0xFF696969));
        public static readonly SolidBrush DimGrey = DimGray;
        public static readonly SolidBrush SlateBlue = new SolidBrush(new Color(0xFF6A5ACD));
        public static readonly SolidBrush OliveDrab = new SolidBrush(new Color(0xFF6B8E23));
        public static readonly SolidBrush SlateGray = new SolidBrush(new Color(0xFF708090));
        public static readonly SolidBrush SlateGrey = SlateGray;
        public static readonly SolidBrush LightSlateGray = new SolidBrush(new Color(0xFF778899));
        public static readonly SolidBrush LightSlateGrey = LightSlateGray;
        public static readonly SolidBrush MediumSlateBlue = new SolidBrush(new Color(0xFF7B68EE));
        public static readonly SolidBrush LawnGreen = new SolidBrush(new Color(0xFF7CFC00));
        public static readonly SolidBrush Chartreuse = new SolidBrush(new Color(0xFF7FFF00));
        public static readonly SolidBrush Aquamarine = new SolidBrush(new Color(0xFF7FFFD4));
        public static readonly SolidBrush Maroon = new SolidBrush(new Color(0xFF800000));
        public static readonly SolidBrush Purple = new SolidBrush(new Color(0xFF800080));
        public static readonly SolidBrush Olive = new SolidBrush(new Color(0xFF808000));
        public static readonly SolidBrush Gray = new SolidBrush(new Color(0xFF808080));
        public static readonly SolidBrush Grey = Gray;
        public static readonly SolidBrush SkyBlue = new SolidBrush(new Color(0xFF87CEEB));
        public static readonly SolidBrush LightSkyBlue = new SolidBrush(new Color(0xFF87CEFA));
        public static readonly SolidBrush BlueViolet = new SolidBrush(new Color(0xFF8A2BE2));
        public static readonly SolidBrush DarkRed = new SolidBrush(new Color(0xFF8B0000));
        public static readonly SolidBrush DarkMagenta = new SolidBrush(new Color(0xFF8B008B));
        public static readonly SolidBrush SaddleBrown = new SolidBrush(new Color(0xFF8B4513));
        public static readonly SolidBrush DarkSeaGreen = new SolidBrush(new Color(0xFF8FBC8F));
        public static readonly SolidBrush LightGreen = new SolidBrush(new Color(0xFF90EE90));
        public static readonly SolidBrush MediumPurple = new SolidBrush(new Color(0xFF9370DB));
        public static readonly SolidBrush DarkViolet = new SolidBrush(new Color(0xFF9400D3));
        public static readonly SolidBrush PaleGreen = new SolidBrush(new Color(0xFF98FB98));
        public static readonly SolidBrush DarkOrchid = new SolidBrush(new Color(0xFF9932CC));
        public static readonly SolidBrush YellowGreen = new SolidBrush(new Color(0xFF9ACD32));
        public static readonly SolidBrush Sienna = new SolidBrush(new Color(0xFFA0522D));
        public static readonly SolidBrush Brown = new SolidBrush(new Color(0xFFA52A2A));
        public static readonly SolidBrush DarkGray = new SolidBrush(new Color(0xFFA9A9A9));
        public static readonly SolidBrush DarkGrey = DarkGray;
        public static readonly SolidBrush LightBlue = new SolidBrush(new Color(0xFFADD8E6));
        public static readonly SolidBrush GreenYellow = new SolidBrush(new Color(0xFFADFF2F));
        public static readonly SolidBrush PaleTurquoise = new SolidBrush(new Color(0xFFAFEEEE));
        public static readonly SolidBrush LightSteelBlue = new SolidBrush(new Color(0xFFB0C4DE));
        public static readonly SolidBrush PowderBlue = new SolidBrush(new Color(0xFFB0E0E6));
        public static readonly SolidBrush FireBrick = new SolidBrush(new Color(0xFFB22222));
        public static readonly SolidBrush DarkGoldenRod = new SolidBrush(new Color(0xFFB8860B));
        public static readonly SolidBrush MediumOrchid = new SolidBrush(new Color(0xFFBA55D3));
        public static readonly SolidBrush RosyBrown = new SolidBrush(new Color(0xFFBC8F8F));
        public static readonly SolidBrush DarkKhaki = new SolidBrush(new Color(0xFFBDB76B));
        public static readonly SolidBrush Silver = new SolidBrush(new Color(0xFFC0C0C0));
        public static readonly SolidBrush MediumVioletRed = new SolidBrush(new Color(0xFFC71585));
        public static readonly SolidBrush IndianRed = new SolidBrush(new Color(0xFFCD5C5C));
        public static readonly SolidBrush Peru = new SolidBrush(new Color(0xFFCD853F));
        public static readonly SolidBrush Chocolate = new SolidBrush(new Color(0xFFD2691E));
        public static readonly SolidBrush Tan = new SolidBrush(new Color(0xFFD2B48C));
        public static readonly SolidBrush LightGray = new SolidBrush(new Color(0xFFD3D3D3));
        public static readonly SolidBrush LightGrey = LightGray;
        public static readonly SolidBrush Thistle = new SolidBrush(new Color(0xFFD8BFD8));
        public static readonly SolidBrush Orchid = new SolidBrush(new Color(0xFFDA70D6));
        public static readonly SolidBrush GoldenRod = new SolidBrush(new Color(0xFFDAA520));
        public static readonly SolidBrush PaleVioletRed = new SolidBrush(new Color(0xFFDB7093));
        public static readonly SolidBrush Crimson = new SolidBrush(new Color(0xFFDC143C));
        public static readonly SolidBrush Gainsboro = new SolidBrush(new Color(0xFFDCDCDC));
        public static readonly SolidBrush Plum = new SolidBrush(new Color(0xFFDDA0DD));
        public static readonly SolidBrush BurlyWood = new SolidBrush(new Color(0xFFDEB887));
        public static readonly SolidBrush LightCyan = new SolidBrush(new Color(0xFFE0FFFF));
        public static readonly SolidBrush Lavender = new SolidBrush(new Color(0xFFE6E6FA));
        public static readonly SolidBrush DarkSalmon = new SolidBrush(new Color(0xFFE9967A));
        public static readonly SolidBrush Violet = new SolidBrush(new Color(0xFFEE82EE));
        public static readonly SolidBrush PaleGoldenRod = new SolidBrush(new Color(0xFFEEE8AA));
        public static readonly SolidBrush LightCoral = new SolidBrush(new Color(0xFFF08080));
        public static readonly SolidBrush Khaki = new SolidBrush(new Color(0xFFF0E68C));
        public static readonly SolidBrush AliceBlue = new SolidBrush(new Color(0xFFF0F8FF));
        public static readonly SolidBrush HoneyDew = new SolidBrush(new Color(0xFFF0FFF0));
        public static readonly SolidBrush Azure = new SolidBrush(new Color(0xFFF0FFFF));
        public static readonly SolidBrush SandyBrown = new SolidBrush(new Color(0xFFF4A460));
        public static readonly SolidBrush Wheat = new SolidBrush(new Color(0xFFF5DEB3));
        public static readonly SolidBrush Beige = new SolidBrush(new Color(0xFFF5F5DC));
        public static readonly SolidBrush WhiteSmoke = new SolidBrush(new Color(0xFFF5F5F5));
        public static readonly SolidBrush MintCream = new SolidBrush(new Color(0xFFF5FFFA));
        public static readonly SolidBrush GhostWhite = new SolidBrush(new Color(0xFFF8F8FF));
        public static readonly SolidBrush Salmon = new SolidBrush(new Color(0xFFFA8072));
        public static readonly SolidBrush AntiqueWhite = new SolidBrush(new Color(0xFFFAEBD7));
        public static readonly SolidBrush Linen = new SolidBrush(new Color(0xFFFAF0E6));
        public static readonly SolidBrush LightGoldenRodYellow = new SolidBrush(new Color(0xFFFAFAD2));
        public static readonly SolidBrush OldLace = new SolidBrush(new Color(0xFFFDF5E6));
        public static readonly SolidBrush Red = new SolidBrush(new Color(0xFFFF0000));
        public static readonly SolidBrush Fuchsia = new SolidBrush(new Color(0xFFFF00FF));
        public static readonly SolidBrush Magenta = Fuchsia;
        public static readonly SolidBrush DeepPink = new SolidBrush(new Color(0xFFFF1493));
        public static readonly SolidBrush OrangeRed = new SolidBrush(new Color(0xFFFF4500));
        public static readonly SolidBrush Tomato = new SolidBrush(new Color(0xFFFF6347));
        public static readonly SolidBrush HotPink = new SolidBrush(new Color(0xFFFF69B4));
        public static readonly SolidBrush Coral = new SolidBrush(new Color(0xFFFF7F50));
        public static readonly SolidBrush DarkOrange = new SolidBrush(new Color(0xFFFF8C00));
        public static readonly SolidBrush LightSalmon = new SolidBrush(new Color(0xFFFFA07A));
        public static readonly SolidBrush Orange = new SolidBrush(new Color(0xFFFFA500));
        public static readonly SolidBrush LightPink = new SolidBrush(new Color(0xFFFFB6C1));
        public static readonly SolidBrush Pink = new SolidBrush(new Color(0xFFFFC0CB));
        public static readonly SolidBrush Gold = new SolidBrush(new Color(0xFFFFD700));
        public static readonly SolidBrush PeachPuff = new SolidBrush(new Color(0xFFFFDAB9));
        public static readonly SolidBrush NavajoWhite = new SolidBrush(new Color(0xFFFFDEAD));
        public static readonly SolidBrush Moccasin = new SolidBrush(new Color(0xFFFFE4B5));
        public static readonly SolidBrush Bisque = new SolidBrush(new Color(0xFFFFE4C4));
        public static readonly SolidBrush MistyRose = new SolidBrush(new Color(0xFFFFE4E1));
        public static readonly SolidBrush BlanchedAlmond = new SolidBrush(new Color(0xFFFFEBCD));
        public static readonly SolidBrush PapayaWhip = new SolidBrush(new Color(0xFFFFEFD5));
        public static readonly SolidBrush LavenderBlush = new SolidBrush(new Color(0xFFFFF0F5));
        public static readonly SolidBrush SeaShell = new SolidBrush(new Color(0xFFFFF5EE));
        public static readonly SolidBrush Cornsilk = new SolidBrush(new Color(0xFFFFF8DC));
        public static readonly SolidBrush LemonChiffon = new SolidBrush(new Color(0xFFFFFACD));
        public static readonly SolidBrush FloralWhite = new SolidBrush(new Color(0xFFFFFAF0));
        public static readonly SolidBrush Snow = new SolidBrush(new Color(0xFFFFFAFA));
        public static readonly SolidBrush Yellow = new SolidBrush(new Color(0xFFFFFF00));
        public static readonly SolidBrush LightYellow = new SolidBrush(new Color(0xFFFFFFE0));
        public static readonly SolidBrush Ivory = new SolidBrush(new Color(0xFFFFFFF0));
        public static readonly SolidBrush White = new SolidBrush(new Color(0xFFFFFFFF));
    }
}