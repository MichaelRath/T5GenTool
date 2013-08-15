using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T5
{
    public class HullStructureData
    {
        public List<HullStructureLine> Data = new List<HullStructureLine>();

        public HullStructureData()
        {
            Data.Add(new HullStructureLine() { StructureType = "Plate", Configuration = "CBUSA", TechLevel = "8", ArmorValue = "8", ArmorValueFormula = "TL", Description = "Standard/Default/Frame" });
            Data.Add(new HullStructureLine() { StructureType = "Shell", Configuration = "SAL", TechLevel = "9", ArmorValue = "5", ArmorValueFormula = "TL/2", Description = "Frameless alloy skin" });
            Data.Add(new HullStructureLine() { StructureType = "Polymer", Configuration = "CBUSA", TechLevel = "10", ArmorValue = "5", ArmorValueFormula = "TL/2", Description = "Specialized plastics. Self-healing" });
            Data.Add(new HullStructureLine() { StructureType = "FeN", Configuration = "PU", TechLevel = "11", ArmorValue = "20", ArmorValueFormula = "", Description = "Hollowed nickel-iron asteroid" });
            Data.Add(new HullStructureLine() { StructureType = "Organic", Configuration = "CBPUSA", TechLevel = "12", ArmorValue = "6", ArmorValueFormula = "TL/2", Description = "Captured or farmed organisns" });
            Data.Add(new HullStructureLine() { StructureType = "Charged", Configuration = "CBUS", TechLevel = "14", ArmorValue = "28", ArmorValueFormula = "TL*2", Description = "Powered imporovement of Plate (AV = TL*2 when charged)" });

        }

    }

    public class HullStructureLine
    {
        public string StructureType;
        public string Configuration;
        public string TechLevel;
        public string ArmorValue;
        public string ArmorValueFormula;
        public string Description;
    }
}
