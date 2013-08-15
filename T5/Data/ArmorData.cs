using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T5.Data
{


    public class ArmorData
    {
        public List<HullArmorLayersLine> HullArmorData = new List<HullArmorLayersLine>();
        public List<ArmorLayersLine> ArmorLayerData = new List<ArmorLayersLine>();
        public List<ArmorAntiLayersLine> AntiLayerData = new List<ArmorAntiLayersLine>();
        public List<ArmorCoatingsLine> CoatingData = new List<ArmorCoatingsLine>();
        public List<ArmorTechLevelStageEffectsLine> TLEffectsData = new List<ArmorTechLevelStageEffectsLine>();

        public ArmorData()
        {
            HullArmorData.Add(new HullArmorLayersLine() { Tons = "100", Layer2 = "4", Layer3 = "8", Layer4 = "12", Layer5 = "16", Layer6 = "20", Layer7 = "24", Layer8 = "28", Layer9 = "32", Code = "A" });
            HullArmorData.Add(new HullArmorLayersLine() { Tons = "200", Layer2 = "8", Layer3 = "16", Layer4 = "24", Layer5 = "32", Layer6 = "40", Layer7 = "48", Layer8 = "56", Layer9 = "64", Code = "B" });
            HullArmorData.Add(new HullArmorLayersLine() { Tons = "300", Layer2 = "12", Layer3 = "24", Layer4 = "36", Layer5 = "48", Layer6 = "60", Layer7 = "72", Layer8 = "84", Layer9 = "96", Code = "C" });
            HullArmorData.Add(new HullArmorLayersLine() { Tons = "400", Layer2 = "16", Layer3 = "32", Layer4 = "48", Layer5 = "64", Layer6 = "80", Layer7 = "96", Layer8 = "112", Layer9 = "128", Code = "D" });
            HullArmorData.Add(new HullArmorLayersLine() { Tons = "500", Layer2 = "20", Layer3 = "40", Layer4 = "60", Layer5 = "80", Layer6 = "100", Layer7 = "120", Layer8 = "140", Layer9 = "160", Code = "E" });
            HullArmorData.Add(new HullArmorLayersLine() { Tons = "600", Layer2 = "24", Layer3 = "48", Layer4 = "72", Layer5 = "96", Layer6 = "120", Layer7 = "144", Layer8 = "168", Layer9 = "192", Code = "F" });
            HullArmorData.Add(new HullArmorLayersLine() { Tons = "700", Layer2 = "28", Layer3 = "56", Layer4 = "84", Layer5 = "112", Layer6 = "140", Layer7 = "168", Layer8 = "196", Layer9 = "224", Code = "G" });
            HullArmorData.Add(new HullArmorLayersLine() { Tons = "800", Layer2 = "32", Layer3 = "64", Layer4 = "96", Layer5 = "128", Layer6 = "160", Layer7 = "192", Layer8 = "224", Layer9 = "256", Code = "H" });
            HullArmorData.Add(new HullArmorLayersLine() { Tons = "900", Layer2 = "36", Layer3 = "72", Layer4 = "108", Layer5 = "144", Layer6 = "180", Layer7 = "216", Layer8 = "252", Layer9 = "288", Code = "J" });
            HullArmorData.Add(new HullArmorLayersLine() { Tons = "1000", Layer2 = "40", Layer3 = "80", Layer4 = "120", Layer5 = "160", Layer6 = "200", Layer7 = "240", Layer8 = "280", Layer9 = "320", Code = "K" });
            HullArmorData.Add(new HullArmorLayersLine() { Tons = "1100", Layer2 = "44", Layer3 = "88", Layer4 = "132", Layer5 = "176", Layer6 = "220", Layer7 = "264", Layer8 = "308", Layer9 = "352", Code = "L" });
            HullArmorData.Add(new HullArmorLayersLine() { Tons = "1200", Layer2 = "48", Layer3 = "96", Layer4 = "144", Layer5 = "192", Layer6 = "240", Layer7 = "288", Layer8 = "336", Layer9 = "384", Code = "M" });
            HullArmorData.Add(new HullArmorLayersLine() { Tons = "1300", Layer2 = "52", Layer3 = "104", Layer4 = "156", Layer5 = "208", Layer6 = "260", Layer7 = "312", Layer8 = "364", Layer9 = "416", Code = "N" });
            HullArmorData.Add(new HullArmorLayersLine() { Tons = "1400", Layer2 = "56", Layer3 = "112", Layer4 = "168", Layer5 = "224", Layer6 = "280", Layer7 = "336", Layer8 = "392", Layer9 = "448", Code = "P" });
            HullArmorData.Add(new HullArmorLayersLine() { Tons = "1500", Layer2 = "60", Layer3 = "120", Layer4 = "180", Layer5 = "240", Layer6 = "300", Layer7 = "360", Layer8 = "420", Layer9 = "480", Code = "Q" });
            HullArmorData.Add(new HullArmorLayersLine() { Tons = "1600", Layer2 = "64", Layer3 = "128", Layer4 = "192", Layer5 = "256", Layer6 = "320", Layer7 = "384", Layer8 = "448", Layer9 = "512", Code = "R" });
            HullArmorData.Add(new HullArmorLayersLine() { Tons = "1700", Layer2 = "68", Layer3 = "136", Layer4 = "204", Layer5 = "272", Layer6 = "340", Layer7 = "408", Layer8 = "476", Layer9 = "544", Code = "S" });
            HullArmorData.Add(new HullArmorLayersLine() { Tons = "1800", Layer2 = "72", Layer3 = "144", Layer4 = "216", Layer5 = "288", Layer6 = "360", Layer7 = "432", Layer8 = "504", Layer9 = "576", Code = "T" });
            HullArmorData.Add(new HullArmorLayersLine() { Tons = "1900", Layer2 = "76", Layer3 = "152", Layer4 = "228", Layer5 = "304", Layer6 = "380", Layer7 = "456", Layer8 = "532", Layer9 = "608", Code = "U" });
            HullArmorData.Add(new HullArmorLayersLine() { Tons = "2000", Layer2 = "80", Layer3 = "160", Layer4 = "240", Layer5 = "320", Layer6 = "400", Layer7 = "480", Layer8 = "560", Layer9 = "640", Code = "V" });
            HullArmorData.Add(new HullArmorLayersLine() { Tons = "2100", Layer2 = "84", Layer3 = "168", Layer4 = "252", Layer5 = "336", Layer6 = "420", Layer7 = "504", Layer8 = "588", Layer9 = "672", Code = "W" });
            HullArmorData.Add(new HullArmorLayersLine() { Tons = "2200", Layer2 = "88", Layer3 = "176", Layer4 = "264", Layer5 = "352", Layer6 = "440", Layer7 = "528", Layer8 = "616", Layer9 = "704", Code = "X" });
            HullArmorData.Add(new HullArmorLayersLine() { Tons = "2300", Layer2 = "92", Layer3 = "184", Layer4 = "276", Layer5 = "368", Layer6 = "460", Layer7 = "552", Layer8 = "644", Layer9 = "736", Code = "Y" });
            HullArmorData.Add(new HullArmorLayersLine() { Tons = "2400", Layer2 = "96", Layer3 = "192", Layer4 = "288", Layer5 = "384", Layer6 = "480", Layer7 = "576", Layer8 = "672", Layer9 = "768", Code = "Z" });

            ArmorLayerData.Add(new ArmorLayersLine() { ArmorType = "Plate", Configuration = "CBUS", TechLevel = "8", ArmorValue = "8", ArmorValueFormula = "TL", Code = "A" });
            ArmorLayerData.Add(new ArmorLayersLine() { ArmorType = "Shell", Configuration = "SAL", TechLevel = "9", ArmorValue = "5", ArmorValueFormula = "TL/2", Code = "S" });
            ArmorLayerData.Add(new ArmorLayersLine() { ArmorType = "Polymer", Configuration = "CBUSA", TechLevel = "10", ArmorValue = "5", ArmorValueFormula = "TL/2", Code = "P" });
            ArmorLayerData.Add(new ArmorLayersLine() { ArmorType = "FeN", Configuration = "PU", TechLevel = "--", ArmorValue = "20", ArmorValueFormula = "20", Code = "F" });
            ArmorLayerData.Add(new ArmorLayersLine() { ArmorType = "Organic", Configuration = "CBPUSA", TechLevel = "12", ArmorValue = "6", ArmorValueFormula = "TL/2", Code = "O" });
            ArmorLayerData.Add(new ArmorLayersLine() { ArmorType = "Charged", Configuration = "CBUS", TechLevel = "14", ArmorValue = "28", ArmorValueFormula = "TLx2", Code = "C" });

            AntiLayerData.Add(new ArmorAntiLayersLine() { AntiType = " Anti-Blast", Effect = "vs Blast Bullet Frag", Mutliplier = "x10", Code = "B" });
            AntiLayerData.Add(new ArmorAntiLayersLine() { AntiType = " Anti-Kinetic", Effect = "vs Pen", Mutliplier = "x10", Code = "K" });
            AntiLayerData.Add(new ArmorAntiLayersLine() { AntiType = " Anti-EMP", Effect = "vs EMP", Mutliplier = "x10", Code = "E" });
            AntiLayerData.Add(new ArmorAntiLayersLine() { AntiType = " Anti-Rad", Effect = "vs Rad", Mutliplier = "x10", Code = "R" });
            AntiLayerData.Add(new ArmorAntiLayersLine() { AntiType = " Anti-Heath", Effect = "vs Heat not Organic/Polymer", Mutliplier = "x100", Code = "H" });
            AntiLayerData.Add(new ArmorAntiLayersLine() { AntiType = " Anti-Pressure", Effect = "vs Pressure not Organic", Mutliplier = "x10", Code = "P" });

            CoatingData.Add(new ArmorCoatingsLine() { CoatingType = "Reflec", Effect = "vs Burn", Multiplier = "x100", Code = "S" });
            CoatingData.Add(new ArmorCoatingsLine() { CoatingType = "Ablat", Effect = "vs Heat", Multiplier = "x100", Code = "T" });
            CoatingData.Add(new ArmorCoatingsLine() { CoatingType = "Slick", Effect = "vs Tractor", Multiplier = "x100", Code = "U" });

            TLEffectsData.Add(new ArmorTechLevelStageEffectsLine() { TechLevel = "Exp", Stage = "Experimental", TLMod = "-3", Tons = "x3", Mod = "/2", Quality = "F" });
            TLEffectsData.Add(new ArmorTechLevelStageEffectsLine() { TechLevel = "Pro", Stage = "Prototype", TLMod = "-2", Tons = "x2", Mod = "-4", Quality = "F" });
            TLEffectsData.Add(new ArmorTechLevelStageEffectsLine() { TechLevel = "Ear", Stage = "Early", TLMod = "-1", Tons = "x2", Mod = "-3", Quality = "F" });
            TLEffectsData.Add(new ArmorTechLevelStageEffectsLine() { TechLevel = "Std", Stage = "Standard", TLMod = "0", Tons = "x1", Mod = "0", Quality = "0" });
            TLEffectsData.Add(new ArmorTechLevelStageEffectsLine() { TechLevel = "Bas", Stage = "Basic", TLMod = "0", Tons = "x1", Mod = "-1", Quality = "0" });
            TLEffectsData.Add(new ArmorTechLevelStageEffectsLine() { TechLevel = "Alt", Stage = "Alternate", TLMod = "0", Tons = "x1", Mod = "1", Quality = "0" });
            TLEffectsData.Add(new ArmorTechLevelStageEffectsLine() { TechLevel = "Imp", Stage = "Improved", TLMod = "1", Tons = "x1", Mod = "2", Quality = "1" });
            TLEffectsData.Add(new ArmorTechLevelStageEffectsLine() { TechLevel = "Gen", Stage = "Generic", TLMod = "1", Tons = "/2", Mod = "-2", Quality = "1" });
            TLEffectsData.Add(new ArmorTechLevelStageEffectsLine() { TechLevel = "Mod", Stage = "Modified", TLMod = "2", Tons = "/2", Mod = "2", Quality = "2" });
            TLEffectsData.Add(new ArmorTechLevelStageEffectsLine() { TechLevel = "Adv", Stage = "Advanced", TLMod = "3", Tons = "/2", Mod = "3", Quality = "3" });
            TLEffectsData.Add(new ArmorTechLevelStageEffectsLine() { TechLevel = "Ult", Stage = "Ultimate", TLMod = "4", Tons = "/2", Mod = "4", Quality = "4" });

        }

    }

    public class HullArmorLayersLine
    {
        public string Tons;
        public string Layer2;
        public string Layer3;
        public string Layer4;
        public string Layer5;
        public string Layer6;
        public string Layer7;
        public string Layer8;
        public string Layer9;
        public string Code;

    }

    public class ArmorLayersLine
    {
        public string ArmorType;
        public string Configuration;
        public string TechLevel;
        public string ArmorValue;
        public string ArmorValueFormula;
        public string Code;
    }

    public class ArmorAntiLayersLine
    {
        public string AntiType;
        public string Effect;
        public string Mutliplier;
        public string Code;
    }

    public class ArmorCoatingsLine
    {
        public string CoatingType;
        public string Effect;
        public string Multiplier;
        public string Code;
    }

    public class ArmorTechLevelStageEffectsLine
    {
        public string TechLevel;
        public string Stage;
        public string TLMod;
        public string Tons;
        public string Mod;
        public string Quality;
    }


}
