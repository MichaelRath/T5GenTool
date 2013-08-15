using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T5
{
    public class HullTonnageData
    {
        public List<HullTonnageLine> Data = new List<HullTonnageLine>();

        public HullTonnageData()
        {
            Data.Add(new HullTonnageLine() { Tons = "100", Cluster = "2", Braced = "3", Planetoid = "1", Unstreamlined = "5", Streamlined = "8", AirFrame = "1", LiftingBody = "16", TotalSquares = "200", TotalCubes = "400", Code = "A" });
            Data.Add(new HullTonnageLine() { Tons = "200", Cluster = "4", Braced = "6", Planetoid = "2", Unstreamlined = "8", Streamlined = "14", AirFrame = "2", LiftingBody = "28", TotalSquares = "400", TotalCubes = "800", Code = "B" });
            Data.Add(new HullTonnageLine() { Tons = "300", Cluster = "6", Braced = "9", Planetoid = "3", Unstreamlined = "11", Streamlined = "20", AirFrame = "3", LiftingBody = "40", TotalSquares = "600", TotalCubes = "1200", Code = "C" });
            Data.Add(new HullTonnageLine() { Tons = "400", Cluster = "8", Braced = "12", Planetoid = "4", Unstreamlined = "14", Streamlined = "26", AirFrame = "4", LiftingBody = "52", TotalSquares = "800", TotalCubes = "1600", Code = "D" });
            Data.Add(new HullTonnageLine() { Tons = "500", Cluster = "10", Braced = "15", Planetoid = "5", Unstreamlined = "17", Streamlined = "32", AirFrame = "5", LiftingBody = "64", TotalSquares = "1000", TotalCubes = "2000", Code = "E" });
            Data.Add(new HullTonnageLine() { Tons = "600", Cluster = "12", Braced = "18", Planetoid = "6", Unstreamlined = "20", Streamlined = "38", AirFrame = "6", LiftingBody = "76", TotalSquares = "1200", TotalCubes = "2400", Code = "F" });
            Data.Add(new HullTonnageLine() { Tons = "700", Cluster = "14", Braced = "21", Planetoid = "7", Unstreamlined = "23", Streamlined = "44", AirFrame = "7", LiftingBody = "88", TotalSquares = "1400", TotalCubes = "2800", Code = "G" });
            Data.Add(new HullTonnageLine() { Tons = "800", Cluster = "16", Braced = "24", Planetoid = "8", Unstreamlined = "26", Streamlined = "50", AirFrame = "8", LiftingBody = "100", TotalSquares = "1600", TotalCubes = "3200", Code = "H" });
            Data.Add(new HullTonnageLine() { Tons = "900", Cluster = "18", Braced = "27", Planetoid = "9", Unstreamlined = "29", Streamlined = "56", AirFrame = "9", LiftingBody = "112", TotalSquares = "1800", TotalCubes = "3600", Code = "J" });
            Data.Add(new HullTonnageLine() { Tons = "1000", Cluster = "20", Braced = "30", Planetoid = "10", Unstreamlined = "32", Streamlined = "62", AirFrame = "10", LiftingBody = "124", TotalSquares = "2000", TotalCubes = "4000", Code = "K" });
            Data.Add(new HullTonnageLine() { Tons = "1100", Cluster = "22", Braced = "33", Planetoid = "11", Unstreamlined = "35", Streamlined = "68", AirFrame = "11", LiftingBody = "136", TotalSquares = "2200", TotalCubes = "4400", Code = "L" });
            Data.Add(new HullTonnageLine() { Tons = "1200", Cluster = "24", Braced = "36", Planetoid = "12", Unstreamlined = "38", Streamlined = "74", AirFrame = "12", LiftingBody = "148", TotalSquares = "2400", TotalCubes = "4800", Code = "M" });
            Data.Add(new HullTonnageLine() { Tons = "1300", Cluster = "26", Braced = "39", Planetoid = "13", Unstreamlined = "41", Streamlined = "80", AirFrame = "13", LiftingBody = "160", TotalSquares = "2600", TotalCubes = "5200", Code = "N" });
            Data.Add(new HullTonnageLine() { Tons = "1400", Cluster = "28", Braced = "42", Planetoid = "14", Unstreamlined = "44", Streamlined = "86", AirFrame = "14", LiftingBody = "172", TotalSquares = "2800", TotalCubes = "5600", Code = "P" });
            Data.Add(new HullTonnageLine() { Tons = "1500", Cluster = "30", Braced = "45", Planetoid = "15", Unstreamlined = "47", Streamlined = "92", AirFrame = "15", LiftingBody = "184", TotalSquares = "3000", TotalCubes = "6000", Code = "Q" });
            Data.Add(new HullTonnageLine() { Tons = "1600", Cluster = "32", Braced = "48", Planetoid = "16", Unstreamlined = "50", Streamlined = "98", AirFrame = "16", LiftingBody = "196", TotalSquares = "3200", TotalCubes = "6400", Code = "R" });
            Data.Add(new HullTonnageLine() { Tons = "1700", Cluster = "34", Braced = "51", Planetoid = "17", Unstreamlined = "53", Streamlined = "104", AirFrame = "17", LiftingBody = "208", TotalSquares = "3400", TotalCubes = "6800", Code = "S" });
            Data.Add(new HullTonnageLine() { Tons = "1800", Cluster = "36", Braced = "54", Planetoid = "18", Unstreamlined = "56", Streamlined = "110", AirFrame = "18", LiftingBody = "220", TotalSquares = "3600", TotalCubes = "7200", Code = "T" });
            Data.Add(new HullTonnageLine() { Tons = "1900", Cluster = "38", Braced = "57", Planetoid = "19", Unstreamlined = "59", Streamlined = "116", AirFrame = "19", LiftingBody = "232", TotalSquares = "3800", TotalCubes = "7600", Code = "U" });
            Data.Add(new HullTonnageLine() { Tons = "2000", Cluster = "40", Braced = "60", Planetoid = "20", Unstreamlined = "62", Streamlined = "122", AirFrame = "20", LiftingBody = "244", TotalSquares = "4000", TotalCubes = "8000", Code = "V" });
            Data.Add(new HullTonnageLine() { Tons = "2100", Cluster = "42", Braced = "63", Planetoid = "21", Unstreamlined = "65", Streamlined = "128", AirFrame = "21", LiftingBody = "256", TotalSquares = "4200", TotalCubes = "8400", Code = "W" });
            Data.Add(new HullTonnageLine() { Tons = "2200", Cluster = "44", Braced = "66", Planetoid = "22", Unstreamlined = "68", Streamlined = "134", AirFrame = "22", LiftingBody = "268", TotalSquares = "4400", TotalCubes = "8800", Code = "X" });
            Data.Add(new HullTonnageLine() { Tons = "2300", Cluster = "46", Braced = "69", Planetoid = "23", Unstreamlined = "71", Streamlined = "140", AirFrame = "23", LiftingBody = "280", TotalSquares = "4600", TotalCubes = "9200", Code = "Y" });
            Data.Add(new HullTonnageLine() { Tons = "2400", Cluster = "48", Braced = "72", Planetoid = "24", Unstreamlined = "74", Streamlined = "146", AirFrame = "24", LiftingBody = "292", TotalSquares = "4800", TotalCubes = "9600", Code = "Z" });

        }
    }

    public class PodTonnageData
    {
        public List<HullTonnageLine> Data = new List<HullTonnageLine>();

        public PodTonnageData()
        {
            Data.Add(new HullTonnageLine() { Tons = "10", Cluster = "200", Braced = "300", Planetoid = "100", Unstreamlined = "500", Streamlined = "800", AirFrame = "800", LiftingBody = "1600", TotalSquares = "20", TotalCubes = "40", Code = "A1" });
            Data.Add(new HullTonnageLine() { Tons = "20", Cluster = "400", Braced = "600", Planetoid = "200", Unstreamlined = "800", Streamlined = "1400", AirFrame = "1400", LiftingBody = "2800", TotalSquares = "40", TotalCubes = "80", Code = "A2" });
            Data.Add(new HullTonnageLine() { Tons = "30", Cluster = "600", Braced = "900", Planetoid = "300", Unstreamlined = "1100", Streamlined = "2000", AirFrame = "2000", LiftingBody = "4000", TotalSquares = "60", TotalCubes = "120", Code = "A3" });
            Data.Add(new HullTonnageLine() { Tons = "40", Cluster = "800", Braced = "1200", Planetoid = "400", Unstreamlined = "1400", Streamlined = "2600", AirFrame = "2600", LiftingBody = "5200", TotalSquares = "80", TotalCubes = "160", Code = "A4" });
            Data.Add(new HullTonnageLine() { Tons = "50", Cluster = "1100", Braced = "1600", Planetoid = "500", Unstreamlined = "1700", Streamlined = "3200", AirFrame = "3200", LiftingBody = "4600", TotalSquares = "100", TotalCubes = "200", Code = "A5" });
            Data.Add(new HullTonnageLine() { Tons = "60", Cluster = "1300", Braced = "1900", Planetoid = "600", Unstreamlined = "2000", Streamlined = "3700", AirFrame = "3700", LiftingBody = "7600", TotalSquares = "120", TotalCubes = "240", Code = "A6" });
            Data.Add(new HullTonnageLine() { Tons = "70", Cluster = "1500", Braced = "2200", Planetoid = "700", Unstreamlined = "2300", Streamlined = "4400", AirFrame = "4400", LiftingBody = "8800", TotalSquares = "140", TotalCubes = "280", Code = "A7" });
            Data.Add(new HullTonnageLine() { Tons = "80", Cluster = "1700", Braced = "2500", Planetoid = "800", Unstreamlined = "2600", Streamlined = "5000", AirFrame = "5000", LiftingBody = "10000", TotalSquares = "160", TotalCubes = "320", Code = "A8" });
            Data.Add(new HullTonnageLine() { Tons = "90", Cluster = "2000", Braced = "2900", Planetoid = "900", Unstreamlined = "2900", Streamlined = "5600", AirFrame = "5600", LiftingBody = "11200", TotalSquares = "180", TotalCubes = "360", Code = "A9" });
        }

    }


    public class HullTonnageLine
    {
        public string Tons;
        public string Cluster;
        public string Braced;
        public string Planetoid;
        public string Unstreamlined;
        public string Streamlined;
        public string AirFrame;
        public string LiftingBody;
        public string TotalSquares;
        public string TotalCubes;
        public string Code;
    }


}
