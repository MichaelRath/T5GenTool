using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T5
{
    public class ShipMissionData
    {
        private ShipMissionCombo Data;

        public ShipMissionData()
        {
            Data = new ShipMissionCombo();
        }

        public String GetMissionCode(String service, String activity, String sType, String qualifier)
        {
            return  (from d in Data.Data
                             where d.Service.ToLower() == service.ToLower() && d.Activity.ToLower() == activity.ToLower()
                               && d.MissionType.ToLower() == sType.ToLower() && d.Qualifier.ToLower() == qualifier.ToLower()
                             select d.Code).FirstOrDefault();
        }

        public List<String> GetChildren(String service, String activity, String sType, String qualifier)
        {
            List<String> retVal = new List<string>();

            if (service == string.Empty && activity == string.Empty && sType == string.Empty && qualifier == string.Empty)
            {
                retVal = (from d in Data.Data
                          select d.Service).Distinct().ToList();
            }
            else if (service != string.Empty && activity == string.Empty && sType == string.Empty && qualifier == string.Empty)
            {
                retVal = (from d in Data.Data
                          where d.Service.ToLower() == service.ToLower()
                          select d.Activity).Distinct().ToList();
            }
            else if (service != string.Empty && activity != string.Empty && sType == string.Empty && qualifier == string.Empty)
            {
                retVal = (from d in Data.Data
                          where d.Service.ToLower() == service.ToLower() && d.Activity.ToLower() == activity.ToLower()
                          select d.MissionType).Distinct().ToList();
            }
            else if (service != string.Empty && activity != string.Empty && sType != string.Empty && qualifier == string.Empty)
            {
                retVal = (from d in Data.Data
                          where d.Service.ToLower() == service.ToLower() && d.Activity.ToLower() == activity.ToLower()
                            && d.MissionType.ToLower() == sType.ToLower()
                          select d.Qualifier).Distinct().ToList();
            }
            

            return retVal;
        }
    }

    public class ShipMissionCombo
    {
        public List<ShipMissionLine> Data;

        public ShipMissionCombo()
        {
            Data = new List<ShipMissionLine>();
            Data.Add(new ShipMissionLine() { Service = "Naval", Activity = "Combat", MissionType = "Offensive", Qualifier = "Principal", Mission = "Cruiser", Code = "C" });
            Data.Add(new ShipMissionLine() { Service = "Naval", Activity = "Combat", MissionType = "Offensive", Qualifier = "Major", Mission = "Frigate", Code = "G" });
            Data.Add(new ShipMissionLine() { Service = "Naval", Activity = "Combat", MissionType = "Offensive", Qualifier = "Minor", Mission = "Corvette", Code = "E" });
            Data.Add(new ShipMissionLine() { Service = "Naval", Activity = "Combat", MissionType = "Siege", Qualifier = "Attack", Mission = "Ortillery", Code = "H" });
            Data.Add(new ShipMissionLine() { Service = "Naval", Activity = "Combat", MissionType = "Siege", Qualifier = "Invasion", Mission = "Assult", Code = "T" });
            Data.Add(new ShipMissionLine() { Service = "Naval", Activity = "Combat", MissionType = "Siege", Qualifier = "Defender", Mission = "Sentinel", Code = "S" });
            Data.Add(new ShipMissionLine() { Service = "Naval", Activity = "Combat", MissionType = "Defensive", Qualifier = "Minor", Mission = "Excort", Code = "E" });
            Data.Add(new ShipMissionLine() { Service = "Naval", Activity = "Combat", MissionType = "Defensive", Qualifier = "Major", Mission = "Defender", Code = "D" });
            Data.Add(new ShipMissionLine() { Service = "Naval", Activity = "Combat", MissionType = "Defensive", Qualifier = "Principal", Mission = "Monitor", Code = "B" });
            Data.Add(new ShipMissionLine() { Service = "Naval", Activity = "Combat", MissionType = "Independent", Qualifier = "Anti-Shipping", Mission = "Corsair", Code = "P" });
            Data.Add(new ShipMissionLine() { Service = "Naval", Activity = "Combat", MissionType = "Independent", Qualifier = "Anti-Commerce", Mission = "Raider", Code = "R" });
            Data.Add(new ShipMissionLine() { Service = "Naval", Activity = "Combat", MissionType = "Independent", Qualifier = "Anti-Port", Mission = "Marauder", Code = "P" });
            Data.Add(new ShipMissionLine() { Service = "Naval", Activity = "Combat", MissionType = "Independent", Qualifier = "Major", Mission = "Transport", Code = "T" });
            Data.Add(new ShipMissionLine() { Service = "Naval", Activity = "Auxiliary", MissionType = "Supply", Qualifier = "Minor", Mission = "Barge", Code = "W" });
            Data.Add(new ShipMissionLine() { Service = "Naval", Activity = "Auxiliary", MissionType = "Supply", Qualifier = "Resupply", Mission = "Tender, Tug", Code = "T" });
            Data.Add(new ShipMissionLine() { Service = "Naval", Activity = "Auxiliary", MissionType = "Supply", Qualifier = "Information", Mission = "Corvette", Code = "E" });
            Data.Add(new ShipMissionLine() { Service = "Commerce", Activity = "Merchant", MissionType = "Scheduled", Qualifier = "Passenger", Mission = "Liner", Code = "M" });
            Data.Add(new ShipMissionLine() { Service = "Commerce", Activity = "Merchant", MissionType = "Scheduled", Qualifier = "Cargo", Mission = "Merchant", Code = "R" });
            Data.Add(new ShipMissionLine() { Service = "Commerce", Activity = "Merchant", MissionType = "Scheduled", Qualifier = "Freight", Mission = "Freighter", Code = "F" });
            Data.Add(new ShipMissionLine() { Service = "Commerce", Activity = "Merchant", MissionType = "Un-Scheduled", Qualifier = "Freight", Mission = "Transport", Code = "T" });
            Data.Add(new ShipMissionLine() { Service = "Commerce", Activity = "Merchant", MissionType = "Un-Scheduled", Qualifier = "Cargo", Mission = "Trader", Code = "A" });
            Data.Add(new ShipMissionLine() { Service = "Commerce", Activity = "Merchant", MissionType = "Un-Scheduled", Qualifier = "Passenger", Mission = "Packet", Code = "U" });
            Data.Add(new ShipMissionLine() { Service = "Commerce", Activity = "Merchant", MissionType = "Charter", Qualifier = "Recreation", Mission = "Safari", Code = "K" });
            Data.Add(new ShipMissionLine() { Service = "Commerce", Activity = "Merchant", MissionType = "Charter", Qualifier = "Active", Mission = "Expedition", Code = "K" });
            Data.Add(new ShipMissionLine() { Service = "Commerce", Activity = "Merchant", MissionType = "Charter", Qualifier = "Luxury", Mission = "Yacht", Code = "Y" });
            Data.Add(new ShipMissionLine() { Service = "Gov NGO Private", Activity = "Non-Combat", MissionType = "Information", Qualifier = "Small Goods", Mission = "Courier", Code = "S" });
            Data.Add(new ShipMissionLine() { Service = "Gov NGO Private", Activity = "Non-Combat", MissionType = "Information", Qualifier = "Data Files", Mission = "Messenger", Code = "S" });
            Data.Add(new ShipMissionLine() { Service = "Gov NGO Private", Activity = "Non-Combat", MissionType = "Information", Qualifier = "Goods and Files", Mission = "Express", Code = "X" });
            Data.Add(new ShipMissionLine() { Service = "Gov NGO Private", Activity = "Non-Combat", MissionType = "Exploration", Qualifier = "First Look", Mission = "Scout", Code = "S" });
            Data.Add(new ShipMissionLine() { Service = "Gov NGO Private", Activity = "Non-Combat", MissionType = "Exploration", Qualifier = "Re-Look", Mission = "Survey", Code = "N" });
            Data.Add(new ShipMissionLine() { Service = "Gov NGO Private", Activity = "Non-Combat", MissionType = "Exploration", Qualifier = "Data Collection", Mission = "Beagle", Code = "N" });
            Data.Add(new ShipMissionLine() { Service = "Gov NGO Private", Activity = "Non-Combat", MissionType = "Exploration", Qualifier = "Medical Data", Mission = "Med", Code = "N" });
            Data.Add(new ShipMissionLine() { Service = "Gov NGO Private", Activity = "Non-Combat", MissionType = "Exploration", Qualifier = "Data Analysis", Mission = "Lab", Code = "L" });
            Data.Add(new ShipMissionLine() { Service = "Gov NGO Private", Activity = "Non-Combat", MissionType = "Exploration", Qualifier = "Resource Search", Mission = "Prospector", Code = "J" });
            Data.Add(new ShipMissionLine() { Service = "Gov NGO Private", Activity = "Non-Combat", MissionType = "Bureaucratic", Qualifier = "Inspection", Mission = "Picket", Code = "P" });
            Data.Add(new ShipMissionLine() { Service = "Gov NGO Private", Activity = "Non-Combat", MissionType = "Bureaucratic", Qualifier = "Enforcement", Mission = "Patrol", Code = "P" });
            Data.Add(new ShipMissionLine() { Service = "Gov NGO Private", Activity = "Non-Combat", MissionType = "Bureaucratic", Qualifier = "Combat", Mission = "Privateer", Code = "P" });
            Data.Add(new ShipMissionLine() { Service = "Unclassified", Activity = "", MissionType = "", Qualifier = "", Mission = "", Code = "Z" });
        }
    }



    public class ShipMissionLine
    {
        public String Service;
        public String Activity;
        public String MissionType;
        public String Qualifier;
        public String Mission;
        public String Code;
    }

}
