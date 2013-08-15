using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T5
{
    public class HullFittingsData
    {
        public List<HullFittingsLine> Data = new List<HullFittingsLine>();

        public HullFittingsData()
        {
            Data.Add(new HullFittingsLine() { Fitting = "Flotation Hull", Cluster = "Yes", Braced = "Yes", Planetoid = "Yes", Unstreamlined = "Yes", Streamlined = "Yes", AirFrame = "Yes", LiftingBody = "Opt", Comment = " Water Landing and Water Gliding Landing", TechLevel = "5", Tons = "1", MCredits = "1", Code = " D" });
            Data.Add(new HullFittingsLine() { Fitting = "Submergence Hull", Cluster = "Yes", Braced = "Yes", Planetoid = "Yes", Unstreamlined = "Yes", Streamlined = "Yes", AirFrame = "Yes", LiftingBody = "Yes", Comment = " Water Landing and Water Gliding Landing", TechLevel = "6", Tons = "2", MCredits = "2", Code = " E" });
            Data.Add(new HullFittingsLine() { Fitting = "Fins", Cluster = " No", Braced = " No", Planetoid = " No", Unstreamlined = "Yes", Streamlined = "Yes", AirFrame = "Opt", LiftingBody = "Opt", Comment = " Increases Agility in Atmosphere", TechLevel = "5", Tons = "0.5", MCredits = "0.5", Code = " F" });
            Data.Add(new HullFittingsLine() { Fitting = "Folding Fins", Cluster = " No", Braced = " No", Planetoid = " No", Unstreamlined = "Yes", Streamlined = "Yes", AirFrame = "Opt", LiftingBody = "Opt", Comment = " Increases Agility in Atmosphere", TechLevel = "8", Tons = "0", MCredits = "0.5", Code = " G" });
            Data.Add(new HullFittingsLine() { Fitting = "Wings", Cluster = " No", Braced = " No", Planetoid = " No", Unstreamlined = "Yes", Streamlined = "Yes", AirFrame = "Opt", LiftingBody = "Opt", Comment = " Increases performance in Atmos", TechLevel = "7", Tons = "2", MCredits = "1", Code = " W" });
            Data.Add(new HullFittingsLine() { Fitting = "Collapsing Wings", Cluster = " No", Braced = " No", Planetoid = " No", Unstreamlined = "Yes", Streamlined = "Yes", AirFrame = "Opt", LiftingBody = "Opt", Comment = " Increases performance in Atmos", TechLevel = "9", Tons = "1", MCredits = "2", Code = " V" });
            Data.Add(new HullFittingsLine() { Fitting = "Landing Skids (Standard)", Cluster = "Yes", Braced = "Yes", Planetoid = "Yes", Unstreamlined = "Yes", Streamlined = "Yes", AirFrame = "Yes", LiftingBody = "Yes", Comment = " Tarmac Landing", TechLevel = "7", Tons = "", MCredits = "", Code = "" });
            Data.Add(new HullFittingsLine() { Fitting = "Landing Legs with Pads", Cluster = "Yes", Braced = "Yes", Planetoid = "Yes", Unstreamlined = "Yes", Streamlined = "Yes", AirFrame = "Yes", LiftingBody = "Yes", Comment = " Allows Wilderness Landing", TechLevel = "8", Tons = "1", MCredits = "1", Code = " K" });
            Data.Add(new HullFittingsLine() { Fitting = "Landing Wheels", Cluster = "Yes", Braced = "Yes", Planetoid = "Yes", Unstreamlined = "Yes", Streamlined = "Yes", AirFrame = "Yes", LiftingBody = "Yes", Comment = " Allows Glide Landing", TechLevel = "5", Tons = "3", MCredits = "1.5", Code = " M" });
            Data.Add(new HullFittingsLine() { Fitting = "Lifters", Cluster = "Yes", Braced = "Yes", Planetoid = "Yes", Unstreamlined = "Yes", Streamlined = "Yes", AirFrame = "Yes", LiftingBody = "Yes", Comment = " Allows limited hover and move", TechLevel = "8", Tons = "0", MCredits = "1", Code = " Z" });
        }

    }

    public class HullFittingsLine
    {
        public string Fitting;
        public string Cluster;
        public string Braced;
        public string Planetoid;
        public string Unstreamlined;
        public string Streamlined;
        public string AirFrame;
        public string LiftingBody;
        public string Comment;
        public string TechLevel;
        public string Tons;
        public string MCredits;
        public string Code;
    }
}
