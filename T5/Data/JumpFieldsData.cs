using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T5
{
    public class JumpFieldsData
    {
        public List<JumpFieldsLine> Data = new List<JumpFieldsLine>();

        public JumpFieldsData()
        {
            Data.Add(new JumpFieldsLine() { JumpFieldType = "Bubble", Cost = "0", FieldStrength = "120", Description = "Default Jump Field", CostFormula = "" });
            Data.Add(new JumpFieldsLine() { JumpFieldType = "Plates", Cost = "KCr / Plate / 10 Hull Tons", FieldStrength = "110", Description = "Less mishap than bubble cheaper than Grid", CostFormula = "" });
            Data.Add(new JumpFieldsLine() { JumpFieldType = "Grid", Cost = "KCr / Hull Tun", FieldStrength = "100", Description = "Embedded in the Hull", CostFormula = "" });
        }
    }

    public class JumpFieldsLine
    {
        public string JumpFieldType;
        public string Cost;
        public string CostFormula;
        public string FieldStrength;
        public string Description;
    }
}
