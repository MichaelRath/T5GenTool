using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T5
{
    public class ShipHullData 
    {
        public List<ShipHullLine> Data = new List<ShipHullLine>();

        public ShipHullData()
        {
            Data.Add(new ShipHullLine() { HullType = "Cluster", Friction = "2", Agility = "-5", Accel = "0", MaxG = "1", Stability = "-3", Code = "C", Description = "An accumulation of compartments" });
            Data.Add(new ShipHullLine() { HullType = "Braced", Friction = "2", Agility = "-4", Accel = "0", MaxG = "3", Stability = "-2", Code = "B", Description = "A cluster structured to allow higher acceration" });
            Data.Add(new ShipHullLine() { HullType = "Planetoid", Friction = "1", Agility = "-2", Accel = "0", MaxG = "9", Stability = "-1", Code = "P", Description = "A hollowed nicked-iron asteroid" });
            Data.Add(new ShipHullLine() { HullType = "Unstreamlined", Friction = "0.5", Agility = "-1", Accel = "0", MaxG = "9", Stability = "0", Code = "U", Description = "An enclosure whose protrusions increase drag" });
            Data.Add(new ShipHullLine() { HullType = "Streamlined", Friction = "0.33", Agility = "0", Accel = "0", MaxG = "9", Stability = "1", Code = "S", Description = "An enclosure with cowlings and fairing to decrease drag" });
            Data.Add(new ShipHullLine() { HullType = "Airframe", Friction = "0.25", Agility = "1", Accel = "1", MaxG = "9", Stability = "2", Code = "A", Description = "A winged enclosure for better performance in atmosphere" });
            Data.Add(new ShipHullLine() { HullType = "Lifting Body", Friction = "0.2", Agility = "0", Accel = "1", MaxG = "9", Stability = "3", Code = "L", Description = "A radically streamelined lifting-surface body" });
        }

    }



    public class ShipHullLine
    {
        public string HullType;
        public string Friction;
        public string Agility;
        public string Accel;
        public string MaxG;
        public string Stability;
        public string Code;
        public string Description;
    }


}
