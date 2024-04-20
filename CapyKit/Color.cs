using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapyKit
{
    /// <summary>
    /// Enum representing a set of named colors with their corresponding HEX values. These colors are
    /// inspired by the XKCD color palette (<see href="https://xkcd.com/color/rgb/" target="_blank">Link</see>).
    /// </summary>
    public enum Color
    {
        ///<summary> A color described as Cloudy Blue with a HEX value of <c>#ACC2D9</c>.
        CloudyBlue = 0xACC2D9,
        ///<summary> A color described as Dark Pastel Green with a HEX value of <c>#56AE57</c>.
        DarkPastelGreen = 0x56AE57,
        ///<summary> A color described as Dust with a HEX value of <c>#B2996E</c>.
        Dust = 0xB2996E,
        ///<summary> A color described as Electric Lime with a HEX value of <c>#A8FF04</c>.
        ElectricLime = 0xA8FF04,
        ///<summary> A color described as Fresh Green with a HEX value of <c>#69D84F</c>.
        FreshGreen = 0x69D84F,
        ///<summary> A color described as Light Eggplant with a HEX value of <c>#894585</c>.
        LightEggplant = 0x894585,
        ///<summary> A color described as Nasty Green with a HEX value of <c>#70B23F</c>.
        NastyGreen = 0x70B23F,
        ///<summary> A color described as Really Light Blue with a HEX value of <c>#D4FFFF</c>.
        ReallyLightBlue = 0xD4FFFF,
        ///<summary> A color described as Tea with a HEX value of <c>#65AB7C</c>.
        Tea = 0x65AB7C,
        ///<summary> A color described as Warm Purple with a HEX value of <c>#952E8F</c>.
        WarmPurple = 0x952E8F,
        ///<summary> A color described as Yellowish Tan with a HEX value of <c>#FCFC81</c>.
        YellowishTan = 0xFCFC81,
        ///<summary> A color described as Cement with a HEX value of <c>#A5A391</c>.
        Cement = 0xA5A391,
        ///<summary> A color described as Dark Grass Green with a HEX value of <c>#388004</c>.
        DarkGrassGreen = 0x388004,
        ///<summary> A color described as Dusty Teal with a HEX value of <c>#4C9085</c>.
        DustyTeal = 0x4C9085,
        ///<summary> A color described as Grey Teal with a HEX value of <c>#5E9B8A</c>.
        GreyTeal = 0x5E9B8A,
        ///<summary> A color described as Macaroni And Cheese with a HEX value of <c>#EFB435</c>.
        MacaroniAndCheese = 0xEFB435,
        ///<summary> A color described as Pinkish Tan with a HEX value of <c>#D99B82</c>.
        PinkishTan = 0xD99B82,
        ///<summary> A color described as Spruce with a HEX value of <c>#0A5F38</c>.
        Spruce = 0x0A5F38,
        ///<summary> A color described as Strong Blue with a HEX value of <c>#0C06F7</c>.
        StrongBlue = 0x0C06F7,
        ///<summary> A color described as Toxic Green with a HEX value of <c>#61DE2A</c>.
        ToxicGreen = 0x61DE2A,
        ///<summary> A color described as Windows Blue with a HEX value of <c>#3778BF</c>.
        WindowsBlue = 0x3778BF,
        ///<summary> A color described as Blue Blue with a HEX value of <c>#2242C7</c>.
        BlueBlue = 0x2242C7,
        ///<summary> A color described as Blue With A Hint Of Purple with a HEX value of <c>#533CC6</c>.
        BlueWithAHintOfPurple = 0x533CC6,
        ///<summary> A color described as Booger with a HEX value of <c>#9BB53C</c>.
        Booger = 0x9BB53C,
        ///<summary> A color described as Bright Sea Green with a HEX value of <c>#05FFA6</c>.
        BrightSeaGreen = 0x05FFA6,
        ///<summary> A color described as Dark Green Blue with a HEX value of <c>#1F6357</c>.
        DarkGreenBlue = 0x1F6357,
        ///<summary> A color described as Deep Turquoise with a HEX value of <c>#017374</c>.
        DeepTurquoise = 0x017374,
        ///<summary> A color described as Green Teal with a HEX value of <c>#0CB577</c>.
        GreenTeal = 0x0CB577,
        ///<summary> A color described as Strong Pink with a HEX value of <c>#FF0789</c>.
        StrongPink = 0xFF0789,
        ///<summary> A color described as Bland with a HEX value of <c>#AFA88B</c>.
        Bland = 0xAFA88B,
        ///<summary> A color described as Deep Aqua with a HEX value of <c>#08787F</c>.
        DeepAqua = 0x08787F,
        ///<summary> A color described as Lavender Pink with a HEX value of <c>#DD85D7</c>.
        LavenderPink = 0xDD85D7,
        ///<summary> A color described as Light Moss Green with a HEX value of <c>#A6C875</c>.
        LightMossGreen = 0xA6C875,
        ///<summary> A color described as Light Seafoam Green with a HEX value of <c>#A7FFB5</c>.
        LightSeafoamGreen = 0xA7FFB5,
        ///<summary> A color described as Olive Yellow with a HEX value of <c>#C2B709</c>.
        OliveYellow = 0xC2B709,
        ///<summary> A color described as Pig Pink with a HEX value of <c>#E78EA5</c>.
        PigPink = 0xE78EA5,
        ///<summary> A color described as Deep Lilac with a HEX value of <c>#966EBD</c>.
        DeepLilac = 0x966EBD,
        ///<summary> A color described as Desert with a HEX value of <c>#CCAD60</c>.
        Desert = 0xCCAD60,
        ///<summary> A color described as Dusty Lavender with a HEX value of <c>#AC86A8</c>.
        DustyLavender = 0xAC86A8,
        ///<summary> A color described as Purpley Grey with a HEX value of <c>#947E94</c>.
        PurpleyGrey = 0x947E94,
        ///<summary> A color described as Purply with a HEX value of <c>#983FB2</c>.
        Purply = 0x983FB2,
        ///<summary> A color described as Candy Pink with a HEX value of <c>#FF63E9</c>.
        CandyPink = 0xFF63E9,
        ///<summary> A color described as Light Pastel Green with a HEX value of <c>#B2FBA5</c>.
        LightPastelGreen = 0xB2FBA5,
        ///<summary> A color described as Boring Green with a HEX value of <c>#63B365</c>.
        BoringGreen = 0x63B365,
        ///<summary> A color described as Kiwi Green with a HEX value of <c>#8EE53F</c>.
        KiwiGreen = 0x8EE53F,
        ///<summary> A color described as Light Grey Green with a HEX value of <c>#B7E1A1</c>.
        LightGreyGreen = 0xB7E1A1,
        ///<summary> A color described as Orange Pink with a HEX value of <c>#FF6F52</c>.
        OrangePink = 0xFF6F52,
        ///<summary> A color described as Tea Green with a HEX value of <c>#BDF8A3</c>.
        TeaGreen = 0xBDF8A3,
        ///<summary> A color described as Very Light Brown with a HEX value of <c>#D3B683</c>.
        VeryLightBrown = 0xD3B683,
        ///<summary> A color described as Egg Shell with a HEX value of <c>#FFFCC4</c>.
        EggShell = 0xFFFCC4,
        ///<summary> A color described as Eggplant Purple with a HEX value of <c>#430541</c>.
        EggplantPurple = 0x430541,
        ///<summary> A color described as Powder Pink with a HEX value of <c>#FFB2D0</c>.
        PowderPink = 0xFFB2D0,
        ///<summary> A color described as Reddish Grey with a HEX value of <c>#997570</c>.
        ReddishGrey = 0x997570,
        ///<summary> A color described as Baby Shit Brown with a HEX value of <c>#AD900D</c>.
        BabyShitBrown = 0xAD900D,
        ///<summary> A color described as Liliac with a HEX value of <c>#C48EFD</c>.
        Liliac = 0xC48EFD,
        ///<summary> A color described as Stormy Blue with a HEX value of <c>#507B9C</c>.
        StormyBlue = 0x507B9C,
        ///<summary> A color described as Ugly Brown with a HEX value of <c>#7D7103</c>.
        UglyBrown = 0x7D7103,
        ///<summary> A color described as Custard with a HEX value of <c>#FFFD78</c>.
        Custard = 0xFFFD78,
        ///<summary> A color described as Darkish Pink with a HEX value of <c>#DA467D</c>.
        DarkishPink = 0xDA467D,
        ///<summary> A color described as Deep Brown with a HEX value of <c>#410200</c>.
        DeepBrown = 0x410200,
        ///<summary> A color described as Greenish Beige with a HEX value of <c>#C9D179</c>.
        GreenishBeige = 0xC9D179,
        ///<summary> A color described as Manilla with a HEX value of <c>#FFFA86</c>.
        Manilla = 0xFFFA86,
        ///<summary> A color described as Off Blue with a HEX value of <c>#5684AE</c>.
        OffBlue = 0x5684AE,
        ///<summary> A color described as Battleship Grey with a HEX value of <c>#6B7C85</c>.
        BattleshipGrey = 0x6B7C85,
        ///<summary> A color described as Browny Green with a HEX value of <c>#6F6C0A</c>.
        BrownyGreen = 0x6F6C0A,
        ///<summary> A color described as Bruise with a HEX value of <c>#7E4071</c>.
        Bruise = 0x7E4071,
        ///<summary> A color described as Kelley Green with a HEX value of <c>#009337</c>.
        KelleyGreen = 0x009337,
        ///<summary> A color described as Sickly Yellow with a HEX value of <c>#D0E429</c>.
        SicklyYellow = 0xD0E429,
        ///<summary> A color described as Sunny Yellow with a HEX value of <c>#FFF917</c>.
        SunnyYellow = 0xFFF917,
        ///<summary> A color described as Azul with a HEX value of <c>#1D5DEC</c>.
        Azul = 0x1D5DEC,
        ///<summary> A color described as Darkgreen with a HEX value of <c>#054907</c>.
        Darkgreen = 0x054907,
        ///<summary> A color described as Green/Yellow with a HEX value of <c>#B5CE08</c>.
        GreenYellow = 0xB5CE08,
        ///<summary> A color described as Lichen with a HEX value of <c>#8FB67B</c>.
        Lichen = 0x8FB67B,
        ///<summary> A color described as Light Light Green with a HEX value of <c>#C8FFB0</c>.
        LightLightGreen = 0xC8FFB0,
        ///<summary> A color described as Pale Gold with a HEX value of <c>#FDDE6C</c>.
        PaleGold = 0xFDDE6C,
        ///<summary> A color described as Sun Yellow with a HEX value of <c>#FFDF22</c>.
        SunYellow = 0xFFDF22,
        ///<summary> A color described as Tan Green with a HEX value of <c>#A9BE70</c>.
        TanGreen = 0xA9BE70,
        ///<summary> A color described as Burple with a HEX value of <c>#6832E3</c>.
        Burple = 0x6832E3,
        ///<summary> A color described as Butterscotch with a HEX value of <c>#FDB147</c>.
        Butterscotch = 0xFDB147,
        ///<summary> A color described as Toupe with a HEX value of <c>#C7AC7D</c>.
        Toupe = 0xC7AC7D,
        ///<summary> A color described as Dark Cream with a HEX value of <c>#FFF39A</c>.
        DarkCream = 0xFFF39A,
        ///<summary> A color described as Indian Red with a HEX value of <c>#850E04</c>.
        IndianRed = 0x850E04,
        ///<summary> A color described as Light Lavendar with a HEX value of <c>#EFC0FE</c>.
        LightLavendar = 0xEFC0FE,
        ///<summary> A color described as Poison Green with a HEX value of <c>#40FD14</c>.
        PoisonGreen = 0x40FD14,
        ///<summary> A color described as Baby Puke Green with a HEX value of <c>#B6C406</c>.
        BabyPukeGreen = 0xB6C406,
        ///<summary> A color described as Bright Yellow Green with a HEX value of <c>#9DFF00</c>.
        BrightYellowGreen = 0x9DFF00,
        ///<summary> A color described as Charcoal Grey with a HEX value of <c>#3C4142</c>.
        CharcoalGrey = 0x3C4142,
        ///<summary> A color described as Squash with a HEX value of <c>#F2AB15</c>.
        Squash = 0xF2AB15,
        ///<summary> A color described as Cinnamon with a HEX value of <c>#AC4F06</c>.
        Cinnamon = 0xAC4F06,
        ///<summary> A color described as Light Pea Green with a HEX value of <c>#C4FE82</c>.
        LightPeaGreen = 0xC4FE82,
        ///<summary> A color described as Radioactive Green with a HEX value of <c>#2CFA1F</c>.
        RadioactiveGreen = 0x2CFA1F,
        ///<summary> A color described as Raw Sienna with a HEX value of <c>#9A6200</c>.
        RawSienna = 0x9A6200,
        ///<summary> A color described as Baby Purple with a HEX value of <c>#CA9BF7</c>.
        BabyPurple = 0xCA9BF7,
        ///<summary> A color described as Cocoa with a HEX value of <c>#875F42</c>.
        Cocoa = 0x875F42,
        ///<summary> A color described as Light Royal Blue with a HEX value of <c>#3A2EFE</c>.
        LightRoyalBlue = 0x3A2EFE,
        ///<summary> A color described as Orangeish with a HEX value of <c>#FD8D49</c>.
        Orangeish = 0xFD8D49,
        ///<summary> A color described as Rust Brown with a HEX value of <c>#8B3103</c>.
        RustBrown = 0x8B3103,
        ///<summary> A color described as Sand Brown with a HEX value of <c>#CBA560</c>.
        SandBrown = 0xCBA560,
        ///<summary> A color described as Swamp with a HEX value of <c>#698339</c>.
        Swamp = 0x698339,
        ///<summary> A color described as Tealish Green with a HEX value of <c>#0CDC73</c>.
        TealishGreen = 0x0CDC73,
        ///<summary> A color described as Burnt Siena with a HEX value of <c>#B75203</c>.
        BurntSiena = 0xB75203,
        ///<summary> A color described as Camo with a HEX value of <c>#7F8F4E</c>.
        Camo = 0x7F8F4E,
        ///<summary> A color described as Dusk Blue with a HEX value of <c>#26538D</c>.
        DuskBlue = 0x26538D,
        ///<summary> A color described as Fern with a HEX value of <c>#63A950</c>.
        Fern = 0x63A950,
        ///<summary> A color described as Old Rose with a HEX value of <c>#C87F89</c>.
        OldRose = 0xC87F89,
        ///<summary> A color described as Pale Light Green with a HEX value of <c>#B1FC99</c>.
        PaleLightGreen = 0xB1FC99,
        ///<summary> A color described as Peachy Pink with a HEX value of <c>#FF9A8A</c>.
        PeachyPink = 0xFF9A8A,
        ///<summary> A color described as Rosy Pink with a HEX value of <c>#F6688E</c>.
        RosyPink = 0xF6688E,
        ///<summary> A color described as Light Bluish Green with a HEX value of <c>#76FDA8</c>.
        LightBluishGreen = 0x76FDA8,
        ///<summary> A color described as Light Bright Green with a HEX value of <c>#53FE5C</c>.
        LightBrightGreen = 0x53FE5C,
        ///<summary> A color described as Light Neon Green with a HEX value of <c>#4EFD54</c>.
        LightNeonGreen = 0x4EFD54,
        ///<summary> A color described as Light Seafoam with a HEX value of <c>#A0FEBF</c>.
        LightSeafoam = 0xA0FEBF,
        ///<summary> A color described as Tiffany Blue with a HEX value of <c>#7BF2DA</c>.
        TiffanyBlue = 0x7BF2DA,
        ///<summary> A color described as Washed Out Green with a HEX value of <c>#BCF5A6</c>.
        WashedOutGreen = 0xBCF5A6,
        ///<summary> A color described as Browny Orange with a HEX value of <c>#CA6B02</c>.
        BrownyOrange = 0xCA6B02,
        ///<summary> A color described as Nice Blue with a HEX value of <c>#107AB0</c>.
        NiceBlue = 0x107AB0,
        ///<summary> A color described as Sapphire with a HEX value of <c>#2138AB</c>.
        Sapphire = 0x2138AB,
        ///<summary> A color described as Greyish Teal with a HEX value of <c>#719F91</c>.
        GreyishTeal = 0x719F91,
        ///<summary> A color described as Orangey Yellow with a HEX value of <c>#FDB915</c>.
        OrangeyYellow = 0xFDB915,
        ///<summary> A color described as Parchment with a HEX value of <c>#FEFCAF</c>.
        Parchment = 0xFEFCAF,
        ///<summary> A color described as Straw with a HEX value of <c>#FCF679</c>.
        Straw = 0xFCF679,
        ///<summary> A color described as Very Dark Brown with a HEX value of <c>#1D0200</c>.
        VeryDarkBrown = 0x1D0200,
        ///<summary> A color described as Terracota with a HEX value of <c>#CB6843</c>.
        Terracota = 0xCB6843,
        ///<summary> A color described as Ugly Blue with a HEX value of <c>#31668A</c>.
        UglyBlue = 0x31668A,
        ///<summary> A color described as Clear Blue with a HEX value of <c>#247AFD</c>.
        ClearBlue = 0x247AFD,
        ///<summary> A color described as Creme with a HEX value of <c>#FFFFB6</c>.
        Creme = 0xFFFFB6,
        ///<summary> A color described as Foam Green with a HEX value of <c>#90FDA9</c>.
        FoamGreen = 0x90FDA9,
        ///<summary> A color described as Grey/Green with a HEX value of <c>#86A17D</c>.
        GreyGreen = 0x86A17D,
        ///<summary> A color described as Light Gold with a HEX value of <c>#FDDC5C</c>.
        LightGold = 0xFDDC5C,
        ///<summary> A color described as Seafoam Blue with a HEX value of <c>#78D1B6</c>.
        SeafoamBlue = 0x78D1B6,
        ///<summary> A color described as Topaz with a HEX value of <c>#13BBAF</c>.
        Topaz = 0x13BBAF,
        ///<summary> A color described as Violet Pink with a HEX value of <c>#FB5FFC</c>.
        VioletPink = 0xFB5FFC,
        ///<summary> A color described as Wintergreen with a HEX value of <c>#20F986</c>.
        Wintergreen = 0x20F986,
        ///<summary> A color described as Yellow Tan with a HEX value of <c>#FFE36E</c>.
        YellowTan = 0xFFE36E,
        ///<summary> A color described as Dark Fuchsia with a HEX value of <c>#9D0759</c>.
        DarkFuchsia = 0x9D0759,
        ///<summary> A color described as Indigo Blue with a HEX value of <c>#3A18B1</c>.
        IndigoBlue = 0x3A18B1,
        ///<summary> A color described as Light Yellowish Green with a HEX value of <c>#C2FF89</c>.
        LightYellowishGreen = 0xC2FF89,
        ///<summary> A color described as Pale Magenta with a HEX value of <c>#D767AD</c>.
        PaleMagenta = 0xD767AD,
        ///<summary> A color described as Rich Purple with a HEX value of <c>#720058</c>.
        RichPurple = 0x720058,
        ///<summary> A color described as Sunflower Yellow with a HEX value of <c>#FFDA03</c>.
        SunflowerYellow = 0xFFDA03,
        ///<summary> A color described as Green/Blue with a HEX value of <c>#01C08D</c>.
        GreenBlue = 0x01C08D,
        ///<summary> A color described as Leather with a HEX value of <c>#AC7434</c>.
        Leather = 0xAC7434,
        ///<summary> A color described as Racing Green with a HEX value of <c>#014600</c>.
        RacingGreen = 0x014600,
        ///<summary> A color described as Vivid Purple with a HEX value of <c>#9900FA</c>.
        VividPurple = 0x9900FA,
        ///<summary> A color described as Dark Royal Blue with a HEX value of <c>#02066F</c>.
        DarkRoyalBlue = 0x02066F,
        ///<summary> A color described as Hazel with a HEX value of <c>#8E7618</c>.
        Hazel = 0x8E7618,
        ///<summary> A color described as Muted Pink with a HEX value of <c>#D1768F</c>.
        MutedPink = 0xD1768F,
        ///<summary> A color described as Booger Green with a HEX value of <c>#96B403</c>.
        BoogerGreen = 0x96B403,
        ///<summary> A color described as Canary with a HEX value of <c>#FDFF63</c>.
        Canary = 0xFDFF63,
        ///<summary> A color described as Cool Grey with a HEX value of <c>#95A3A6</c>.
        CoolGrey = 0x95A3A6,
        ///<summary> A color described as Dark Taupe with a HEX value of <c>#7F684E</c>.
        DarkTaupe = 0x7F684E,
        ///<summary> A color described as Darkish Purple with a HEX value of <c>#751973</c>.
        DarkishPurple = 0x751973,
        ///<summary> A color described as True Green with a HEX value of <c>#089404</c>.
        TrueGreen = 0x089404,
        ///<summary> A color described as Coral Pink with a HEX value of <c>#FF6163</c>.
        CoralPink = 0xFF6163,
        ///<summary> A color described as Dark Sage with a HEX value of <c>#598556</c>.
        DarkSage = 0x598556,
        ///<summary> A color described as Dark Slate Blue with a HEX value of <c>#214761</c>.
        DarkSlateBlue = 0x214761,
        ///<summary> A color described as Flat Blue with a HEX value of <c>#3C73A8</c>.
        FlatBlue = 0x3C73A8,
        ///<summary> A color described as Mushroom with a HEX value of <c>#BA9E88</c>.
        Mushroom = 0xBA9E88,
        ///<summary> A color described as Rich Blue with a HEX value of <c>#021BF9</c>.
        RichBlue = 0x021BF9,
        ///<summary> A color described as Dirty Purple with a HEX value of <c>#734A65</c>.
        DirtyPurple = 0x734A65,
        ///<summary> A color described as Greenblue with a HEX value of <c>#23C48B</c>.
        Greenblue = 0x23C48B,
        ///<summary> A color described as Icky Green with a HEX value of <c>#8FAE22</c>.
        IckyGreen = 0x8FAE22,
        ///<summary> A color described as Light Khaki with a HEX value of <c>#E6F2A2</c>.
        LightKhaki = 0xE6F2A2,
        ///<summary> A color described as Warm Blue with a HEX value of <c>#4B57DB</c>.
        WarmBlue = 0x4B57DB,
        ///<summary> A color described as Dark Hot Pink with a HEX value of <c>#D90166</c>.
        DarkHotPink = 0xD90166,
        ///<summary> A color described as Deep Sea Blue with a HEX value of <c>#015482</c>.
        DeepSeaBlue = 0x015482,
        ///<summary> A color described as Carmine with a HEX value of <c>#9D0216</c>.
        Carmine = 0x9D0216,
        ///<summary> A color described as Dark Yellow Green with a HEX value of <c>#728F02</c>.
        DarkYellowGreen = 0x728F02,
        ///<summary> A color described as Pale Peach with a HEX value of <c>#FFE5AD</c>.
        PalePeach = 0xFFE5AD,
        ///<summary> A color described as Plum Purple with a HEX value of <c>#4E0550</c>.
        PlumPurple = 0x4E0550,
        ///<summary> A color described as Golden Rod with a HEX value of <c>#F9BC08</c>.
        GoldenRod = 0xF9BC08,
        ///<summary> A color described as Neon Red with a HEX value of <c>#FF073A</c>.
        NeonRed = 0xFF073A,
        ///<summary> A color described as Old Pink with a HEX value of <c>#C77986</c>.
        OldPink = 0xC77986,
        ///<summary> A color described as Very Pale Blue with a HEX value of <c>#D6FFFE</c>.
        VeryPaleBlue = 0xD6FFFE,
        ///<summary> A color described as Blood Orange with a HEX value of <c>#FE4B03</c>.
        BloodOrange = 0xFE4B03,
        ///<summary> A color described as Grapefruit with a HEX value of <c>#FD5956</c>.
        Grapefruit = 0xFD5956,
        ///<summary> A color described as Sand Yellow with a HEX value of <c>#FCE166</c>.
        SandYellow = 0xFCE166,
        ///<summary> A color described as Clay Brown with a HEX value of <c>#B2713D</c>.
        ClayBrown = 0xB2713D,
        ///<summary> A color described as Dark Blue Grey with a HEX value of <c>#1F3B4D</c>.
        DarkBlueGrey = 0x1F3B4D,
        ///<summary> A color described as Flat Green with a HEX value of <c>#699D4C</c>.
        FlatGreen = 0x699D4C,
        ///<summary> A color described as Light Green Blue with a HEX value of <c>#56FCA2</c>.
        LightGreenBlue = 0x56FCA2,
        ///<summary> A color described as Warm Pink with a HEX value of <c>#FB5581</c>.
        WarmPink = 0xFB5581,
        ///<summary> A color described as Dodger Blue with a HEX value of <c>#3E82FC</c>.
        DodgerBlue = 0x3E82FC,
        ///<summary> A color described as Gross Green with a HEX value of <c>#A0BF16</c>.
        GrossGreen = 0xA0BF16,
        ///<summary> A color described as Ice with a HEX value of <c>#D6FFFA</c>.
        Ice = 0xD6FFFA,
        ///<summary> A color described as Metallic Blue with a HEX value of <c>#4F738E</c>.
        MetallicBlue = 0x4F738E,
        ///<summary> A color described as Pale Salmon with a HEX value of <c>#FFB19A</c>.
        PaleSalmon = 0xFFB19A,
        ///<summary> A color described as Sap Green with a HEX value of <c>#5C8B15</c>.
        SapGreen = 0x5C8B15,
        ///<summary> A color described as Algae with a HEX value of <c>#54AC68</c>.
        Algae = 0x54AC68,
        ///<summary> A color described as Bluey Grey with a HEX value of <c>#89A0B0</c>.
        BlueyGrey = 0x89A0B0,
        ///<summary> A color described as Greeny Grey with a HEX value of <c>#7EA07A</c>.
        GreenyGrey = 0x7EA07A,
        ///<summary> A color described as Highlighter Green with a HEX value of <c>#1BFC06</c>.
        HighlighterGreen = 0x1BFC06,
        ///<summary> A color described as Light Light Blue with a HEX value of <c>#CAFFFB</c>.
        LightLightBlue = 0xCAFFFB,
        ///<summary> A color described as Light Mint with a HEX value of <c>#B6FFBB</c>.
        LightMint = 0xB6FFBB,
        ///<summary> A color described as Raw Umber with a HEX value of <c>#A75E09</c>.
        RawUmber = 0xA75E09,
        ///<summary> A color described as Vivid Blue with a HEX value of <c>#152EFF</c>.
        VividBlue = 0x152EFF,
        ///<summary> A color described as Deep Lavender with a HEX value of <c>#8D5EB7</c>.
        DeepLavender = 0x8D5EB7,
        ///<summary> A color described as Dull Teal with a HEX value of <c>#5F9E8F</c>.
        DullTeal = 0x5F9E8F,
        ///<summary> A color described as Light Greenish Blue with a HEX value of <c>#63F7B4</c>.
        LightGreenishBlue = 0x63F7B4,
        ///<summary> A color described as Mud Green with a HEX value of <c>#606602</c>.
        MudGreen = 0x606602,
        ///<summary> A color described as Pinky with a HEX value of <c>#FC86AA</c>.
        Pinky = 0xFC86AA,
        ///<summary> A color described as Red Wine with a HEX value of <c>#8C0034</c>.
        RedWine = 0x8C0034,
        ///<summary> A color described as Shit Green with a HEX value of <c>#758000</c>.
        ShitGreen = 0x758000,
        ///<summary> A color described as Tan Brown with a HEX value of <c>#AB7E4C</c>.
        TanBrown = 0xAB7E4C,
        ///<summary> A color described as Darkblue with a HEX value of <c>#030764</c>.
        Darkblue = 0x030764,
        ///<summary> A color described as Rosa with a HEX value of <c>#FE86A4</c>.
        Rosa = 0xFE86A4,
        ///<summary> A color described as Lipstick with a HEX value of <c>#D5174E</c>.
        Lipstick = 0xD5174E,
        ///<summary> A color described as Pale Mauve with a HEX value of <c>#FED0FC</c>.
        PaleMauve = 0xFED0FC,
        ///<summary> A color described as Claret with a HEX value of <c>#680018</c>.
        Claret = 0x680018,
        ///<summary> A color described as Dandelion with a HEX value of <c>#FEDF08</c>.
        Dandelion = 0xFEDF08,
        ///<summary> A color described as Orangered with a HEX value of <c>#FE420F</c>.
        Orangered = 0xFE420F,
        ///<summary> A color described as Poop Green with a HEX value of <c>#6F7C00</c>.
        PoopGreen = 0x6F7C00,
        ///<summary> A color described as Ruby with a HEX value of <c>#CA0147</c>.
        Ruby = 0xCA0147,
        ///<summary> A color described as Dark with a HEX value of <c>#1B2431</c>.
        Dark = 0x1B2431,
        ///<summary> A color described as Greenish Turquoise with a HEX value of <c>#00FBB0</c>.
        GreenishTurquoise = 0x00FBB0,
        ///<summary> A color described as Pastel Red with a HEX value of <c>#DB5856</c>.
        PastelRed = 0xDB5856,
        ///<summary> A color described as Piss Yellow with a HEX value of <c>#DDD618</c>.
        PissYellow = 0xDDD618,
        ///<summary> A color described as Bright Cyan with a HEX value of <c>#41FDFE</c>.
        BrightCyan = 0x41FDFE,
        ///<summary> A color described as Dark Coral with a HEX value of <c>#CF524E</c>.
        DarkCoral = 0xCF524E,
        ///<summary> A color described as Algae Green with a HEX value of <c>#21C36F</c>.
        AlgaeGreen = 0x21C36F,
        ///<summary> A color described as Darkish Red with a HEX value of <c>#A90308</c>.
        DarkishRed = 0xA90308,
        ///<summary> A color described as Reddy Brown with a HEX value of <c>#6E1005</c>.
        ReddyBrown = 0x6E1005,
        ///<summary> A color described as Blush Pink with a HEX value of <c>#FE828C</c>.
        BlushPink = 0xFE828C,
        ///<summary> A color described as Camouflage Green with a HEX value of <c>#4B6113</c>.
        CamouflageGreen = 0x4B6113,
        ///<summary> A color described as Lawn Green with a HEX value of <c>#4DA409</c>.
        LawnGreen = 0x4DA409,
        ///<summary> A color described as Putty with a HEX value of <c>#BEAE8A</c>.
        Putty = 0xBEAE8A,
        ///<summary> A color described as Vibrant Blue with a HEX value of <c>#0339F8</c>.
        VibrantBlue = 0x0339F8,
        ///<summary> A color described as Dark Sand with a HEX value of <c>#A88F59</c>.
        DarkSand = 0xA88F59,
        ///<summary> A color described as Purple/Blue with a HEX value of <c>#5D21D0</c>.
        PurpleBlue = 0x5D21D0,
        ///<summary> A color described as Saffron with a HEX value of <c>#FEB209</c>.
        Saffron = 0xFEB209,
        ///<summary> A color described as Twilight with a HEX value of <c>#4E518B</c>.
        Twilight = 0x4E518B,
        ///<summary> A color described as Warm Brown with a HEX value of <c>#964E02</c>.
        WarmBrown = 0x964E02,
        ///<summary> A color described as Bluegrey with a HEX value of <c>#85A3B2</c>.
        Bluegrey = 0x85A3B2,
        ///<summary> A color described as Bubble Gum Pink with a HEX value of <c>#FF69AF</c>.
        BubbleGumPink = 0xFF69AF,
        ///<summary> A color described as Duck Egg Blue with a HEX value of <c>#C3FBF4</c>.
        DuckEggBlue = 0xC3FBF4,
        ///<summary> A color described as Greenish Cyan with a HEX value of <c>#2AFEB7</c>.
        GreenishCyan = 0x2AFEB7,
        ///<summary> A color described as Petrol with a HEX value of <c>#005F6A</c>.
        Petrol = 0x005F6A,
        ///<summary> A color described as Royal with a HEX value of <c>#0C1793</c>.
        Royal = 0x0C1793,
        ///<summary> A color described as Butter with a HEX value of <c>#FFFF81</c>.
        Butter = 0xFFFF81,
        ///<summary> A color described as Dusty Orange with a HEX value of <c>#F0833A</c>.
        DustyOrange = 0xF0833A,
        ///<summary> A color described as Off Yellow with a HEX value of <c>#F1F33F</c>.
        OffYellow = 0xF1F33F,
        ///<summary> A color described as Pale Olive Green with a HEX value of <c>#B1D27B</c>.
        PaleOliveGreen = 0xB1D27B,
        ///<summary> A color described as Orangish with a HEX value of <c>#FC824A</c>.
        Orangish = 0xFC824A,
        ///<summary> A color described as Leaf with a HEX value of <c>#71AA34</c>.
        Leaf = 0x71AA34,
        ///<summary> A color described as Light Blue Grey with a HEX value of <c>#B7C9E2</c>.
        LightBlueGrey = 0xB7C9E2,
        ///<summary> A color described as Dried Blood with a HEX value of <c>#4B0101</c>.
        DriedBlood = 0x4B0101,
        ///<summary> A color described as Lightish Purple with a HEX value of <c>#A552E6</c>.
        LightishPurple = 0xA552E6,
        ///<summary> A color described as Rusty Red with a HEX value of <c>#AF2F0D</c>.
        RustyRed = 0xAF2F0D,
        ///<summary> A color described as Lavender Blue with a HEX value of <c>#8B88F8</c>.
        LavenderBlue = 0x8B88F8,
        ///<summary> A color described as Light Grass Green with a HEX value of <c>#9AF764</c>.
        LightGrassGreen = 0x9AF764,
        ///<summary> A color described as Light Mint Green with a HEX value of <c>#A6FBB2</c>.
        LightMintGreen = 0xA6FBB2,
        ///<summary> A color described as Sunflower with a HEX value of <c>#FFC512</c>.
        Sunflower = 0xFFC512,
        ///<summary> A color described as Velvet with a HEX value of <c>#750851</c>.
        Velvet = 0x750851,
        ///<summary> A color described as Brick Orange with a HEX value of <c>#C14A09</c>.
        BrickOrange = 0xC14A09,
        ///<summary> A color described as Lightish Red with a HEX value of <c>#FE2F4A</c>.
        LightishRed = 0xFE2F4A,
        ///<summary> A color described as Pure Blue with a HEX value of <c>#0203E2</c>.
        PureBlue = 0x0203E2,
        ///<summary> A color described as Twilight Blue with a HEX value of <c>#0A437A</c>.
        TwilightBlue = 0x0A437A,
        ///<summary> A color described as Violet Red with a HEX value of <c>#A50055</c>.
        VioletRed = 0xA50055,
        ///<summary> A color described as Yellowy Brown with a HEX value of <c>#AE8B0C</c>.
        YellowyBrown = 0xAE8B0C,
        ///<summary> A color described as Carnation with a HEX value of <c>#FD798F</c>.
        Carnation = 0xFD798F,
        ///<summary> A color described as Muddy Yellow with a HEX value of <c>#BFAC05</c>.
        MuddyYellow = 0xBFAC05,
        ///<summary> A color described as Dark Seafoam Green with a HEX value of <c>#3EAF76</c>.
        DarkSeafoamGreen = 0x3EAF76,
        ///<summary> A color described as Deep Rose with a HEX value of <c>#C74767</c>.
        DeepRose = 0xC74767,
        ///<summary> A color described as Dusty Red with a HEX value of <c>#B9484E</c>.
        DustyRed = 0xB9484E,
        ///<summary> A color described as Grey/Blue with a HEX value of <c>#647D8E</c>.
        GreyBlue = 0x647D8E,
        ///<summary> A color described as Lemon Lime with a HEX value of <c>#BFFE28</c>.
        LemonLime = 0xBFFE28,
        ///<summary> A color described as Purple/Pink with a HEX value of <c>#D725DE</c>.
        PurplePink = 0xD725DE,
        ///<summary> A color described as Brown Yellow with a HEX value of <c>#B29705</c>.
        BrownYellow = 0xB29705,
        ///<summary> A color described as Purple Brown with a HEX value of <c>#673A3F</c>.
        PurpleBrown = 0x673A3F,
        ///<summary> A color described as Wisteria with a HEX value of <c>#A87DC2</c>.
        Wisteria = 0xA87DC2,
        ///<summary> A color described as Banana Yellow with a HEX value of <c>#FAFE4B</c>.
        BananaYellow = 0xFAFE4B,
        ///<summary> A color described as Lipstick Red with a HEX value of <c>#C0022F</c>.
        LipstickRed = 0xC0022F,
        ///<summary> A color described as Water Blue with a HEX value of <c>#0E87CC</c>.
        WaterBlue = 0x0E87CC,
        ///<summary> A color described as Brown Grey with a HEX value of <c>#8D8468</c>.
        BrownGrey = 0x8D8468,
        ///<summary> A color described as Vibrant Purple with a HEX value of <c>#AD03DE</c>.
        VibrantPurple = 0xAD03DE,
        ///<summary> A color described as Baby Green with a HEX value of <c>#8CFF9E</c>.
        BabyGreen = 0x8CFF9E,
        ///<summary> A color described as Barf Green with a HEX value of <c>#94AC02</c>.
        BarfGreen = 0x94AC02,
        ///<summary> A color described as Eggshell Blue with a HEX value of <c>#C4FFF7</c>.
        EggshellBlue = 0xC4FFF7,
        ///<summary> A color described as Sandy Yellow with a HEX value of <c>#FDEE73</c>.
        SandyYellow = 0xFDEE73,
        ///<summary> A color described as Cool Green with a HEX value of <c>#33B864</c>.
        CoolGreen = 0x33B864,
        ///<summary> A color described as Pale with a HEX value of <c>#FFF9D0</c>.
        Pale = 0xFFF9D0,
        ///<summary> A color described as Blue/Grey with a HEX value of <c>#758DA3</c>.
        BlueGrey = 0x758DA3,
        ///<summary> A color described as Hot Magenta with a HEX value of <c>#F504C9</c>.
        HotMagenta = 0xF504C9,
        ///<summary> A color described as Greyblue with a HEX value of <c>#77A1B5</c>.
        Greyblue = 0x77A1B5,
        ///<summary> A color described as Purpley with a HEX value of <c>#8756E4</c>.
        Purpley = 0x8756E4,
        ///<summary> A color described as Baby Shit Green with a HEX value of <c>#889717</c>.
        BabyShitGreen = 0x889717,
        ///<summary> A color described as Brownish Pink with a HEX value of <c>#C27E79</c>.
        BrownishPink = 0xC27E79,
        ///<summary> A color described as Dark Aquamarine with a HEX value of <c>#017371</c>.
        DarkAquamarine = 0x017371,
        ///<summary> A color described as Diarrhea with a HEX value of <c>#9F8303</c>.
        Diarrhea = 0x9F8303,
        ///<summary> A color described as Light Mustard with a HEX value of <c>#F7D560</c>.
        LightMustard = 0xF7D560,
        ///<summary> A color described as Pale Sky Blue with a HEX value of <c>#BDF6FE</c>.
        PaleSkyBlue = 0xBDF6FE,
        ///<summary> A color described as Turtle Green with a HEX value of <c>#75B84F</c>.
        TurtleGreen = 0x75B84F,
        ///<summary> A color described as Bright Olive with a HEX value of <c>#9CBB04</c>.
        BrightOlive = 0x9CBB04,
        ///<summary> A color described as Dark Grey Blue with a HEX value of <c>#29465B</c>.
        DarkGreyBlue = 0x29465B,
        ///<summary> A color described as Greeny Brown with a HEX value of <c>#696006</c>.
        GreenyBrown = 0x696006,
        ///<summary> A color described as Lemon Green with a HEX value of <c>#ADF802</c>.
        LemonGreen = 0xADF802,
        ///<summary> A color described as Light Periwinkle with a HEX value of <c>#C1C6FC</c>.
        LightPeriwinkle = 0xC1C6FC,
        ///<summary> A color described as Seaweed Green with a HEX value of <c>#35AD6B</c>.
        SeaweedGreen = 0x35AD6B,
        ///<summary> A color described as Sunshine Yellow with a HEX value of <c>#FFFD37</c>.
        SunshineYellow = 0xFFFD37,
        ///<summary> A color described as Ugly Purple with a HEX value of <c>#A442A0</c>.
        UglyPurple = 0xA442A0,
        ///<summary> A color described as Medium Pink with a HEX value of <c>#F36196</c>.
        MediumPink = 0xF36196,
        ///<summary> A color described as Puke Brown with a HEX value of <c>#947706</c>.
        PukeBrown = 0x947706,
        ///<summary> A color described as Very Light Pink with a HEX value of <c>#FFF4F2</c>.
        VeryLightPink = 0xFFF4F2,
        ///<summary> A color described as Viridian with a HEX value of <c>#1E9167</c>.
        Viridian = 0x1E9167,
        ///<summary> A color described as Bile with a HEX value of <c>#B5C306</c>.
        Bile = 0xB5C306,
        ///<summary> A color described as Faded Yellow with a HEX value of <c>#FEFF7F</c>.
        FadedYellow = 0xFEFF7F,
        ///<summary> A color described as Very Pale Green with a HEX value of <c>#CFFDBC</c>.
        VeryPaleGreen = 0xCFFDBC,
        ///<summary> A color described as Vibrant Green with a HEX value of <c>#0ADD08</c>.
        VibrantGreen = 0x0ADD08,
        ///<summary> A color described as Bright Lime with a HEX value of <c>#87FD05</c>.
        BrightLime = 0x87FD05,
        ///<summary> A color described as Spearmint with a HEX value of <c>#1EF876</c>.
        Spearmint = 0x1EF876,
        ///<summary> A color described as Light Aquamarine with a HEX value of <c>#7BFDC7</c>.
        LightAquamarine = 0x7BFDC7,
        ///<summary> A color described as Light Sage with a HEX value of <c>#BCECAC</c>.
        LightSage = 0xBCECAC,
        ///<summary> A color described as Yellowgreen with a HEX value of <c>#BBF90F</c>.
        Yellowgreen = 0xBBF90F,
        ///<summary> A color described as Baby Poo with a HEX value of <c>#AB9004</c>.
        BabyPoo = 0xAB9004,
        ///<summary> A color described as Dark Seafoam with a HEX value of <c>#1FB57A</c>.
        DarkSeafoam = 0x1FB57A,
        ///<summary> A color described as Deep Teal with a HEX value of <c>#00555A</c>.
        DeepTeal = 0x00555A,
        ///<summary> A color described as Heather with a HEX value of <c>#A484AC</c>.
        Heather = 0xA484AC,
        ///<summary> A color described as Rust Orange with a HEX value of <c>#C45508</c>.
        RustOrange = 0xC45508,
        ///<summary> A color described as Dirty Blue with a HEX value of <c>#3F829D</c>.
        DirtyBlue = 0x3F829D,
        ///<summary> A color described as Fern Green with a HEX value of <c>#548D44</c>.
        FernGreen = 0x548D44,
        ///<summary> A color described as Bright Lilac with a HEX value of <c>#C95EFB</c>.
        BrightLilac = 0xC95EFB,
        ///<summary> A color described as Weird Green with a HEX value of <c>#3AE57F</c>.
        WeirdGreen = 0x3AE57F,
        ///<summary> A color described as Peacock Blue with a HEX value of <c>#016795</c>.
        PeacockBlue = 0x016795,
        ///<summary> A color described as Avocado Green with a HEX value of <c>#87A922</c>.
        AvocadoGreen = 0x87A922,
        ///<summary> A color described as Faded Orange with a HEX value of <c>#F0944D</c>.
        FadedOrange = 0xF0944D,
        ///<summary> A color described as Grape Purple with a HEX value of <c>#5D1451</c>.
        GrapePurple = 0x5D1451,
        ///<summary> A color described as Hot Green with a HEX value of <c>#25FF29</c>.
        HotGreen = 0x25FF29,
        ///<summary> A color described as Lime Yellow with a HEX value of <c>#D0FE1D</c>.
        LimeYellow = 0xD0FE1D,
        ///<summary> A color described as Mango with a HEX value of <c>#FFA62B</c>.
        Mango = 0xFFA62B,
        ///<summary> A color described as Shamrock with a HEX value of <c>#01B44C</c>.
        Shamrock = 0x01B44C,
        ///<summary> A color described as Bubblegum with a HEX value of <c>#FF6CB5</c>.
        Bubblegum = 0xFF6CB5,
        ///<summary> A color described as Purplish Brown with a HEX value of <c>#6B4247</c>.
        PurplishBrown = 0x6B4247,
        ///<summary> A color described as Vomit Yellow with a HEX value of <c>#C7C10C</c>.
        VomitYellow = 0xC7C10C,
        ///<summary> A color described as Pale Cyan with a HEX value of <c>#B7FFFA</c>.
        PaleCyan = 0xB7FFFA,
        ///<summary> A color described as Key Lime with a HEX value of <c>#AEFF6E</c>.
        KeyLime = 0xAEFF6E,
        ///<summary> A color described as Tomato Red with a HEX value of <c>#EC2D01</c>.
        TomatoRed = 0xEC2D01,
        ///<summary> A color described as Lightgreen with a HEX value of <c>#76FF7B</c>.
        Lightgreen = 0x76FF7B,
        ///<summary> A color described as Merlot with a HEX value of <c>#730039</c>.
        Merlot = 0x730039,
        ///<summary> A color described as Night Blue with a HEX value of <c>#040348</c>.
        NightBlue = 0x040348,
        ///<summary> A color described as Purpleish Pink with a HEX value of <c>#DF4EC8</c>.
        PurpleishPink = 0xDF4EC8,
        ///<summary> A color described as Apple with a HEX value of <c>#6ECB3C</c>.
        Apple = 0x6ECB3C,
        ///<summary> A color described as Baby Poop Green with a HEX value of <c>#8F9805</c>.
        BabyPoopGreen = 0x8F9805,
        ///<summary> A color described as Green Apple with a HEX value of <c>#5EDC1F</c>.
        GreenApple = 0x5EDC1F,
        ///<summary> A color described as Heliotrope with a HEX value of <c>#D94FF5</c>.
        Heliotrope = 0xD94FF5,
        ///<summary> A color described as Yellow/Green with a HEX value of <c>#C8FD3D</c>.
        YellowGreen = 0xC8FD3D,
        ///<summary> A color described as Almost Black with a HEX value of <c>#070D0D</c>.
        AlmostBlack = 0x070D0D,
        ///<summary> A color described as Cool Blue with a HEX value of <c>#4984B8</c>.
        CoolBlue = 0x4984B8,
        ///<summary> A color described as Leafy Green with a HEX value of <c>#51B73B</c>.
        LeafyGreen = 0x51B73B,
        ///<summary> A color described as Mustard Brown with a HEX value of <c>#AC7E04</c>.
        MustardBrown = 0xAC7E04,
        ///<summary> A color described as Dusk with a HEX value of <c>#4E5481</c>.
        Dusk = 0x4E5481,
        ///<summary> A color described as Dull Brown with a HEX value of <c>#876E4B</c>.
        DullBrown = 0x876E4B,
        ///<summary> A color described as Frog Green with a HEX value of <c>#58BC08</c>.
        FrogGreen = 0x58BC08,
        ///<summary> A color described as Vivid Green with a HEX value of <c>#2FEF10</c>.
        VividGreen = 0x2FEF10,
        ///<summary> A color described as Bright Light Green with a HEX value of <c>#2DFE54</c>.
        BrightLightGreen = 0x2DFE54,
        ///<summary> A color described as Fluro Green with a HEX value of <c>#0AFF02</c>.
        FluroGreen = 0x0AFF02,
        ///<summary> A color described as Kiwi with a HEX value of <c>#9CEF43</c>.
        Kiwi = 0x9CEF43,
        ///<summary> A color described as Seaweed with a HEX value of <c>#18D17B</c>.
        Seaweed = 0x18D17B,
        ///<summary> A color described as Navy Green with a HEX value of <c>#35530A</c>.
        NavyGreen = 0x35530A,
        ///<summary> A color described as Ultramarine Blue with a HEX value of <c>#1805DB</c>.
        UltramarineBlue = 0x1805DB,
        ///<summary> A color described as Iris with a HEX value of <c>#6258C4</c>.
        Iris = 0x6258C4,
        ///<summary> A color described as Pastel Orange with a HEX value of <c>#FF964F</c>.
        PastelOrange = 0xFF964F,
        ///<summary> A color described as Yellowish Orange with a HEX value of <c>#FFAB0F</c>.
        YellowishOrange = 0xFFAB0F,
        ///<summary> A color described as Perrywinkle with a HEX value of <c>#8F8CE7</c>.
        Perrywinkle = 0x8F8CE7,
        ///<summary> A color described as Tealish with a HEX value of <c>#24BCA8</c>.
        Tealish = 0x24BCA8,
        ///<summary> A color described as Dark Plum with a HEX value of <c>#3F012C</c>.
        DarkPlum = 0x3F012C,
        ///<summary> A color described as Pear with a HEX value of <c>#CBF85F</c>.
        Pear = 0xCBF85F,
        ///<summary> A color described as Pinkish Orange with a HEX value of <c>#FF724C</c>.
        PinkishOrange = 0xFF724C,
        ///<summary> A color described as Midnight Purple with a HEX value of <c>#280137</c>.
        MidnightPurple = 0x280137,
        ///<summary> A color described as Light Urple with a HEX value of <c>#B36FF6</c>.
        LightUrple = 0xB36FF6,
        ///<summary> A color described as Dark Mint with a HEX value of <c>#48C072</c>.
        DarkMint = 0x48C072,
        ///<summary> A color described as Greenish Tan with a HEX value of <c>#BCCB7A</c>.
        GreenishTan = 0xBCCB7A,
        ///<summary> A color described as Light Burgundy with a HEX value of <c>#A8415B</c>.
        LightBurgundy = 0xA8415B,
        ///<summary> A color described as Turquoise Blue with a HEX value of <c>#06B1C4</c>.
        TurquoiseBlue = 0x06B1C4,
        ///<summary> A color described as Ugly Pink with a HEX value of <c>#CD7584</c>.
        UglyPink = 0xCD7584,
        ///<summary> A color described as Sandy with a HEX value of <c>#F1DA7A</c>.
        Sandy = 0xF1DA7A,
        ///<summary> A color described as Electric Pink with a HEX value of <c>#FF0490</c>.
        ElectricPink = 0xFF0490,
        ///<summary> A color described as Muted Purple with a HEX value of <c>#805B87</c>.
        MutedPurple = 0x805B87,
        ///<summary> A color described as Mid Green with a HEX value of <c>#50A747</c>.
        MidGreen = 0x50A747,
        ///<summary> A color described as Greyish with a HEX value of <c>#A8A495</c>.
        Greyish = 0xA8A495,
        ///<summary> A color described as Neon Yellow with a HEX value of <c>#CFFF04</c>.
        NeonYellow = 0xCFFF04,
        ///<summary> A color described as Banana with a HEX value of <c>#FFFF7E</c>.
        Banana = 0xFFFF7E,
        ///<summary> A color described as Carnation Pink with a HEX value of <c>#FF7FA7</c>.
        CarnationPink = 0xFF7FA7,
        ///<summary> A color described as Tomato with a HEX value of <c>#EF4026</c>.
        Tomato = 0xEF4026,
        ///<summary> A color described as Sea with a HEX value of <c>#3C9992</c>.
        Sea = 0x3C9992,
        ///<summary> A color described as Muddy Brown with a HEX value of <c>#886806</c>.
        MuddyBrown = 0x886806,
        ///<summary> A color described as Turquoise Green with a HEX value of <c>#04F489</c>.
        TurquoiseGreen = 0x04F489,
        ///<summary> A color described as Buff with a HEX value of <c>#FEF69E</c>.
        Buff = 0xFEF69E,
        ///<summary> A color described as Fawn with a HEX value of <c>#CFAF7B</c>.
        Fawn = 0xCFAF7B,
        ///<summary> A color described as Muted Blue with a HEX value of <c>#3B719F</c>.
        MutedBlue = 0x3B719F,
        ///<summary> A color described as Pale Rose with a HEX value of <c>#FDC1C5</c>.
        PaleRose = 0xFDC1C5,
        ///<summary> A color described as Dark Mint Green with a HEX value of <c>#20C073</c>.
        DarkMintGreen = 0x20C073,
        ///<summary> A color described as Amethyst with a HEX value of <c>#9B5FC0</c>.
        Amethyst = 0x9B5FC0,
        ///<summary> A color described as Blue/Green with a HEX value of <c>#0F9B8E</c>.
        BlueGreen = 0x0F9B8E,
        ///<summary> A color described as Chestnut with a HEX value of <c>#742802</c>.
        Chestnut = 0x742802,
        ///<summary> A color described as Sick Green with a HEX value of <c>#9DB92C</c>.
        SickGreen = 0x9DB92C,
        ///<summary> A color described as Pea with a HEX value of <c>#A4BF20</c>.
        Pea = 0xA4BF20,
        ///<summary> A color described as Rusty Orange with a HEX value of <c>#CD5909</c>.
        RustyOrange = 0xCD5909,
        ///<summary> A color described as Stone with a HEX value of <c>#ADA587</c>.
        Stone = 0xADA587,
        ///<summary> A color described as Rose Red with a HEX value of <c>#BE013C</c>.
        RoseRed = 0xBE013C,
        ///<summary> A color described as Pale Aqua with a HEX value of <c>#B8FFEB</c>.
        PaleAqua = 0xB8FFEB,
        ///<summary> A color described as Deep Orange with a HEX value of <c>#DC4D01</c>.
        DeepOrange = 0xDC4D01,
        ///<summary> A color described as Earth with a HEX value of <c>#A2653E</c>.
        Earth = 0xA2653E,
        ///<summary> A color described as Mossy Green with a HEX value of <c>#638B27</c>.
        MossyGreen = 0x638B27,
        ///<summary> A color described as Grassy Green with a HEX value of <c>#419C03</c>.
        GrassyGreen = 0x419C03,
        ///<summary> A color described as Pale Lime Green with a HEX value of <c>#B1FF65</c>.
        PaleLimeGreen = 0xB1FF65,
        ///<summary> A color described as Light Grey Blue with a HEX value of <c>#9DBCD4</c>.
        LightGreyBlue = 0x9DBCD4,
        ///<summary> A color described as Pale Grey with a HEX value of <c>#FDFDFE</c>.
        PaleGrey = 0xFDFDFE,
        ///<summary> A color described as Asparagus with a HEX value of <c>#77AB56</c>.
        Asparagus = 0x77AB56,
        ///<summary> A color described as Blueberry with a HEX value of <c>#464196</c>.
        Blueberry = 0x464196,
        ///<summary> A color described as Purple Red with a HEX value of <c>#990147</c>.
        PurpleRed = 0x990147,
        ///<summary> A color described as Pale Lime with a HEX value of <c>#BEFD73</c>.
        PaleLime = 0xBEFD73,
        ///<summary> A color described as Greenish Teal with a HEX value of <c>#32BF84</c>.
        GreenishTeal = 0x32BF84,
        ///<summary> A color described as Caramel with a HEX value of <c>#AF6F09</c>.
        Caramel = 0xAF6F09,
        ///<summary> A color described as Deep Magenta with a HEX value of <c>#A0025C</c>.
        DeepMagenta = 0xA0025C,
        ///<summary> A color described as Light Peach with a HEX value of <c>#FFD8B1</c>.
        LightPeach = 0xFFD8B1,
        ///<summary> A color described as Milk Chocolate with a HEX value of <c>#7F4E1E</c>.
        MilkChocolate = 0x7F4E1E,
        ///<summary> A color described as Ocher with a HEX value of <c>#BF9B0C</c>.
        Ocher = 0xBF9B0C,
        ///<summary> A color described as Off Green with a HEX value of <c>#6BA353</c>.
        OffGreen = 0x6BA353,
        ///<summary> A color described as Purply Pink with a HEX value of <c>#F075E6</c>.
        PurplyPink = 0xF075E6,
        ///<summary> A color described as Lightblue with a HEX value of <c>#7BC8F6</c>.
        Lightblue = 0x7BC8F6,
        ///<summary> A color described as Dusky Blue with a HEX value of <c>#475F94</c>.
        DuskyBlue = 0x475F94,
        ///<summary> A color described as Golden with a HEX value of <c>#F5BF03</c>.
        Golden = 0xF5BF03,
        ///<summary> A color described as Light Beige with a HEX value of <c>#FFFEB6</c>.
        LightBeige = 0xFFFEB6,
        ///<summary> A color described as Butter Yellow with a HEX value of <c>#FFFD74</c>.
        ButterYellow = 0xFFFD74,
        ///<summary> A color described as Dusky Purple with a HEX value of <c>#895B7B</c>.
        DuskyPurple = 0x895B7B,
        ///<summary> A color described as French Blue with a HEX value of <c>#436BAD</c>.
        FrenchBlue = 0x436BAD,
        ///<summary> A color described as Ugly Yellow with a HEX value of <c>#D0C101</c>.
        UglyYellow = 0xD0C101,
        ///<summary> A color described as Greeny Yellow with a HEX value of <c>#C6F808</c>.
        GreenyYellow = 0xC6F808,
        ///<summary> A color described as Orangish Red with a HEX value of <c>#F43605</c>.
        OrangishRed = 0xF43605,
        ///<summary> A color described as Shamrock Green with a HEX value of <c>#02C14D</c>.
        ShamrockGreen = 0x02C14D,
        ///<summary> A color described as Orangish Brown with a HEX value of <c>#B25F03</c>.
        OrangishBrown = 0xB25F03,
        ///<summary> A color described as Tree Green with a HEX value of <c>#2A7E19</c>.
        TreeGreen = 0x2A7E19,
        ///<summary> A color described as Deep Violet with a HEX value of <c>#490648</c>.
        DeepViolet = 0x490648,
        ///<summary> A color described as Gunmetal with a HEX value of <c>#536267</c>.
        Gunmetal = 0x536267,
        ///<summary> A color described as Blue/Purple with a HEX value of <c>#5A06EF</c>.
        BluePurple = 0x5A06EF,
        ///<summary> A color described as Cherry with a HEX value of <c>#CF0234</c>.
        Cherry = 0xCF0234,
        ///<summary> A color described as Sandy Brown with a HEX value of <c>#C4A661</c>.
        SandyBrown = 0xC4A661,
        ///<summary> A color described as Warm Grey with a HEX value of <c>#978A84</c>.
        WarmGrey = 0x978A84,
        ///<summary> A color described as Dark Indigo with a HEX value of <c>#1F0954</c>.
        DarkIndigo = 0x1F0954,
        ///<summary> A color described as Midnight with a HEX value of <c>#03012D</c>.
        Midnight = 0x03012D,
        ///<summary> A color described as Bluey Green with a HEX value of <c>#2BB179</c>.
        BlueyGreen = 0x2BB179,
        ///<summary> A color described as Grey Pink with a HEX value of <c>#C3909B</c>.
        GreyPink = 0xC3909B,
        ///<summary> A color described as Soft Purple with a HEX value of <c>#A66FB5</c>.
        SoftPurple = 0xA66FB5,
        ///<summary> A color described as Blood with a HEX value of <c>#770001</c>.
        Blood = 0x770001,
        ///<summary> A color described as Brown Red with a HEX value of <c>#922B05</c>.
        BrownRed = 0x922B05,
        ///<summary> A color described as Medium Grey with a HEX value of <c>#7D7F7C</c>.
        MediumGrey = 0x7D7F7C,
        ///<summary> A color described as Berry with a HEX value of <c>#990F4B</c>.
        Berry = 0x990F4B,
        ///<summary> A color described as Poo with a HEX value of <c>#8F7303</c>.
        Poo = 0x8F7303,
        ///<summary> A color described as Purpley Pink with a HEX value of <c>#C83CB9</c>.
        PurpleyPink = 0xC83CB9,
        ///<summary> A color described as Light Salmon with a HEX value of <c>#FEA993</c>.
        LightSalmon = 0xFEA993,
        ///<summary> A color described as Snot with a HEX value of <c>#ACBB0D</c>.
        Snot = 0xACBB0D,
        ///<summary> A color described as Easter Purple with a HEX value of <c>#C071FE</c>.
        EasterPurple = 0xC071FE,
        ///<summary> A color described as Light Yellow Green with a HEX value of <c>#CCFD7F</c>.
        LightYellowGreen = 0xCCFD7F,
        ///<summary> A color described as Dark Navy Blue with a HEX value of <c>#00022E</c>.
        DarkNavyBlue = 0x00022E,
        ///<summary> A color described as Drab with a HEX value of <c>#828344</c>.
        Drab = 0x828344,
        ///<summary> A color described as Light Rose with a HEX value of <c>#FFC5CB</c>.
        LightRose = 0xFFC5CB,
        ///<summary> A color described as Rouge with a HEX value of <c>#AB1239</c>.
        Rouge = 0xAB1239,
        ///<summary> A color described as Purplish Red with a HEX value of <c>#B0054B</c>.
        PurplishRed = 0xB0054B,
        ///<summary> A color described as Slime Green with a HEX value of <c>#99CC04</c>.
        SlimeGreen = 0x99CC04,
        ///<summary> A color described as Baby Poop with a HEX value of <c>#937C00</c>.
        BabyPoop = 0x937C00,
        ///<summary> A color described as Irish Green with a HEX value of <c>#019529</c>.
        IrishGreen = 0x019529,
        ///<summary> A color described as Pink/Purple with a HEX value of <c>#EF1DE7</c>.
        PinkPurple = 0xEF1DE7,
        ///<summary> A color described as Dark Navy with a HEX value of <c>#000435</c>.
        DarkNavy = 0x000435,
        ///<summary> A color described as Greeny Blue with a HEX value of <c>#42B395</c>.
        GreenyBlue = 0x42B395,
        ///<summary> A color described as Light Plum with a HEX value of <c>#9D5783</c>.
        LightPlum = 0x9D5783,
        ///<summary> A color described as Pinkish Grey with a HEX value of <c>#C8ACA9</c>.
        PinkishGrey = 0xC8ACA9,
        ///<summary> A color described as Dirty Orange with a HEX value of <c>#C87606</c>.
        DirtyOrange = 0xC87606,
        ///<summary> A color described as Rust Red with a HEX value of <c>#AA2704</c>.
        RustRed = 0xAA2704,
        ///<summary> A color described as Pale Lilac with a HEX value of <c>#E4CBFF</c>.
        PaleLilac = 0xE4CBFF,
        ///<summary> A color described as Orangey Red with a HEX value of <c>#FA4224</c>.
        OrangeyRed = 0xFA4224,
        ///<summary> A color described as Primary Blue with a HEX value of <c>#0804F9</c>.
        PrimaryBlue = 0x0804F9,
        ///<summary> A color described as Kermit Green with a HEX value of <c>#5CB200</c>.
        KermitGreen = 0x5CB200,
        ///<summary> A color described as Brownish Purple with a HEX value of <c>#76424E</c>.
        BrownishPurple = 0x76424E,
        ///<summary> A color described as Murky Green with a HEX value of <c>#6C7A0E</c>.
        MurkyGreen = 0x6C7A0E,
        ///<summary> A color described as Wheat with a HEX value of <c>#FBDD7E</c>.
        Wheat = 0xFBDD7E,
        ///<summary> A color described as Very Dark Purple with a HEX value of <c>#2A0134</c>.
        VeryDarkPurple = 0x2A0134,
        ///<summary> A color described as Bottle Green with a HEX value of <c>#044A05</c>.
        BottleGreen = 0x044A05,
        ///<summary> A color described as Watermelon with a HEX value of <c>#FD4659</c>.
        Watermelon = 0xFD4659,
        ///<summary> A color described as Deep Sky Blue with a HEX value of <c>#0D75F8</c>.
        DeepSkyBlue = 0x0D75F8,
        ///<summary> A color described as Fire Engine Red with a HEX value of <c>#FE0002</c>.
        FireEngineRed = 0xFE0002,
        ///<summary> A color described as Yellow Ochre with a HEX value of <c>#CB9D06</c>.
        YellowOchre = 0xCB9D06,
        ///<summary> A color described as Pumpkin Orange with a HEX value of <c>#FB7D07</c>.
        PumpkinOrange = 0xFB7D07,
        ///<summary> A color described as Pale Olive with a HEX value of <c>#B9CC81</c>.
        PaleOlive = 0xB9CC81,
        ///<summary> A color described as Light Lilac with a HEX value of <c>#EDC8FF</c>.
        LightLilac = 0xEDC8FF,
        ///<summary> A color described as Lightish Green with a HEX value of <c>#61E160</c>.
        LightishGreen = 0x61E160,
        ///<summary> A color described as Carolina Blue with a HEX value of <c>#8AB8FE</c>.
        CarolinaBlue = 0x8AB8FE,
        ///<summary> A color described as Mulberry with a HEX value of <c>#920A4E</c>.
        Mulberry = 0x920A4E,
        ///<summary> A color described as Shocking Pink with a HEX value of <c>#FE02A2</c>.
        ShockingPink = 0xFE02A2,
        ///<summary> A color described as Auburn with a HEX value of <c>#9A3001</c>.
        Auburn = 0x9A3001,
        ///<summary> A color described as Bright Lime Green with a HEX value of <c>#65FE08</c>.
        BrightLimeGreen = 0x65FE08,
        ///<summary> A color described as Celadon with a HEX value of <c>#BEFDB7</c>.
        Celadon = 0xBEFDB7,
        ///<summary> A color described as Pinkish Brown with a HEX value of <c>#B17261</c>.
        PinkishBrown = 0xB17261,
        ///<summary> A color described as Poo Brown with a HEX value of <c>#885F01</c>.
        PooBrown = 0x885F01,
        ///<summary> A color described as Bright Sky Blue with a HEX value of <c>#02CCFE</c>.
        BrightSkyBlue = 0x02CCFE,
        ///<summary> A color described as Celery with a HEX value of <c>#C1FD95</c>.
        Celery = 0xC1FD95,
        ///<summary> A color described as Dirt Brown with a HEX value of <c>#836539</c>.
        DirtBrown = 0x836539,
        ///<summary> A color described as Strawberry with a HEX value of <c>#FB2943</c>.
        Strawberry = 0xFB2943,
        ///<summary> A color described as Dark Lime with a HEX value of <c>#84B701</c>.
        DarkLime = 0x84B701,
        ///<summary> A color described as Copper with a HEX value of <c>#B66325</c>.
        Copper = 0xB66325,
        ///<summary> A color described as Medium Brown with a HEX value of <c>#7F5112</c>.
        MediumBrown = 0x7F5112,
        ///<summary> A color described as Muted Green with a HEX value of <c>#5FA052</c>.
        MutedGreen = 0x5FA052,
        ///<summary> A color described as Robin'S Egg with a HEX value of <c>#6DEDFD</c>.
        RobinsEgg = 0x6DEDFD,
        ///<summary> A color described as Bright Aqua with a HEX value of <c>#0BF9EA</c>.
        BrightAqua = 0x0BF9EA,
        ///<summary> A color described as Bright Lavender with a HEX value of <c>#C760FF</c>.
        BrightLavender = 0xC760FF,
        ///<summary> A color described as Ivory with a HEX value of <c>#FFFFCB</c>.
        Ivory = 0xFFFFCB,
        ///<summary> A color described as Very Light Purple with a HEX value of <c>#F6CEFC</c>.
        VeryLightPurple = 0xF6CEFC,
        ///<summary> A color described as Light Navy with a HEX value of <c>#155084</c>.
        LightNavy = 0x155084,
        ///<summary> A color described as Pink Red with a HEX value of <c>#F5054F</c>.
        PinkRed = 0xF5054F,
        ///<summary> A color described as Olive Brown with a HEX value of <c>#645403</c>.
        OliveBrown = 0x645403,
        ///<summary> A color described as Poop Brown with a HEX value of <c>#7A5901</c>.
        PoopBrown = 0x7A5901,
        ///<summary> A color described as Mustard Green with a HEX value of <c>#A8B504</c>.
        MustardGreen = 0xA8B504,
        ///<summary> A color described as Ocean Green with a HEX value of <c>#3D9973</c>.
        OceanGreen = 0x3D9973,
        ///<summary> A color described as Very Dark Blue with a HEX value of <c>#000133</c>.
        VeryDarkBlue = 0x000133,
        ///<summary> A color described as Dusty Green with a HEX value of <c>#76A973</c>.
        DustyGreen = 0x76A973,
        ///<summary> A color described as Light Navy Blue with a HEX value of <c>#2E5A88</c>.
        LightNavyBlue = 0x2E5A88,
        ///<summary> A color described as Minty Green with a HEX value of <c>#0BF77D</c>.
        MintyGreen = 0x0BF77D,
        ///<summary> A color described as Adobe with a HEX value of <c>#BD6C48</c>.
        Adobe = 0xBD6C48,
        ///<summary> A color described as Barney with a HEX value of <c>#AC1DB8</c>.
        Barney = 0xAC1DB8,
        ///<summary> A color described as Jade Green with a HEX value of <c>#2BAF6A</c>.
        JadeGreen = 0x2BAF6A,
        ///<summary> A color described as Bright Light Blue with a HEX value of <c>#26F7FD</c>.
        BrightLightBlue = 0x26F7FD,
        ///<summary> A color described as Light Lime with a HEX value of <c>#AEFD6C</c>.
        LightLime = 0xAEFD6C,
        ///<summary> A color described as Dark Khaki with a HEX value of <c>#9B8F55</c>.
        DarkKhaki = 0x9B8F55,
        ///<summary> A color described as Orange Yellow with a HEX value of <c>#FFAD01</c>.
        OrangeYellow = 0xFFAD01,
        ///<summary> A color described as Ocre with a HEX value of <c>#C69C04</c>.
        Ocre = 0xC69C04,
        ///<summary> A color described as Maize with a HEX value of <c>#F4D054</c>.
        Maize = 0xF4D054,
        ///<summary> A color described as Faded Pink with a HEX value of <c>#DE9DAC</c>.
        FadedPink = 0xDE9DAC,
        ///<summary> A color described as British Racing Green with a HEX value of <c>#05480D</c>.
        BritishRacingGreen = 0x05480D,
        ///<summary> A color described as Sandstone with a HEX value of <c>#C9AE74</c>.
        Sandstone = 0xC9AE74,
        ///<summary> A color described as Mud Brown with a HEX value of <c>#60460F</c>.
        MudBrown = 0x60460F,
        ///<summary> A color described as Light Sea Green with a HEX value of <c>#98F6B0</c>.
        LightSeaGreen = 0x98F6B0,
        ///<summary> A color described as Robin Egg Blue with a HEX value of <c>#8AF1FE</c>.
        RobinEggBlue = 0x8AF1FE,
        ///<summary> A color described as Aqua Marine with a HEX value of <c>#2EE8BB</c>.
        AquaMarine = 0x2EE8BB,
        ///<summary> A color described as Dark Sea Green with a HEX value of <c>#11875D</c>.
        DarkSeaGreen = 0x11875D,
        ///<summary> A color described as Soft Pink with a HEX value of <c>#FDB0C0</c>.
        SoftPink = 0xFDB0C0,
        ///<summary> A color described as Orangey Brown with a HEX value of <c>#B16002</c>.
        OrangeyBrown = 0xB16002,
        ///<summary> A color described as Cherry Red with a HEX value of <c>#F7022A</c>.
        CherryRed = 0xF7022A,
        ///<summary> A color described as Burnt Yellow with a HEX value of <c>#D5AB09</c>.
        BurntYellow = 0xD5AB09,
        ///<summary> A color described as Brownish Grey with a HEX value of <c>#86775F</c>.
        BrownishGrey = 0x86775F,
        ///<summary> A color described as Camel with a HEX value of <c>#C69F59</c>.
        Camel = 0xC69F59,
        ///<summary> A color described as Purplish Grey with a HEX value of <c>#7A687F</c>.
        PurplishGrey = 0x7A687F,
        ///<summary> A color described as Marine with a HEX value of <c>#042E60</c>.
        Marine = 0x042E60,
        ///<summary> A color described as Greyish Pink with a HEX value of <c>#C88D94</c>.
        GreyishPink = 0xC88D94,
        ///<summary> A color described as Pale Turquoise with a HEX value of <c>#A5FBD5</c>.
        PaleTurquoise = 0xA5FBD5,
        ///<summary> A color described as Pastel Yellow with a HEX value of <c>#FFFE71</c>.
        PastelYellow = 0xFFFE71,
        ///<summary> A color described as Bluey Purple with a HEX value of <c>#6241C7</c>.
        BlueyPurple = 0x6241C7,
        ///<summary> A color described as Canary Yellow with a HEX value of <c>#FFFE40</c>.
        CanaryYellow = 0xFFFE40,
        ///<summary> A color described as Faded Red with a HEX value of <c>#D3494E</c>.
        FadedRed = 0xD3494E,
        ///<summary> A color described as Sepia with a HEX value of <c>#985E2B</c>.
        Sepia = 0x985E2B,
        ///<summary> A color described as Coffee with a HEX value of <c>#A6814C</c>.
        Coffee = 0xA6814C,
        ///<summary> A color described as Bright Magenta with a HEX value of <c>#FF08E8</c>.
        BrightMagenta = 0xFF08E8,
        ///<summary> A color described as Mocha with a HEX value of <c>#9D7651</c>.
        Mocha = 0x9D7651,
        ///<summary> A color described as Ecru with a HEX value of <c>#FEFFCA</c>.
        Ecru = 0xFEFFCA,
        ///<summary> A color described as Purpleish with a HEX value of <c>#98568D</c>.
        Purpleish = 0x98568D,
        ///<summary> A color described as Cranberry with a HEX value of <c>#9E003A</c>.
        Cranberry = 0x9E003A,
        ///<summary> A color described as Darkish Green with a HEX value of <c>#287C37</c>.
        DarkishGreen = 0x287C37,
        ///<summary> A color described as Brown Orange with a HEX value of <c>#B96902</c>.
        BrownOrange = 0xB96902,
        ///<summary> A color described as Dusky Rose with a HEX value of <c>#BA6873</c>.
        DuskyRose = 0xBA6873,
        ///<summary> A color described as Melon with a HEX value of <c>#FF7855</c>.
        Melon = 0xFF7855,
        ///<summary> A color described as Sickly Green with a HEX value of <c>#94B21C</c>.
        SicklyGreen = 0x94B21C,
        ///<summary> A color described as Silver with a HEX value of <c>#C5C9C7</c>.
        Silver = 0xC5C9C7,
        ///<summary> A color described as Purply Blue with a HEX value of <c>#661AEE</c>.
        PurplyBlue = 0x661AEE,
        ///<summary> A color described as Purpleish Blue with a HEX value of <c>#6140EF</c>.
        PurpleishBlue = 0x6140EF,
        ///<summary> A color described as Hospital Green with a HEX value of <c>#9BE5AA</c>.
        HospitalGreen = 0x9BE5AA,
        ///<summary> A color described as Shit Brown with a HEX value of <c>#7B5804</c>.
        ShitBrown = 0x7B5804,
        ///<summary> A color described as Mid Blue with a HEX value of <c>#276AB3</c>.
        MidBlue = 0x276AB3,
        ///<summary> A color described as Amber with a HEX value of <c>#FEB308</c>.
        Amber = 0xFEB308,
        ///<summary> A color described as Easter Green with a HEX value of <c>#8CFD7E</c>.
        EasterGreen = 0x8CFD7E,
        ///<summary> A color described as Soft Blue with a HEX value of <c>#6488EA</c>.
        SoftBlue = 0x6488EA,
        ///<summary> A color described as Cerulean Blue with a HEX value of <c>#056EEE</c>.
        CeruleanBlue = 0x056EEE,
        ///<summary> A color described as Golden Brown with a HEX value of <c>#B27A01</c>.
        GoldenBrown = 0xB27A01,
        ///<summary> A color described as Bright Turquoise with a HEX value of <c>#0FFEF9</c>.
        BrightTurquoise = 0x0FFEF9,
        ///<summary> A color described as Red Pink with a HEX value of <c>#FA2A55</c>.
        RedPink = 0xFA2A55,
        ///<summary> A color described as Red Purple with a HEX value of <c>#820747</c>.
        RedPurple = 0x820747,
        ///<summary> A color described as Greyish Brown with a HEX value of <c>#7A6A4F</c>.
        GreyishBrown = 0x7A6A4F,
        ///<summary> A color described as Vermillion with a HEX value of <c>#F4320C</c>.
        Vermillion = 0xF4320C,
        ///<summary> A color described as Russet with a HEX value of <c>#A13905</c>.
        Russet = 0xA13905,
        ///<summary> A color described as Steel Grey with a HEX value of <c>#6F828A</c>.
        SteelGrey = 0x6F828A,
        ///<summary> A color described as Lighter Purple with a HEX value of <c>#A55AF4</c>.
        LighterPurple = 0xA55AF4,
        ///<summary> A color described as Bright Violet with a HEX value of <c>#AD0AFD</c>.
        BrightViolet = 0xAD0AFD,
        ///<summary> A color described as Prussian Blue with a HEX value of <c>#004577</c>.
        PrussianBlue = 0x004577,
        ///<summary> A color described as Slate Green with a HEX value of <c>#658D6D</c>.
        SlateGreen = 0x658D6D,
        ///<summary> A color described as Dirty Pink with a HEX value of <c>#CA7B80</c>.
        DirtyPink = 0xCA7B80,
        ///<summary> A color described as Dark Blue Green with a HEX value of <c>#005249</c>.
        DarkBlueGreen = 0x005249,
        ///<summary> A color described as Pine with a HEX value of <c>#2B5D34</c>.
        Pine = 0x2B5D34,
        ///<summary> A color described as Yellowy Green with a HEX value of <c>#BFF128</c>.
        YellowyGreen = 0xBFF128,
        ///<summary> A color described as Dark Gold with a HEX value of <c>#B59410</c>.
        DarkGold = 0xB59410,
        ///<summary> A color described as Bluish with a HEX value of <c>#2976BB</c>.
        Bluish = 0x2976BB,
        ///<summary> A color described as Darkish Blue with a HEX value of <c>#014182</c>.
        DarkishBlue = 0x014182,
        ///<summary> A color described as Dull Red with a HEX value of <c>#BB3F3F</c>.
        DullRed = 0xBB3F3F,
        ///<summary> A color described as Pinky Red with a HEX value of <c>#FC2647</c>.
        PinkyRed = 0xFC2647,
        ///<summary> A color described as Bronze with a HEX value of <c>#A87900</c>.
        Bronze = 0xA87900,
        ///<summary> A color described as Pale Teal with a HEX value of <c>#82CBB2</c>.
        PaleTeal = 0x82CBB2,
        ///<summary> A color described as Military Green with a HEX value of <c>#667C3E</c>.
        MilitaryGreen = 0x667C3E,
        ///<summary> A color described as Barbie Pink with a HEX value of <c>#FE46A5</c>.
        BarbiePink = 0xFE46A5,
        ///<summary> A color described as Bubblegum Pink with a HEX value of <c>#FE83CC</c>.
        BubblegumPink = 0xFE83CC,
        ///<summary> A color described as Pea Soup Green with a HEX value of <c>#94A617</c>.
        PeaSoupGreen = 0x94A617,
        ///<summary> A color described as Dark Mustard with a HEX value of <c>#A88905</c>.
        DarkMustard = 0xA88905,
        ///<summary> A color described as Shit with a HEX value of <c>#7F5F00</c>.
        Shit = 0x7F5F00,
        ///<summary> A color described as Medium Purple with a HEX value of <c>#9E43A2</c>.
        MediumPurple = 0x9E43A2,
        ///<summary> A color described as Very Dark Green with a HEX value of <c>#062E03</c>.
        VeryDarkGreen = 0x062E03,
        ///<summary> A color described as Dirt with a HEX value of <c>#8A6E45</c>.
        Dirt = 0x8A6E45,
        ///<summary> A color described as Dusky Pink with a HEX value of <c>#CC7A8B</c>.
        DuskyPink = 0xCC7A8B,
        ///<summary> A color described as Red Violet with a HEX value of <c>#9E0168</c>.
        RedViolet = 0x9E0168,
        ///<summary> A color described as Lemon Yellow with a HEX value of <c>#FDFF38</c>.
        LemonYellow = 0xFDFF38,
        ///<summary> A color described as Pistachio with a HEX value of <c>#C0FA8B</c>.
        Pistachio = 0xC0FA8B,
        ///<summary> A color described as Dull Yellow with a HEX value of <c>#EEDC5B</c>.
        DullYellow = 0xEEDC5B,
        ///<summary> A color described as Dark Lime Green with a HEX value of <c>#7EBD01</c>.
        DarkLimeGreen = 0x7EBD01,
        ///<summary> A color described as Denim Blue with a HEX value of <c>#3B5B92</c>.
        DenimBlue = 0x3B5B92,
        ///<summary> A color described as Teal Blue with a HEX value of <c>#01889F</c>.
        TealBlue = 0x01889F,
        ///<summary> A color described as Lightish Blue with a HEX value of <c>#3D7AFD</c>.
        LightishBlue = 0x3D7AFD,
        ///<summary> A color described as Purpley Blue with a HEX value of <c>#5F34E7</c>.
        PurpleyBlue = 0x5F34E7,
        ///<summary> A color described as Light Indigo with a HEX value of <c>#6D5ACF</c>.
        LightIndigo = 0x6D5ACF,
        ///<summary> A color described as Swamp Green with a HEX value of <c>#748500</c>.
        SwampGreen = 0x748500,
        ///<summary> A color described as Brown Green with a HEX value of <c>#706C11</c>.
        BrownGreen = 0x706C11,
        ///<summary> A color described as Dark Maroon with a HEX value of <c>#3C0008</c>.
        DarkMaroon = 0x3C0008,
        ///<summary> A color described as Hot Purple with a HEX value of <c>#CB00F5</c>.
        HotPurple = 0xCB00F5,
        ///<summary> A color described as Dark Forest Green with a HEX value of <c>#002D04</c>.
        DarkForestGreen = 0x002D04,
        ///<summary> A color described as Faded Blue with a HEX value of <c>#658CBB</c>.
        FadedBlue = 0x658CBB,
        ///<summary> A color described as Drab Green with a HEX value of <c>#749551</c>.
        DrabGreen = 0x749551,
        ///<summary> A color described as Light Lime Green with a HEX value of <c>#B9FF66</c>.
        LightLimeGreen = 0xB9FF66,
        ///<summary> A color described as Snot Green with a HEX value of <c>#9DC100</c>.
        SnotGreen = 0x9DC100,
        ///<summary> A color described as Yellowish with a HEX value of <c>#FAEE66</c>.
        Yellowish = 0xFAEE66,
        ///<summary> A color described as Light Blue Green with a HEX value of <c>#7EFBB3</c>.
        LightBlueGreen = 0x7EFBB3,
        ///<summary> A color described as Bordeaux with a HEX value of <c>#7B002C</c>.
        Bordeaux = 0x7B002C,
        ///<summary> A color described as Light Mauve with a HEX value of <c>#C292A1</c>.
        LightMauve = 0xC292A1,
        ///<summary> A color described as Ocean with a HEX value of <c>#017B92</c>.
        Ocean = 0x017B92,
        ///<summary> A color described as Marigold with a HEX value of <c>#FCC006</c>.
        Marigold = 0xFCC006,
        ///<summary> A color described as Muddy Green with a HEX value of <c>#657432</c>.
        MuddyGreen = 0x657432,
        ///<summary> A color described as Dull Orange with a HEX value of <c>#D8863B</c>.
        DullOrange = 0xD8863B,
        ///<summary> A color described as Steel with a HEX value of <c>#738595</c>.
        Steel = 0x738595,
        ///<summary> A color described as Electric Purple with a HEX value of <c>#AA23FF</c>.
        ElectricPurple = 0xAA23FF,
        ///<summary> A color described as Fluorescent Green with a HEX value of <c>#08FF08</c>.
        FluorescentGreen = 0x08FF08,
        ///<summary> A color described as Yellowish Brown with a HEX value of <c>#9B7A01</c>.
        YellowishBrown = 0x9B7A01,
        ///<summary> A color described as Blush with a HEX value of <c>#F29E8E</c>.
        Blush = 0xF29E8E,
        ///<summary> A color described as Soft Green with a HEX value of <c>#6FC276</c>.
        SoftGreen = 0x6FC276,
        ///<summary> A color described as Bright Orange with a HEX value of <c>#FF5B00</c>.
        BrightOrange = 0xFF5B00,
        ///<summary> A color described as Lemon with a HEX value of <c>#FDFF52</c>.
        Lemon = 0xFDFF52,
        ///<summary> A color described as Purple Grey with a HEX value of <c>#866F85</c>.
        PurpleGrey = 0x866F85,
        ///<summary> A color described as Acid Green with a HEX value of <c>#8FFE09</c>.
        AcidGreen = 0x8FFE09,
        ///<summary> A color described as Pale Lavender with a HEX value of <c>#EECFFE</c>.
        PaleLavender = 0xEECFFE,
        ///<summary> A color described as Violet Blue with a HEX value of <c>#510AC9</c>.
        VioletBlue = 0x510AC9,
        ///<summary> A color described as Light Forest Green with a HEX value of <c>#4F9153</c>.
        LightForestGreen = 0x4F9153,
        ///<summary> A color described as Burnt Red with a HEX value of <c>#9F2305</c>.
        BurntRed = 0x9F2305,
        ///<summary> A color described as Khaki Green with a HEX value of <c>#728639</c>.
        KhakiGreen = 0x728639,
        ///<summary> A color described as Cerise with a HEX value of <c>#DE0C62</c>.
        Cerise = 0xDE0C62,
        ///<summary> A color described as Faded Purple with a HEX value of <c>#916E99</c>.
        FadedPurple = 0x916E99,
        ///<summary> A color described as Apricot with a HEX value of <c>#FFB16D</c>.
        Apricot = 0xFFB16D,
        ///<summary> A color described as Dark Olive Green with a HEX value of <c>#3C4D03</c>.
        DarkOliveGreen = 0x3C4D03,
        ///<summary> A color described as Grey Brown with a HEX value of <c>#7F7053</c>.
        GreyBrown = 0x7F7053,
        ///<summary> A color described as Green Grey with a HEX value of <c>#77926F</c>.
        GreenGrey = 0x77926F,
        ///<summary> A color described as True Blue with a HEX value of <c>#010FCC</c>.
        TrueBlue = 0x010FCC,
        ///<summary> A color described as Pale Violet with a HEX value of <c>#CEAEFA</c>.
        PaleViolet = 0xCEAEFA,
        ///<summary> A color described as Periwinkle Blue with a HEX value of <c>#8F99FB</c>.
        PeriwinkleBlue = 0x8F99FB,
        ///<summary> A color described as Light Sky Blue with a HEX value of <c>#C6FCFF</c>.
        LightSkyBlue = 0xC6FCFF,
        ///<summary> A color described as Blurple with a HEX value of <c>#5539CC</c>.
        Blurple = 0x5539CC,
        ///<summary> A color described as Green Brown with a HEX value of <c>#544E03</c>.
        GreenBrown = 0x544E03,
        ///<summary> A color described as Bluegreen with a HEX value of <c>#017A79</c>.
        Bluegreen = 0x017A79,
        ///<summary> A color described as Bright Teal with a HEX value of <c>#01F9C6</c>.
        BrightTeal = 0x01F9C6,
        ///<summary> A color described as Brownish Yellow with a HEX value of <c>#C9B003</c>.
        BrownishYellow = 0xC9B003,
        ///<summary> A color described as Pea Soup with a HEX value of <c>#929901</c>.
        PeaSoup = 0x929901,
        ///<summary> A color described as Forest with a HEX value of <c>#0B5509</c>.
        Forest = 0x0B5509,
        ///<summary> A color described as Barney Purple with a HEX value of <c>#A00498</c>.
        BarneyPurple = 0xA00498,
        ///<summary> A color described as Ultramarine with a HEX value of <c>#2000B1</c>.
        Ultramarine = 0x2000B1,
        ///<summary> A color described as Purplish with a HEX value of <c>#94568C</c>.
        Purplish = 0x94568C,
        ///<summary> A color described as Puke Yellow with a HEX value of <c>#C2BE0E</c>.
        PukeYellow = 0xC2BE0E,
        ///<summary> A color described as Bluish Grey with a HEX value of <c>#748B97</c>.
        BluishGrey = 0x748B97,
        ///<summary> A color described as Dark Periwinkle with a HEX value of <c>#665FD1</c>.
        DarkPeriwinkle = 0x665FD1,
        ///<summary> A color described as Dark Lilac with a HEX value of <c>#9C6DA5</c>.
        DarkLilac = 0x9C6DA5,
        ///<summary> A color described as Reddish with a HEX value of <c>#C44240</c>.
        Reddish = 0xC44240,
        ///<summary> A color described as Light Maroon with a HEX value of <c>#A24857</c>.
        LightMaroon = 0xA24857,
        ///<summary> A color described as Dusty Purple with a HEX value of <c>#825F87</c>.
        DustyPurple = 0x825F87,
        ///<summary> A color described as Terra Cotta with a HEX value of <c>#C9643B</c>.
        TerraCotta = 0xC9643B,
        ///<summary> A color described as Avocado with a HEX value of <c>#90B134</c>.
        Avocado = 0x90B134,
        ///<summary> A color described as Marine Blue with a HEX value of <c>#01386A</c>.
        MarineBlue = 0x01386A,
        ///<summary> A color described as Teal Green with a HEX value of <c>#25A36F</c>.
        TealGreen = 0x25A36F,
        ///<summary> A color described as Slate Grey with a HEX value of <c>#59656D</c>.
        SlateGrey = 0x59656D,
        ///<summary> A color described as Lighter Green with a HEX value of <c>#75FD63</c>.
        LighterGreen = 0x75FD63,
        ///<summary> A color described as Electric Green with a HEX value of <c>#21FC0D</c>.
        ElectricGreen = 0x21FC0D,
        ///<summary> A color described as Dusty Blue with a HEX value of <c>#5A86AD</c>.
        DustyBlue = 0x5A86AD,
        ///<summary> A color described as Golden Yellow with a HEX value of <c>#FEC615</c>.
        GoldenYellow = 0xFEC615,
        ///<summary> A color described as Bright Yellow with a HEX value of <c>#FFFD01</c>.
        BrightYellow = 0xFFFD01,
        ///<summary> A color described as Light Lavender with a HEX value of <c>#DFC5FE</c>.
        LightLavender = 0xDFC5FE,
        ///<summary> A color described as Umber with a HEX value of <c>#B26400</c>.
        Umber = 0xB26400,
        ///<summary> A color described as Poop with a HEX value of <c>#7F5E00</c>.
        Poop = 0x7F5E00,
        ///<summary> A color described as Dark Peach with a HEX value of <c>#DE7E5D</c>.
        DarkPeach = 0xDE7E5D,
        ///<summary> A color described as Jungle Green with a HEX value of <c>#048243</c>.
        JungleGreen = 0x048243,
        ///<summary> A color described as Eggshell with a HEX value of <c>#FFFFD4</c>.
        Eggshell = 0xFFFFD4,
        ///<summary> A color described as Denim with a HEX value of <c>#3B638C</c>.
        Denim = 0x3B638C,
        ///<summary> A color described as Yellow Brown with a HEX value of <c>#B79400</c>.
        YellowBrown = 0xB79400,
        ///<summary> A color described as Dull Purple with a HEX value of <c>#84597E</c>.
        DullPurple = 0x84597E,
        ///<summary> A color described as Chocolate Brown with a HEX value of <c>#411900</c>.
        ChocolateBrown = 0x411900,
        ///<summary> A color described as Wine Red with a HEX value of <c>#7B0323</c>.
        WineRed = 0x7B0323,
        ///<summary> A color described as Neon Blue with a HEX value of <c>#04D9FF</c>.
        NeonBlue = 0x04D9FF,
        ///<summary> A color described as Dirty Green with a HEX value of <c>#667E2C</c>.
        DirtyGreen = 0x667E2C,
        ///<summary> A color described as Light Tan with a HEX value of <c>#FBEEAC</c>.
        LightTan = 0xFBEEAC,
        ///<summary> A color described as Ice Blue with a HEX value of <c>#D7FFFE</c>.
        IceBlue = 0xD7FFFE,
        ///<summary> A color described as Cadet Blue with a HEX value of <c>#4E7496</c>.
        CadetBlue = 0x4E7496,
        ///<summary> A color described as Dark Mauve with a HEX value of <c>#874C62</c>.
        DarkMauve = 0x874C62,
        ///<summary> A color described as Very Light Blue with a HEX value of <c>#D5FFFF</c>.
        VeryLightBlue = 0xD5FFFF,
        ///<summary> A color described as Grey Purple with a HEX value of <c>#826D8C</c>.
        GreyPurple = 0x826D8C,
        ///<summary> A color described as Pastel Pink with a HEX value of <c>#FFBACD</c>.
        PastelPink = 0xFFBACD,
        ///<summary> A color described as Very Light Green with a HEX value of <c>#D1FFBD</c>.
        VeryLightGreen = 0xD1FFBD,
        ///<summary> A color described as Dark Sky Blue with a HEX value of <c>#448EE4</c>.
        DarkSkyBlue = 0x448EE4,
        ///<summary> A color described as Evergreen with a HEX value of <c>#05472A</c>.
        Evergreen = 0x05472A,
        ///<summary> A color described as Dull Pink with a HEX value of <c>#D5869D</c>.
        DullPink = 0xD5869D,
        ///<summary> A color described as Aubergine with a HEX value of <c>#3D0734</c>.
        Aubergine = 0x3D0734,
        ///<summary> A color described as Mahogany with a HEX value of <c>#4A0100</c>.
        Mahogany = 0x4A0100,
        ///<summary> A color described as Reddish Orange with a HEX value of <c>#F8481C</c>.
        ReddishOrange = 0xF8481C,
        ///<summary> A color described as Deep Green with a HEX value of <c>#02590F</c>.
        DeepGreen = 0x02590F,
        ///<summary> A color described as Vomit Green with a HEX value of <c>#89A203</c>.
        VomitGreen = 0x89A203,
        ///<summary> A color described as Purple Pink with a HEX value of <c>#E03FD8</c>.
        PurplePinkAlternate = 0xE03FD8,
        ///<summary> A color described as Dusty Pink with a HEX value of <c>#D58A94</c>.
        DustyPink = 0xD58A94,
        ///<summary> A color described as Faded Green with a HEX value of <c>#7BB274</c>.
        FadedGreen = 0x7BB274,
        ///<summary> A color described as Camo Green with a HEX value of <c>#526525</c>.
        CamoGreen = 0x526525,
        ///<summary> A color described as Pinky Purple with a HEX value of <c>#C94CBE</c>.
        PinkyPurple = 0xC94CBE,
        ///<summary> A color described as Pink Purple with a HEX value of <c>#DB4BDA</c>.
        PinkPurpleAlternate = 0xDB4BDA,
        ///<summary> A color described as Brownish Red with a HEX value of <c>#9E3623</c>.
        BrownishRed = 0x9E3623,
        ///<summary> A color described as Dark Rose with a HEX value of <c>#B5485D</c>.
        DarkRose = 0xB5485D,
        ///<summary> A color described as Mud with a HEX value of <c>#735C12</c>.
        Mud = 0x735C12,
        ///<summary> A color described as Brownish with a HEX value of <c>#9C6D57</c>.
        Brownish = 0x9C6D57,
        ///<summary> A color described as Emerald Green with a HEX value of <c>#028F1E</c>.
        EmeraldGreen = 0x028F1E,
        ///<summary> A color described as Pale Brown with a HEX value of <c>#B1916E</c>.
        PaleBrown = 0xB1916E,
        ///<summary> A color described as Dull Blue with a HEX value of <c>#49759C</c>.
        DullBlue = 0x49759C,
        ///<summary> A color described as Burnt Umber with a HEX value of <c>#A0450E</c>.
        BurntUmber = 0xA0450E,
        ///<summary> A color described as Medium Green with a HEX value of <c>#39AD48</c>.
        MediumGreen = 0x39AD48,
        ///<summary> A color described as Clay with a HEX value of <c>#B66A50</c>.
        Clay = 0xB66A50,
        ///<summary> A color described as Light Aqua with a HEX value of <c>#8CFFDB</c>.
        LightAqua = 0x8CFFDB,
        ///<summary> A color described as Light Olive Green with a HEX value of <c>#A4BE5C</c>.
        LightOliveGreen = 0xA4BE5C,
        ///<summary> A color described as Brownish Orange with a HEX value of <c>#CB7723</c>.
        BrownishOrange = 0xCB7723,
        ///<summary> A color described as Dark Aqua with a HEX value of <c>#05696B</c>.
        DarkAqua = 0x05696B,
        ///<summary> A color described as Purplish Pink with a HEX value of <c>#CE5DAE</c>.
        PurplishPink = 0xCE5DAE,
        ///<summary> A color described as Dark Salmon with a HEX value of <c>#C85A53</c>.
        DarkSalmon = 0xC85A53,
        ///<summary> A color described as Greenish Grey with a HEX value of <c>#96AE8D</c>.
        GreenishGrey = 0x96AE8D,
        ///<summary> A color described as Jade with a HEX value of <c>#1FA774</c>.
        Jade = 0x1FA774,
        ///<summary> A color described as Ugly Green with a HEX value of <c>#7A9703</c>.
        UglyGreen = 0x7A9703,
        ///<summary> A color described as Dark Beige with a HEX value of <c>#AC9362</c>.
        DarkBeige = 0xAC9362,
        ///<summary> A color described as Emerald with a HEX value of <c>#01A049</c>.
        Emerald = 0x01A049,
        ///<summary> A color described as Pale Red with a HEX value of <c>#D9544D</c>.
        PaleRed = 0xD9544D,
        ///<summary> A color described as Light Magenta with a HEX value of <c>#FA5FF7</c>.
        LightMagenta = 0xFA5FF7,
        ///<summary> A color described as Sky with a HEX value of <c>#82CAFC</c>.
        Sky = 0x82CAFC,
        ///<summary> A color described as Light Cyan with a HEX value of <c>#ACFFFC</c>.
        LightCyan = 0xACFFFC,
        ///<summary> A color described as Yellow Orange with a HEX value of <c>#FCB001</c>.
        YellowOrange = 0xFCB001,
        ///<summary> A color described as Reddish Purple with a HEX value of <c>#910951</c>.
        ReddishPurple = 0x910951,
        ///<summary> A color described as Reddish Pink with a HEX value of <c>#FE2C54</c>.
        ReddishPink = 0xFE2C54,
        ///<summary> A color described as Orchid with a HEX value of <c>#C875C4</c>.
        Orchid = 0xC875C4,
        ///<summary> A color described as Dirty Yellow with a HEX value of <c>#CDC50A</c>.
        DirtyYellow = 0xCDC50A,
        ///<summary> A color described as Orange Red with a HEX value of <c>#FD411E</c>.
        OrangeRed = 0xFD411E,
        ///<summary> A color described as Deep Red with a HEX value of <c>#9A0200</c>.
        DeepRed = 0x9A0200,
        ///<summary> A color described as Orange Brown with a HEX value of <c>#BE6400</c>.
        OrangeBrown = 0xBE6400,
        ///<summary> A color described as Cobalt Blue with a HEX value of <c>#030AA7</c>.
        CobaltBlue = 0x030AA7,
        ///<summary> A color described as Neon Pink with a HEX value of <c>#FE019A</c>.
        NeonPink = 0xFE019A,
        ///<summary> A color described as Rose Pink with a HEX value of <c>#F7879A</c>.
        RosePink = 0xF7879A,
        ///<summary> A color described as Greyish Purple with a HEX value of <c>#887191</c>.
        GreyishPurple = 0x887191,
        ///<summary> A color described as Raspberry with a HEX value of <c>#B00149</c>.
        Raspberry = 0xB00149,
        ///<summary> A color described as Aqua Green with a HEX value of <c>#12E193</c>.
        AquaGreen = 0x12E193,
        ///<summary> A color described as Salmon Pink with a HEX value of <c>#FE7B7C</c>.
        SalmonPink = 0xFE7B7C,
        ///<summary> A color described as Tangerine with a HEX value of <c>#FF9408</c>.
        Tangerine = 0xFF9408,
        ///<summary> A color described as Brownish Green with a HEX value of <c>#6A6E09</c>.
        BrownishGreen = 0x6A6E09,
        ///<summary> A color described as Red Brown with a HEX value of <c>#8B2E16</c>.
        RedBrown = 0x8B2E16,
        ///<summary> A color described as Greenish Brown with a HEX value of <c>#696112</c>.
        GreenishBrown = 0x696112,
        ///<summary> A color described as Pumpkin with a HEX value of <c>#E17701</c>.
        Pumpkin = 0xE17701,
        ///<summary> A color described as Pine Green with a HEX value of <c>#0A481E</c>.
        PineGreen = 0x0A481E,
        ///<summary> A color described as Charcoal with a HEX value of <c>#343837</c>.
        Charcoal = 0x343837,
        ///<summary> A color described as Baby Pink with a HEX value of <c>#FFB7CE</c>.
        BabyPink = 0xFFB7CE,
        ///<summary> A color described as Cornflower with a HEX value of <c>#6A79F7</c>.
        Cornflower = 0x6A79F7,
        ///<summary> A color described as Blue Violet with a HEX value of <c>#5D06E9</c>.
        BlueViolet = 0x5D06E9,
        ///<summary> A color described as Chocolate with a HEX value of <c>#3D1C02</c>.
        Chocolate = 0x3D1C02,
        ///<summary> A color described as Greyish Green with a HEX value of <c>#82A67D</c>.
        GreyishGreen = 0x82A67D,
        ///<summary> A color described as Scarlet with a HEX value of <c>#BE0119</c>.
        Scarlet = 0xBE0119,
        ///<summary> A color described as Green Yellow with a HEX value of <c>#C9FF27</c>.
        GreenYellowAlternate = 0xC9FF27,
        ///<summary> A color described as Dark Olive with a HEX value of <c>#373E02</c>.
        DarkOlive = 0x373E02,
        ///<summary> A color described as Sienna with a HEX value of <c>#A9561E</c>.
        Sienna = 0xA9561E,
        ///<summary> A color described as Pastel Purple with a HEX value of <c>#CAA0FF</c>.
        PastelPurple = 0xCAA0FF,
        ///<summary> A color described as Terracotta with a HEX value of <c>#CA6641</c>.
        Terracotta = 0xCA6641,
        ///<summary> A color described as Aqua Blue with a HEX value of <c>#02D8E9</c>.
        AquaBlue = 0x02D8E9,
        ///<summary> A color described as Sage Green with a HEX value of <c>#88B378</c>.
        SageGreen = 0x88B378,
        ///<summary> A color described as Blood Red with a HEX value of <c>#980002</c>.
        BloodRed = 0x980002,
        ///<summary> A color described as Deep Pink with a HEX value of <c>#CB0162</c>.
        DeepPink = 0xCB0162,
        ///<summary> A color described as Grass with a HEX value of <c>#5CAC2D</c>.
        Grass = 0x5CAC2D,
        ///<summary> A color described as Moss with a HEX value of <c>#769958</c>.
        Moss = 0x769958,
        ///<summary> A color described as Pastel Blue with a HEX value of <c>#A2BFFE</c>.
        PastelBlue = 0xA2BFFE,
        ///<summary> A color described as Bluish Green with a HEX value of <c>#10A674</c>.
        BluishGreen = 0x10A674,
        ///<summary> A color described as Green Blue with a HEX value of <c>#06B48B</c>.
        GreenBlueAlternate = 0x06B48B,
        ///<summary> A color described as Dark Tan with a HEX value of <c>#AF884A</c>.
        DarkTan = 0xAF884A,
        ///<summary> A color described as Greenish Blue with a HEX value of <c>#0B8B87</c>.
        GreenishBlue = 0x0B8B87,
        ///<summary> A color described as Pale Orange with a HEX value of <c>#FFA756</c>.
        PaleOrange = 0xFFA756,
        ///<summary> A color described as Vomit with a HEX value of <c>#A2A415</c>.
        Vomit = 0xA2A415,
        ///<summary> A color described as Forrest Green with a HEX value of <c>#154406</c>.
        ForrestGreen = 0x154406,
        ///<summary> A color described as Dark Lavender with a HEX value of <c>#856798</c>.
        DarkLavender = 0x856798,
        ///<summary> A color described as Dark Violet with a HEX value of <c>#34013F</c>.
        DarkViolet = 0x34013F,
        ///<summary> A color described as Purple Blue with a HEX value of <c>#632DE9</c>.
        PurpleBlueAlternate = 0x632DE9,
        ///<summary> A color described as Dark Cyan with a HEX value of <c>#0A888A</c>.
        DarkCyan = 0x0A888A,
        ///<summary> A color described as Olive Drab with a HEX value of <c>#6F7632</c>.
        OliveDrab = 0x6F7632,
        ///<summary> A color described as Pinkish with a HEX value of <c>#D46A7E</c>.
        Pinkish = 0xD46A7E,
        ///<summary> A color described as Cobalt with a HEX value of <c>#1E488F</c>.
        Cobalt = 0x1E488F,
        ///<summary> A color described as Neon Purple with a HEX value of <c>#BC13FE</c>.
        NeonPurple = 0xBC13FE,
        ///<summary> A color described as Light Turquoise with a HEX value of <c>#7EF4CC</c>.
        LightTurquoise = 0x7EF4CC,
        ///<summary> A color described as Apple Green with a HEX value of <c>#76CD26</c>.
        AppleGreen = 0x76CD26,
        ///<summary> A color described as Dull Green with a HEX value of <c>#74A662</c>.
        DullGreen = 0x74A662,
        ///<summary> A color described as Wine with a HEX value of <c>#80013F</c>.
        Wine = 0x80013F,
        ///<summary> A color described as Powder Blue with a HEX value of <c>#B1D1FC</c>.
        PowderBlue = 0xB1D1FC,
        ///<summary> A color described as Off White with a HEX value of <c>#FFFFE4</c>.
        OffWhite = 0xFFFFE4,
        ///<summary> A color described as Electric Blue with a HEX value of <c>#0652FF</c>.
        ElectricBlue = 0x0652FF,
        ///<summary> A color described as Dark Turquoise with a HEX value of <c>#045C5A</c>.
        DarkTurquoise = 0x045C5A,
        ///<summary> A color described as Blue Purple with a HEX value of <c>#5729CE</c>.
        BluePurpleAlternate = 0x5729CE,
        ///<summary> A color described as Azure with a HEX value of <c>#069AF3</c>.
        Azure = 0x069AF3,
        ///<summary> A color described as Bright Red with a HEX value of <c>#FF000D</c>.
        BrightRed = 0xFF000D,
        ///<summary> A color described as Pinkish Red with a HEX value of <c>#F10C45</c>.
        PinkishRed = 0xF10C45,
        ///<summary> A color described as Cornflower Blue with a HEX value of <c>#5170D7</c>.
        CornflowerBlue = 0x5170D7,
        ///<summary> A color described as Light Olive with a HEX value of <c>#ACBF69</c>.
        LightOlive = 0xACBF69,
        ///<summary> A color described as Grape with a HEX value of <c>#6C3461</c>.
        Grape = 0x6C3461,
        ///<summary> A color described as Greyish Blue with a HEX value of <c>#5E819D</c>.
        GreyishBlue = 0x5E819D,
        ///<summary> A color described as Purplish Blue with a HEX value of <c>#601EF9</c>.
        PurplishBlue = 0x601EF9,
        ///<summary> A color described as Yellowish Green with a HEX value of <c>#B0DD16</c>.
        YellowishGreen = 0xB0DD16,
        ///<summary> A color described as Greenish Yellow with a HEX value of <c>#CDFD02</c>.
        GreenishYellow = 0xCDFD02,
        ///<summary> A color described as Medium Blue with a HEX value of <c>#2C6FBB</c>.
        MediumBlue = 0x2C6FBB,
        ///<summary> A color described as Dusty Rose with a HEX value of <c>#C0737A</c>.
        DustyRose = 0xC0737A,
        ///<summary> A color described as Light Violet with a HEX value of <c>#D6B4FC</c>.
        LightViolet = 0xD6B4FC,
        ///<summary> A color described as Midnight Blue with a HEX value of <c>#020035</c>.
        MidnightBlue = 0x020035,
        ///<summary> A color described as Bluish Purple with a HEX value of <c>#703BE7</c>.
        BluishPurple = 0x703BE7,
        ///<summary> A color described as Red Orange with a HEX value of <c>#FD3C06</c>.
        RedOrange = 0xFD3C06,
        ///<summary> A color described as Dark Magenta with a HEX value of <c>#960056</c>.
        DarkMagenta = 0x960056,
        ///<summary> A color described as Greenish with a HEX value of <c>#40A368</c>.
        Greenish = 0x40A368,
        ///<summary> A color described as Ocean Blue with a HEX value of <c>#03719C</c>.
        OceanBlue = 0x03719C,
        ///<summary> A color described as Coral with a HEX value of <c>#FC5A50</c>.
        Coral = 0xFC5A50,
        ///<summary> A color described as Cream with a HEX value of <c>#FFFFC2</c>.
        Cream = 0xFFFFC2,
        ///<summary> A color described as Reddish Brown with a HEX value of <c>#7F2B0A</c>.
        ReddishBrown = 0x7F2B0A,
        ///<summary> A color described as Burnt Sienna with a HEX value of <c>#B04E0F</c>.
        BurntSienna = 0xB04E0F,
        ///<summary> A color described as Brick with a HEX value of <c>#A03623</c>.
        Brick = 0xA03623,
        ///<summary> A color described as Sage with a HEX value of <c>#87AE73</c>.
        Sage = 0x87AE73,
        ///<summary> A color described as Grey Green with a HEX value of <c>#789B73</c>.
        GreyGreenAlternate = 0x789B73,
        ///<summary> A color described as White with a HEX value of <c>#FFFFFF</c>.
        White = 0xFFFFFF,
        ///<summary> A color described as Robin'S Egg Blue with a HEX value of <c>#98EFF9</c>.
        RobinsEggBlue = 0x98EFF9,
        ///<summary> A color described as Moss Green with a HEX value of <c>#658B38</c>.
        MossGreen = 0x658B38,
        ///<summary> A color described as Steel Blue with a HEX value of <c>#5A7D9A</c>.
        SteelBlue = 0x5A7D9A,
        ///<summary> A color described as Eggplant with a HEX value of <c>#380835</c>.
        Eggplant = 0x380835,
        ///<summary> A color described as Light Yellow with a HEX value of <c>#FFFE7A</c>.
        LightYellow = 0xFFFE7A,
        ///<summary> A color described as Leaf Green with a HEX value of <c>#5CA904</c>.
        LeafGreen = 0x5CA904,
        ///<summary> A color described as Light Grey with a HEX value of <c>#D8DCD6</c>.
        LightGrey = 0xD8DCD6,
        ///<summary> A color described as Puke with a HEX value of <c>#A5A502</c>.
        Puke = 0xA5A502,
        ///<summary> A color described as Pinkish Purple with a HEX value of <c>#D648D7</c>.
        PinkishPurple = 0xD648D7,
        ///<summary> A color described as Sea Blue with a HEX value of <c>#047495</c>.
        SeaBlue = 0x047495,
        ///<summary> A color described as Pale Purple with a HEX value of <c>#B790D4</c>.
        PalePurple = 0xB790D4,
        ///<summary> A color described as Slate Blue with a HEX value of <c>#5B7C99</c>.
        SlateBlue = 0x5B7C99,
        ///<summary> A color described as Blue Grey with a HEX value of <c>#607C8E</c>.
        BlueGreyAlternate = 0x607C8E,
        ///<summary> A color described as Hunter Green with a HEX value of <c>#0B4008</c>.
        HunterGreen = 0x0B4008,
        ///<summary> A color described as Fuchsia with a HEX value of <c>#ED0DD9</c>.
        Fuchsia = 0xED0DD9,
        ///<summary> A color described as Crimson with a HEX value of <c>#8C000F</c>.
        Crimson = 0x8C000F,
        ///<summary> A color described as Pale Yellow with a HEX value of <c>#FFFF84</c>.
        PaleYellow = 0xFFFF84,
        ///<summary> A color described as Ochre with a HEX value of <c>#BF9005</c>.
        Ochre = 0xBF9005,
        ///<summary> A color described as Mustard Yellow with a HEX value of <c>#D2BD0A</c>.
        MustardYellow = 0xD2BD0A,
        ///<summary> A color described as Light Red with a HEX value of <c>#FF474C</c>.
        LightRed = 0xFF474C,
        ///<summary> A color described as Cerulean with a HEX value of <c>#0485D1</c>.
        Cerulean = 0x0485D1,
        ///<summary> A color described as Pale Pink with a HEX value of <c>#FFCFDC</c>.
        PalePink = 0xFFCFDC,
        ///<summary> A color described as Deep Blue with a HEX value of <c>#040273</c>.
        DeepBlue = 0x040273,
        ///<summary> A color described as Rust with a HEX value of <c>#A83C09</c>.
        Rust = 0xA83C09,
        ///<summary> A color described as Light Teal with a HEX value of <c>#90E4C1</c>.
        LightTeal = 0x90E4C1,
        ///<summary> A color described as Slate with a HEX value of <c>#516572</c>.
        Slate = 0x516572,
        ///<summary> A color described as Goldenrod with a HEX value of <c>#FAC205</c>.
        Goldenrod = 0xFAC205,
        ///<summary> A color described as Dark Yellow with a HEX value of <c>#D5B60A</c>.
        DarkYellow = 0xD5B60A,
        ///<summary> A color described as Dark Grey with a HEX value of <c>#363737</c>.
        DarkGrey = 0x363737,
        ///<summary> A color described as Army Green with a HEX value of <c>#4B5D16</c>.
        ArmyGreen = 0x4B5D16,
        ///<summary> A color described as Grey Blue with a HEX value of <c>#6B8BA4</c>.
        GreyBlueAlternate = 0x6B8BA4,
        ///<summary> A color described as Seafoam with a HEX value of <c>#80F9AD</c>.
        Seafoam = 0x80F9AD,
        ///<summary> A color described as Puce with a HEX value of <c>#A57E52</c>.
        Puce = 0xA57E52,
        ///<summary> A color described as Spring Green with a HEX value of <c>#A9F971</c>.
        SpringGreen = 0xA9F971,
        ///<summary> A color described as Dark Orange with a HEX value of <c>#C65102</c>.
        DarkOrange = 0xC65102,
        ///<summary> A color described as Sand with a HEX value of <c>#E2CA76</c>.
        Sand = 0xE2CA76,
        ///<summary> A color described as Pastel Green with a HEX value of <c>#B0FF9D</c>.
        PastelGreen = 0xB0FF9D,
        ///<summary> A color described as Mint with a HEX value of <c>#9FFEB0</c>.
        Mint = 0x9FFEB0,
        ///<summary> A color described as Light Orange with a HEX value of <c>#FDAA48</c>.
        LightOrange = 0xFDAA48,
        ///<summary> A color described as Bright Pink with a HEX value of <c>#FE01B1</c>.
        BrightPink = 0xFE01B1,
        ///<summary> A color described as Chartreuse with a HEX value of <c>#C1F80A</c>.
        Chartreuse = 0xC1F80A,
        ///<summary> A color described as Deep Purple with a HEX value of <c>#36013F</c>.
        DeepPurple = 0x36013F,
        ///<summary> A color described as Dark Brown with a HEX value of <c>#341C02</c>.
        DarkBrown = 0x341C02,
        ///<summary> A color described as Taupe with a HEX value of <c>#B9A281</c>.
        Taupe = 0xB9A281,
        ///<summary> A color described as Pea Green with a HEX value of <c>#8EAB12</c>.
        PeaGreen = 0x8EAB12,
        ///<summary> A color described as Puke Green with a HEX value of <c>#9AAE07</c>.
        PukeGreen = 0x9AAE07,
        ///<summary> A color described as Kelly Green with a HEX value of <c>#02AB2E</c>.
        KellyGreen = 0x02AB2E,
        ///<summary> A color described as Seafoam Green with a HEX value of <c>#7AF9AB</c>.
        SeafoamGreen = 0x7AF9AB,
        ///<summary> A color described as Blue Green with a HEX value of <c>#137E6D</c>.
        BlueGreenAlternate = 0x137E6D,
        ///<summary> A color described as Khaki with a HEX value of <c>#AAA662</c>.
        Khaki = 0xAAA662,
        ///<summary> A color described as Burgundy with a HEX value of <c>#610023</c>.
        Burgundy = 0x610023,
        ///<summary> A color described as Dark Teal with a HEX value of <c>#014D4E</c>.
        DarkTeal = 0x014D4E,
        ///<summary> A color described as Brick Red with a HEX value of <c>#8F1402</c>.
        BrickRed = 0x8F1402,
        ///<summary> A color described as Royal Purple with a HEX value of <c>#4B006E</c>.
        RoyalPurple = 0x4B006E,
        ///<summary> A color described as Plum with a HEX value of <c>#580F41</c>.
        Plum = 0x580F41,
        ///<summary> A color described as Mint Green with a HEX value of <c>#8FFF9F</c>.
        MintGreen = 0x8FFF9F,
        ///<summary> A color described as Gold with a HEX value of <c>#DBB40C</c>.
        Gold = 0xDBB40C,
        ///<summary> A color described as Baby Blue with a HEX value of <c>#A2CFFE</c>.
        BabyBlue = 0xA2CFFE,
        ///<summary> A color described as Yellow Green with a HEX value of <c>#C0FB2D</c>.
        YellowGreenAlternate = 0xC0FB2D,
        ///<summary> A color described as Bright Purple with a HEX value of <c>#BE03FD</c>.
        BrightPurple = 0xBE03FD,
        ///<summary> A color described as Dark Red with a HEX value of <c>#840000</c>.
        DarkRed = 0x840000,
        ///<summary> A color described as Pale Blue with a HEX value of <c>#D0FEFE</c>.
        PaleBlue = 0xD0FEFE,
        ///<summary> A color described as Grass Green with a HEX value of <c>#3F9B0B</c>.
        GrassGreen = 0x3F9B0B,
        ///<summary> A color described as Navy with a HEX value of <c>#01153E</c>.
        Navy = 0x01153E,
        ///<summary> A color described as Aquamarine with a HEX value of <c>#04D8B2</c>.
        Aquamarine = 0x04D8B2,
        ///<summary> A color described as Burnt Orange with a HEX value of <c>#C04E01</c>.
        BurntOrange = 0xC04E01,
        ///<summary> A color described as Neon Green with a HEX value of <c>#0CFF0C</c>.
        NeonGreen = 0x0CFF0C,
        ///<summary> A color described as Bright Blue with a HEX value of <c>#0165FC</c>.
        BrightBlue = 0x0165FC,
        ///<summary> A color described as Rose with a HEX value of <c>#CF6275</c>.
        Rose = 0xCF6275,
        ///<summary> A color described as Light Pink with a HEX value of <c>#FFD1DF</c>.
        LightPink = 0xFFD1DF,
        ///<summary> A color described as Mustard with a HEX value of <c>#CEB301</c>.
        Mustard = 0xCEB301,
        ///<summary> A color described as Indigo with a HEX value of <c>#380282</c>.
        Indigo = 0x380282,
        ///<summary> A color described as Lime with a HEX value of <c>#AAFF32</c>.
        Lime = 0xAAFF32,
        ///<summary> A color described as Sea Green with a HEX value of <c>#53FCA1</c>.
        SeaGreen = 0x53FCA1,
        ///<summary> A color described as Periwinkle with a HEX value of <c>#8E82FE</c>.
        Periwinkle = 0x8E82FE,
        ///<summary> A color described as Dark Pink with a HEX value of <c>#CB416B</c>.
        DarkPink = 0xCB416B,
        ///<summary> A color described as Olive Green with a HEX value of <c>#677A04</c>.
        OliveGreen = 0x677A04,
        ///<summary> A color described as Peach with a HEX value of <c>#FFB07C</c>.
        Peach = 0xFFB07C,
        ///<summary> A color described as Pale Green with a HEX value of <c>#C7FDB5</c>.
        PaleGreen = 0xC7FDB5,
        ///<summary> A color described as Light Brown with a HEX value of <c>#AD8150</c>.
        LightBrown = 0xAD8150,
        ///<summary> A color described as Hot Pink with a HEX value of <c>#FF028D</c>.
        HotPink = 0xFF028D,
        ///<summary> A color described as Black with a HEX value of <c>#000000</c>.
        Black = 0x000000,
        ///<summary> A color described as Lilac with a HEX value of <c>#CEA2FD</c>.
        Lilac = 0xCEA2FD,
        ///<summary> A color described as Navy Blue with a HEX value of <c>#001146</c>.
        NavyBlue = 0x001146,
        ///<summary> A color described as Royal Blue with a HEX value of <c>#0504AA</c>.
        RoyalBlue = 0x0504AA,
        ///<summary> A color described as Beige with a HEX value of <c>#E6DAA6</c>.
        Beige = 0xE6DAA6,
        ///<summary> A color described as Salmon with a HEX value of <c>#FF796C</c>.
        Salmon = 0xFF796C,
        ///<summary> A color described as Olive with a HEX value of <c>#6E750E</c>.
        Olive = 0x6E750E,
        ///<summary> A color described as Maroon with a HEX value of <c>#650021</c>.
        Maroon = 0x650021,
        ///<summary> A color described as Bright Green with a HEX value of <c>#01FF07</c>.
        BrightGreen = 0x01FF07,
        ///<summary> A color described as Dark Purple with a HEX value of <c>#35063E</c>.
        DarkPurple = 0x35063E,
        ///<summary> A color described as Mauve with a HEX value of <c>#AE7181</c>.
        Mauve = 0xAE7181,
        ///<summary> A color described as Forest Green with a HEX value of <c>#06470C</c>.
        ForestGreen = 0x06470C,
        ///<summary> A color described as Aqua with a HEX value of <c>#13EAC9</c>.
        Aqua = 0x13EAC9,
        ///<summary> A color described as Cyan with a HEX value of <c>#00FFFF</c>.
        Cyan = 0x00FFFF,
        ///<summary> A color described as Tan with a HEX value of <c>#D1B26F</c>.
        Tan = 0xD1B26F,
        ///<summary> A color described as Dark Blue with a HEX value of <c>#00035B</c>.
        DarkBlue = 0x00035B,
        ///<summary> A color described as Lavender with a HEX value of <c>#C79FEF</c>.
        Lavender = 0xC79FEF,
        ///<summary> A color described as Turquoise with a HEX value of <c>#06C2AC</c>.
        Turquoise = 0x06C2AC,
        ///<summary> A color described as Dark Green with a HEX value of <c>#033500</c>.
        DarkGreen = 0x033500,
        ///<summary> A color described as Violet with a HEX value of <c>#9A0EEA</c>.
        Violet = 0x9A0EEA,
        ///<summary> A color described as Light Purple with a HEX value of <c>#BF77F6</c>.
        LightPurple = 0xBF77F6,
        ///<summary> A color described as Lime Green with a HEX value of <c>#89FE05</c>.
        LimeGreen = 0x89FE05,
        ///<summary> A color described as Grey with a HEX value of <c>#929591</c>.
        Grey = 0x929591,
        ///<summary> A color described as Sky Blue with a HEX value of <c>#75BBFD</c>.
        SkyBlue = 0x75BBFD,
        ///<summary> A color described as Yellow with a HEX value of <c>#FFFF14</c>.
        Yellow = 0xFFFF14,
        ///<summary> A color described as Magenta with a HEX value of <c>#C20078</c>.
        Magenta = 0xC20078,
        ///<summary> A color described as Light Green with a HEX value of <c>#96F97B</c>.
        LightGreen = 0x96F97B,
        ///<summary> A color described as Orange with a HEX value of <c>#F97306</c>.
        Orange = 0xF97306,
        ///<summary> A color described as Teal with a HEX value of <c>#029386</c>.
        Teal = 0x029386,
        ///<summary> A color described as Light Blue with a HEX value of <c>#95D0FC</c>.
        LightBlue = 0x95D0FC,
        ///<summary> A color described as Red with a HEX value of <c>#E50000</c>.
        Red = 0xE50000,
        ///<summary> A color described as Brown with a HEX value of <c>#653700</c>.
        Brown = 0x653700,
        ///<summary> A color described as Pink with a HEX value of <c>#FF81C0</c>.
        Pink = 0xFF81C0,
        ///<summary> A color described as Blue with a HEX value of <c>#0343DF</c>.
        Blue = 0x0343DF,
        ///<summary> A color described as Green with a HEX value of <c>#15B01A</c>.
        Green = 0x15B01A,
        ///<summary> A color described as Purple with a HEX value of <c>#7E1E9C</c>.
        Purple = 0x7E1E9C,
        Purple2 = 0x7E1E9C,

    }
}
