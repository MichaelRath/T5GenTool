using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T5
{
    public class StarshipDriveData
    {
        public List<StarshipDriveLine> DriveData = new List<StarshipDriveLine>();
        public List<StarshipTLAvailability> TechLevelAvailableData = new List<StarshipTLAvailability>();
        public List<DriveTechLevelEff> DriveEffData = new List<DriveTechLevelEff>();
        public DriveCost DriveCostData = new DriveCost();
        public List<DrivePotential> DrivePotentialData = new List<DrivePotential>();

        public StarshipDriveData()
        {
            DriveData.Add(new StarshipDriveLine() { EP = "100", MDrive = "2", GDrive = "9", NDrive = "2", JDrive = "10", AntiMatter = "31", Collector = "10", Fission = "15", PowerPlant = "4", Code = "A" });
            DriveData.Add(new StarshipDriveLine() { EP = "200", MDrive = "3", GDrive = "18", NDrive = "4", JDrive = "15", AntiMatter = "32", Collector = "20", Fission = "20", PowerPlant = "7", Code = "B" });
            DriveData.Add(new StarshipDriveLine() { EP = "300", MDrive = "5", GDrive = "27", NDrive = "6", JDrive = "20", AntiMatter = "33", Collector = "30", Fission = "25", PowerPlant = "10", Code = "C" });
            DriveData.Add(new StarshipDriveLine() { EP = "400", MDrive = "7", GDrive = "36", NDrive = "8", JDrive = "25", AntiMatter = "34", Collector = "40", Fission = "30", PowerPlant = "13", Code = "D" });
            DriveData.Add(new StarshipDriveLine() { EP = "500", MDrive = "9", GDrive = "45", NDrive = "10", JDrive = "30", AntiMatter = "35", Collector = "50", Fission = "35", PowerPlant = "16", Code = "E" });
            DriveData.Add(new StarshipDriveLine() { EP = "600", MDrive = "11", GDrive = "54", NDrive = "12", JDrive = "35", AntiMatter = "36", Collector = "60", Fission = "40", PowerPlant = "19", Code = "F" });
            DriveData.Add(new StarshipDriveLine() { EP = "700", MDrive = "13", GDrive = "63", NDrive = "14", JDrive = "40", AntiMatter = "37", Collector = "70", Fission = "45", PowerPlant = "22", Code = "G" });
            DriveData.Add(new StarshipDriveLine() { EP = "800", MDrive = "15", GDrive = "72", NDrive = "16", JDrive = "45", AntiMatter = "38", Collector = "80", Fission = "50", PowerPlant = "25", Code = "H" });
            DriveData.Add(new StarshipDriveLine() { EP = "900", MDrive = "17", GDrive = "81", NDrive = "18", JDrive = "50", AntiMatter = "39", Collector = "90", Fission = "55", PowerPlant = "28", Code = "J" });
            DriveData.Add(new StarshipDriveLine() { EP = "1000", MDrive = "19", GDrive = "90", NDrive = "20", JDrive = "55", AntiMatter = "40", Collector = "100", Fission = "60", PowerPlant = "31", Code = "K" });
            DriveData.Add(new StarshipDriveLine() { EP = "1100", MDrive = "21", GDrive = "99", NDrive = "22", JDrive = "60", AntiMatter = "42", Collector = "110", Fission = "65", PowerPlant = "34", Code = "L" });
            DriveData.Add(new StarshipDriveLine() { EP = "1200", MDrive = "23", GDrive = "108", NDrive = "24", JDrive = "65", AntiMatter = "44", Collector = "120", Fission = "70", PowerPlant = "37", Code = "M" });
            DriveData.Add(new StarshipDriveLine() { EP = "1300", MDrive = "25", GDrive = "117", NDrive = "26", JDrive = "70", AntiMatter = "46", Collector = "130", Fission = "75", PowerPlant = "40", Code = "N" });
            DriveData.Add(new StarshipDriveLine() { EP = "1400", MDrive = "27", GDrive = "126", NDrive = "28", JDrive = "75", AntiMatter = "48", Collector = "140", Fission = "80", PowerPlant = "43", Code = "P" });
            DriveData.Add(new StarshipDriveLine() { EP = "1500", MDrive = "29", GDrive = "135", NDrive = "30", JDrive = "80", AntiMatter = "50", Collector = "150", Fission = "85", PowerPlant = "46", Code = "Q" });
            DriveData.Add(new StarshipDriveLine() { EP = "1600", MDrive = "31", GDrive = "144", NDrive = "32", JDrive = "85", AntiMatter = "52", Collector = "160", Fission = "90", PowerPlant = "49", Code = "R" });
            DriveData.Add(new StarshipDriveLine() { EP = "1700", MDrive = "33", GDrive = "153", NDrive = "34", JDrive = "90", AntiMatter = "54", Collector = "170", Fission = "95", PowerPlant = "52", Code = "S" });
            DriveData.Add(new StarshipDriveLine() { EP = "1800", MDrive = "35", GDrive = "162", NDrive = "36", JDrive = "95", AntiMatter = "56", Collector = "180", Fission = "100", PowerPlant = "55", Code = "T" });
            DriveData.Add(new StarshipDriveLine() { EP = "1900", MDrive = "37", GDrive = "171", NDrive = "38", JDrive = "100", AntiMatter = "58", Collector = "190", Fission = "105", PowerPlant = "58", Code = "U" });
            DriveData.Add(new StarshipDriveLine() { EP = "2000", MDrive = "39", GDrive = "180", NDrive = "40", JDrive = "105", AntiMatter = "60", Collector = "200", Fission = "110", PowerPlant = "61", Code = "V" });
            DriveData.Add(new StarshipDriveLine() { EP = "2100", MDrive = "41", GDrive = "189", NDrive = "42", JDrive = "110", AntiMatter = "62", Collector = "210", Fission = "115", PowerPlant = "64", Code = "W" });
            DriveData.Add(new StarshipDriveLine() { EP = "2200", MDrive = "43", GDrive = "198", NDrive = "44", JDrive = "115", AntiMatter = "64", Collector = "220", Fission = "120", PowerPlant = "67", Code = "X" });
            DriveData.Add(new StarshipDriveLine() { EP = "2300", MDrive = "45", GDrive = "207", NDrive = "46", JDrive = "120", AntiMatter = "66", Collector = "230", Fission = "125", PowerPlant = "70", Code = "Y" });
            DriveData.Add(new StarshipDriveLine() { EP = "2400", MDrive = "47", GDrive = "216", NDrive = "48", JDrive = "125", AntiMatter = "68", Collector = "240", Fission = "130", PowerPlant = "73", Code = "Z" });
            DriveData.Add(new StarshipDriveLine() { EP = "2600", MDrive = "50", GDrive = "234", NDrive = "52", JDrive = "140", AntiMatter = "92", Collector = "260", Fission = "150", PowerPlant = "80", Code = "N2" });
            DriveData.Add(new StarshipDriveLine() { EP = "2800", MDrive = "54", GDrive = "252", NDrive = "56", JDrive = "150", AntiMatter = "96", Collector = "280", Fission = "160", PowerPlant = "86", Code = "P2" });
            DriveData.Add(new StarshipDriveLine() { EP = "3000", MDrive = "58", GDrive = "270", NDrive = "60", JDrive = "160", AntiMatter = "100", Collector = "300", Fission = "170", PowerPlant = "92", Code = "Q2" });
            DriveData.Add(new StarshipDriveLine() { EP = "3200", MDrive = "62", GDrive = "288", NDrive = "64", JDrive = "170", AntiMatter = "104", Collector = "320", Fission = "180", PowerPlant = "98", Code = "R2" });
            DriveData.Add(new StarshipDriveLine() { EP = "3400", MDrive = "66", GDrive = "306", NDrive = "68", JDrive = "180", AntiMatter = "108", Collector = "340", Fission = "190", PowerPlant = "104", Code = "S2" });
            DriveData.Add(new StarshipDriveLine() { EP = "3600", MDrive = "70", GDrive = "324", NDrive = "72", JDrive = "190", AntiMatter = "112", Collector = "360", Fission = "200", PowerPlant = "110", Code = "T2" });
            DriveData.Add(new StarshipDriveLine() { EP = "3800", MDrive = "74", GDrive = "342", NDrive = "76", JDrive = "200", AntiMatter = "116", Collector = "380", Fission = "210", PowerPlant = "116", Code = "U2" });
            DriveData.Add(new StarshipDriveLine() { EP = "4000", MDrive = "78", GDrive = "360", NDrive = "80", JDrive = "210", AntiMatter = "120", Collector = "400", Fission = "220", PowerPlant = "122", Code = "V2" });
            DriveData.Add(new StarshipDriveLine() { EP = "4200", MDrive = "82", GDrive = "378", NDrive = "84", JDrive = "220", AntiMatter = "124", Collector = "420", Fission = "230", PowerPlant = "128", Code = "W2" });
            DriveData.Add(new StarshipDriveLine() { EP = "4400", MDrive = "86", GDrive = "396", NDrive = "88", JDrive = "230", AntiMatter = "128", Collector = "440", Fission = "240", PowerPlant = "134", Code = "X2" });
            DriveData.Add(new StarshipDriveLine() { EP = "4600", MDrive = "90", GDrive = "414", NDrive = "92", JDrive = "240", AntiMatter = "132", Collector = "460", Fission = "250", PowerPlant = "140", Code = "Y2" });
            DriveData.Add(new StarshipDriveLine() { EP = "4800", MDrive = "94", GDrive = "432", NDrive = "96", JDrive = "250", AntiMatter = "136", Collector = "480", Fission = "260", PowerPlant = "146", Code = "Z2" });

            TechLevelAvailableData.Add(new StarshipTLAvailability() { DriveType = "Maneuver", TL8 = "-", TL9 = "1", TL10 = "3", TL11 = "5", TL12 = "7", TL13 = "9", TL14 = "-", TL15 = "-", TL16 = "-", TL17 = "-", TL18 = "-", TL19 = "-", TL20 = "-", TL21 = "-", Code = "M" });
            TechLevelAvailableData.Add(new StarshipTLAvailability() { DriveType = "Gravitic", TL8 = "1", TL9 = "4", TL10 = "7", TL11 = "9", TL12 = "-", TL13 = "-", TL14 = "-", TL15 = "-", TL16 = "-", TL17 = "-", TL18 = "-", TL19 = "-", TL20 = "-", TL21 = "-", Code = "G" });
            TechLevelAvailableData.Add(new StarshipTLAvailability() { DriveType = "NAFAL", TL8 = "-", TL9 = "1", TL10 = "4", TL11 = "7", TL12 = "9", TL13 = "-", TL14 = "-", TL15 = "-", TL16 = "-", TL17 = "-", TL18 = "-", TL19 = "-", TL20 = "-", TL21 = "", Code = "N" });
            TechLevelAvailableData.Add(new StarshipTLAvailability() { DriveType = "Jump", TL8 = "-", TL9 = "1", TL10 = "-", TL11 = "2", TL12 = "3", TL13 = "4", TL14 = "5", TL15 = "6", TL16 = "7", TL17 = "8", TL18 = "9", TL19 = "-", TL20 = "-", TL21 = "-", Code = "J" });
            TechLevelAvailableData.Add(new StarshipTLAvailability() { DriveType = "Hop", TL8 = "-", TL9 = "-", TL10 = "-", TL11 = "-", TL12 = "-", TL13 = "-", TL14 = "-", TL15 = "-", TL16 = "-", TL17 = "1", TL18 = "2", TL19 = "3", TL20 = "4", TL21 = "5", Code = "H" });
            TechLevelAvailableData.Add(new StarshipTLAvailability() { DriveType = "Skp", TL8 = "-", TL9 = "-", TL10 = "-", TL11 = "-", TL12 = "-", TL13 = "-", TL14 = "-", TL15 = "-", TL16 = "-", TL17 = "-", TL18 = "-", TL19 = "-", TL20 = "1", TL21 = "2", Code = "S" });
            TechLevelAvailableData.Add(new StarshipTLAvailability() { DriveType = "PowerPlant", TL8 = "1", TL9 = "2", TL10 = "3", TL11 = "4", TL12 = "5", TL13 = "6", TL14 = "7", TL15 = "8", TL16 = "9", TL17 = "-", TL18 = "-", TL19 = "-", TL20 = "-", TL21 = "-", Code = "P" });
            TechLevelAvailableData.Add(new StarshipTLAvailability() { DriveType = "Anti-Matter", TL8 = "-", TL9 = "-", TL10 = "-", TL11 = "-", TL12 = "-", TL13 = "-", TL14 = "-", TL15 = "-", TL16 = "-", TL17 = "-", TL18 = "-", TL19 = "1", TL20 = "2", TL21 = "3", Code = "A" });
            TechLevelAvailableData.Add(new StarshipTLAvailability() { DriveType = "Fission", TL8 = "1", TL9 = "2", TL10 = "3", TL11 = "4", TL12 = "5", TL13 = "6", TL14 = "7", TL15 = "8", TL16 = "9", TL17 = "-", TL18 = "-", TL19 = "-", TL20 = "-", TL21 = "-", Code = "U" });
            TechLevelAvailableData.Add(new StarshipTLAvailability() { DriveType = "Collector", TL8 = "-", TL9 = "-", TL10 = "-", TL11 = "-", TL12 = "-", TL13 = "-", TL14 = "1", TL15 = "2", TL16 = "3", TL17 = "4", TL18 = "5", TL19 = "6", TL20 = "7", TL21 = "8", Code = "C" });

            DriveEffData.Add(new DriveTechLevelEff() { TechLevel = "Exp", Stage = "Experimental", TLMod = "-3", CostMod = "x10", Efficiency = "0.5", FuelConsumptionMod = "2" });
            DriveEffData.Add(new DriveTechLevelEff() { TechLevel = "Pro", Stage = "Prototype", TLMod = "-2", CostMod = "x5", Efficiency = "0.8", FuelConsumptionMod = "1.2" });
            DriveEffData.Add(new DriveTechLevelEff() { TechLevel = "Ear", Stage = "Early", TLMod = "-1", CostMod = "x2", Efficiency = "0.9", FuelConsumptionMod = "1.1" });
            DriveEffData.Add(new DriveTechLevelEff() { TechLevel = "Std", Stage = "Standard", TLMod = "0", CostMod = "x1", Efficiency = "1", FuelConsumptionMod = "1" });
            DriveEffData.Add(new DriveTechLevelEff() { TechLevel = "Bas", Stage = "Basic", TLMod = "0", CostMod = "/2", Efficiency = "0.9", FuelConsumptionMod = "1.1" });
            DriveEffData.Add(new DriveTechLevelEff() { TechLevel = "Alt", Stage = "Alternate", TLMod = "0", CostMod = "x1", Efficiency = "1", FuelConsumptionMod = "1" });
            DriveEffData.Add(new DriveTechLevelEff() { TechLevel = "Imp", Stage = "Improved", TLMod = "1", CostMod = "x1", Efficiency = "1.1", FuelConsumptionMod = "0.9" });
            DriveEffData.Add(new DriveTechLevelEff() { TechLevel = "Gen", Stage = "Generic", TLMod = "1", CostMod = "/2", Efficiency = "0.9", FuelConsumptionMod = "1.1" });
            DriveEffData.Add(new DriveTechLevelEff() { TechLevel = "Mod", Stage = "Modified", TLMod = "2", CostMod = "/2", Efficiency = "1.1", FuelConsumptionMod = "0.9" });
            DriveEffData.Add(new DriveTechLevelEff() { TechLevel = "Adv", Stage = "Advanced", TLMod = "3", CostMod = "x1", Efficiency = "1.2", FuelConsumptionMod = "0.8" });
            DriveEffData.Add(new DriveTechLevelEff() { TechLevel = "Ult", Stage = "Ultimate", TLMod = "4", CostMod = "x2", Efficiency = "1.3", FuelConsumptionMod = "0.7" });

            DrivePotentialData.Add(new DrivePotential() { DriveSize = "A", HullSizeA = "2", HullSizeB = "1", HullSizeC = "no", HullSizeD = "no", HullSizeE = "no", HullSizeF = "no", HullSizeG = "no", HullSizeH = "no", HullSizeJ = "no", HullSizeK = "no", HullSizeL = "no", HullSizeM = "no", HullSizeN = "no", HullSizeP = "no", HullSizeQ = "no", HullSizeR = "no", HullSizeS = "no", HullSizeT = "no", HullSizeU = "no", HullSizeV = "no", HullSizeW = "no", HullSizeX = "no", HullSizeY = "no", HullSizeZ = "no" });
            DrivePotentialData.Add(new DrivePotential() { DriveSize = "B", HullSizeA = "4", HullSizeB = "2", HullSizeC = "1", HullSizeD = "1", HullSizeE = "no", HullSizeF = "no", HullSizeG = "no", HullSizeH = "no", HullSizeJ = "no", HullSizeK = "no", HullSizeL = "no", HullSizeM = "no", HullSizeN = "no", HullSizeP = "no", HullSizeQ = "no", HullSizeR = "no", HullSizeS = "no", HullSizeT = "no", HullSizeU = "no", HullSizeV = "no", HullSizeW = "no", HullSizeX = "no", HullSizeY = "no", HullSizeZ = "no" });
            DrivePotentialData.Add(new DrivePotential() { DriveSize = "C", HullSizeA = "6", HullSizeB = "3", HullSizeC = "2", HullSizeD = "1", HullSizeE = "1", HullSizeF = "1", HullSizeG = "no", HullSizeH = "no", HullSizeJ = "no", HullSizeK = "no", HullSizeL = "no", HullSizeM = "no", HullSizeN = "no", HullSizeP = "no", HullSizeQ = "no", HullSizeR = "no", HullSizeS = "no", HullSizeT = "no", HullSizeU = "no", HullSizeV = "no", HullSizeW = "no", HullSizeX = "no", HullSizeY = "no", HullSizeZ = "no" });
            DrivePotentialData.Add(new DrivePotential() { DriveSize = "D", HullSizeA = "8", HullSizeB = "4", HullSizeC = "2", HullSizeD = "2", HullSizeE = "1", HullSizeF = "1", HullSizeG = "1", HullSizeH = "1", HullSizeJ = "no", HullSizeK = "no", HullSizeL = "no", HullSizeM = "no", HullSizeN = "no", HullSizeP = "no", HullSizeQ = "no", HullSizeR = "no", HullSizeS = "no", HullSizeT = "no", HullSizeU = "no", HullSizeV = "no", HullSizeW = "no", HullSizeX = "no", HullSizeY = "no", HullSizeZ = "no" });
            DrivePotentialData.Add(new DrivePotential() { DriveSize = "E", HullSizeA = "9", HullSizeB = "5", HullSizeC = "3", HullSizeD = "2", HullSizeE = "2", HullSizeF = "1", HullSizeG = "1", HullSizeH = "1", HullSizeJ = "1", HullSizeK = "1", HullSizeL = "no", HullSizeM = "no", HullSizeN = "no", HullSizeP = "no", HullSizeQ = "no", HullSizeR = "no", HullSizeS = "no", HullSizeT = "no", HullSizeU = "no", HullSizeV = "no", HullSizeW = "no", HullSizeX = "no", HullSizeY = "no", HullSizeZ = "no" });
            DrivePotentialData.Add(new DrivePotential() { DriveSize = "F", HullSizeA = "9", HullSizeB = "6", HullSizeC = "4", HullSizeD = "3", HullSizeE = "2", HullSizeF = "2", HullSizeG = "1", HullSizeH = "1", HullSizeJ = "1", HullSizeK = "1", HullSizeL = "1", HullSizeM = "1", HullSizeN = "no", HullSizeP = "no", HullSizeQ = "no", HullSizeR = "no", HullSizeS = "no", HullSizeT = "no", HullSizeU = "no", HullSizeV = "no", HullSizeW = "no", HullSizeX = "no", HullSizeY = "no", HullSizeZ = "no" });
            DrivePotentialData.Add(new DrivePotential() { DriveSize = "G", HullSizeA = "9", HullSizeB = "7", HullSizeC = "4", HullSizeD = "3", HullSizeE = "2", HullSizeF = "2", HullSizeG = "2", HullSizeH = "1", HullSizeJ = "1", HullSizeK = "1", HullSizeL = "1", HullSizeM = "1", HullSizeN = "1", HullSizeP = "1", HullSizeQ = "no", HullSizeR = "no", HullSizeS = "no", HullSizeT = "no", HullSizeU = "no", HullSizeV = "no", HullSizeW = "no", HullSizeX = "no", HullSizeY = "no", HullSizeZ = "no" });
            DrivePotentialData.Add(new DrivePotential() { DriveSize = "H", HullSizeA = "9", HullSizeB = "8", HullSizeC = "5", HullSizeD = "4", HullSizeE = "3", HullSizeF = "2", HullSizeG = "2", HullSizeH = "2", HullSizeJ = "1", HullSizeK = "1", HullSizeL = "1", HullSizeM = "1", HullSizeN = "1", HullSizeP = "1", HullSizeQ = "1", HullSizeR = "1", HullSizeS = "no", HullSizeT = "no", HullSizeU = "no", HullSizeV = "no", HullSizeW = "no", HullSizeX = "no", HullSizeY = "no", HullSizeZ = "no" });
            DrivePotentialData.Add(new DrivePotential() { DriveSize = "J", HullSizeA = "9", HullSizeB = "9", HullSizeC = "6", HullSizeD = "4", HullSizeE = "3", HullSizeF = "3", HullSizeG = "2", HullSizeH = "2", HullSizeJ = "2", HullSizeK = "1", HullSizeL = "1", HullSizeM = "1", HullSizeN = "1", HullSizeP = "1", HullSizeQ = "1", HullSizeR = "1", HullSizeS = "1", HullSizeT = "1", HullSizeU = "no", HullSizeV = "no", HullSizeW = "no", HullSizeX = "no", HullSizeY = "no", HullSizeZ = "no" });
            DrivePotentialData.Add(new DrivePotential() { DriveSize = "K", HullSizeA = "9", HullSizeB = "9", HullSizeC = "6", HullSizeD = "5", HullSizeE = "4", HullSizeF = "3", HullSizeG = "2", HullSizeH = "2", HullSizeJ = "2", HullSizeK = "2", HullSizeL = "1", HullSizeM = "1", HullSizeN = "1", HullSizeP = "1", HullSizeQ = "1", HullSizeR = "1", HullSizeS = "1", HullSizeT = "1", HullSizeU = "1", HullSizeV = "1", HullSizeW = "no", HullSizeX = "no", HullSizeY = "no", HullSizeZ = "no" });
            DrivePotentialData.Add(new DrivePotential() { DriveSize = "L", HullSizeA = "9", HullSizeB = "9", HullSizeC = "7", HullSizeD = "5", HullSizeE = "4", HullSizeF = "3", HullSizeG = "3", HullSizeH = "2", HullSizeJ = "2", HullSizeK = "2", HullSizeL = "2", HullSizeM = "1", HullSizeN = "1", HullSizeP = "1", HullSizeQ = "1", HullSizeR = "1", HullSizeS = "1", HullSizeT = "1", HullSizeU = "1", HullSizeV = "1", HullSizeW = "1", HullSizeX = "1", HullSizeY = "no", HullSizeZ = "no" });
            DrivePotentialData.Add(new DrivePotential() { DriveSize = "M", HullSizeA = "9", HullSizeB = "9", HullSizeC = "8", HullSizeD = "6", HullSizeE = "4", HullSizeF = "4", HullSizeG = "3", HullSizeH = "3", HullSizeJ = "2", HullSizeK = "2", HullSizeL = "2", HullSizeM = "2", HullSizeN = "1", HullSizeP = "1", HullSizeQ = "1", HullSizeR = "1", HullSizeS = "1", HullSizeT = "1", HullSizeU = "1", HullSizeV = "1", HullSizeW = "1", HullSizeX = "1", HullSizeY = "1", HullSizeZ = "1" });
            DrivePotentialData.Add(new DrivePotential() { DriveSize = "N", HullSizeA = "9", HullSizeB = "9", HullSizeC = "8", HullSizeD = "6", HullSizeE = "5", HullSizeF = "4", HullSizeG = "3", HullSizeH = "3", HullSizeJ = "2", HullSizeK = "2", HullSizeL = "2", HullSizeM = "2", HullSizeN = "2", HullSizeP = "1", HullSizeQ = "1", HullSizeR = "1", HullSizeS = "1", HullSizeT = "1", HullSizeU = "1", HullSizeV = "1", HullSizeW = "1", HullSizeX = "1", HullSizeY = "1", HullSizeZ = "1" });
            DrivePotentialData.Add(new DrivePotential() { DriveSize = "P", HullSizeA = "9", HullSizeB = "9", HullSizeC = "9", HullSizeD = "7", HullSizeE = "5", HullSizeF = "4", HullSizeG = "4", HullSizeH = "3", HullSizeJ = "3", HullSizeK = "2", HullSizeL = "2", HullSizeM = "2", HullSizeN = "2", HullSizeP = "2", HullSizeQ = "1", HullSizeR = "1", HullSizeS = "1", HullSizeT = "1", HullSizeU = "1", HullSizeV = "1", HullSizeW = "1", HullSizeX = "1", HullSizeY = "1", HullSizeZ = "1" });
            DrivePotentialData.Add(new DrivePotential() { DriveSize = "Q", HullSizeA = "9", HullSizeB = "9", HullSizeC = "9", HullSizeD = "7", HullSizeE = "6", HullSizeF = "5", HullSizeG = "4", HullSizeH = "3", HullSizeJ = "3", HullSizeK = "3", HullSizeL = "2", HullSizeM = "2", HullSizeN = "2", HullSizeP = "2", HullSizeQ = "2", HullSizeR = "1", HullSizeS = "1", HullSizeT = "1", HullSizeU = "1", HullSizeV = "1", HullSizeW = "1", HullSizeX = "1", HullSizeY = "1", HullSizeZ = "1" });
            DrivePotentialData.Add(new DrivePotential() { DriveSize = "R", HullSizeA = "9", HullSizeB = "9", HullSizeC = "9", HullSizeD = "8", HullSizeE = "6", HullSizeF = "5", HullSizeG = "4", HullSizeH = "4", HullSizeJ = "3", HullSizeK = "3", HullSizeL = "2", HullSizeM = "2", HullSizeN = "2", HullSizeP = "2", HullSizeQ = "2", HullSizeR = "2", HullSizeS = "1", HullSizeT = "1", HullSizeU = "1", HullSizeV = "1", HullSizeW = "1", HullSizeX = "1", HullSizeY = "1", HullSizeZ = "1" });
            DrivePotentialData.Add(new DrivePotential() { DriveSize = "S", HullSizeA = "9", HullSizeB = "9", HullSizeC = "9", HullSizeD = "8", HullSizeE = "6", HullSizeF = "5", HullSizeG = "4", HullSizeH = "4", HullSizeJ = "3", HullSizeK = "3", HullSizeL = "3", HullSizeM = "2", HullSizeN = "2", HullSizeP = "2", HullSizeQ = "2", HullSizeR = "2", HullSizeS = "2", HullSizeT = "1", HullSizeU = "1", HullSizeV = "1", HullSizeW = "1", HullSizeX = "1", HullSizeY = "1", HullSizeZ = "1" });
            DrivePotentialData.Add(new DrivePotential() { DriveSize = "T", HullSizeA = "9", HullSizeB = "9", HullSizeC = "9", HullSizeD = "9", HullSizeE = "7", HullSizeF = "6", HullSizeG = "5", HullSizeH = "4", HullSizeJ = "4", HullSizeK = "3", HullSizeL = "3", HullSizeM = "3", HullSizeN = "2", HullSizeP = "2", HullSizeQ = "2", HullSizeR = "2", HullSizeS = "2", HullSizeT = "2", HullSizeU = "1", HullSizeV = "1", HullSizeW = "1", HullSizeX = "1", HullSizeY = "1", HullSizeZ = "1" });
            DrivePotentialData.Add(new DrivePotential() { DriveSize = "U", HullSizeA = "9", HullSizeB = "9", HullSizeC = "9", HullSizeD = "9", HullSizeE = "7", HullSizeF = "6", HullSizeG = "5", HullSizeH = "4", HullSizeJ = "4", HullSizeK = "3", HullSizeL = "3", HullSizeM = "3", HullSizeN = "2", HullSizeP = "2", HullSizeQ = "2", HullSizeR = "2", HullSizeS = "2", HullSizeT = "2", HullSizeU = "2", HullSizeV = "1", HullSizeW = "1", HullSizeX = "1", HullSizeY = "1", HullSizeZ = "1" });
            DrivePotentialData.Add(new DrivePotential() { DriveSize = "V", HullSizeA = "9", HullSizeB = "9", HullSizeC = "9", HullSizeD = "9", HullSizeE = "8", HullSizeF = "6", HullSizeG = "5", HullSizeH = "5", HullSizeJ = "4", HullSizeK = "4", HullSizeL = "3", HullSizeM = "3", HullSizeN = "3", HullSizeP = "2", HullSizeQ = "2", HullSizeR = "2", HullSizeS = "2", HullSizeT = "2", HullSizeU = "2", HullSizeV = "2", HullSizeW = "1", HullSizeX = "1", HullSizeY = "1", HullSizeZ = "1" });
            DrivePotentialData.Add(new DrivePotential() { DriveSize = "W", HullSizeA = "9", HullSizeB = "9", HullSizeC = "9", HullSizeD = "9", HullSizeE = "8", HullSizeF = "7", HullSizeG = "6", HullSizeH = "5", HullSizeJ = "4", HullSizeK = "4", HullSizeL = "3", HullSizeM = "3", HullSizeN = "3", HullSizeP = "3", HullSizeQ = "2", HullSizeR = "2", HullSizeS = "2", HullSizeT = "2", HullSizeU = "2", HullSizeV = "2", HullSizeW = "2", HullSizeX = "1", HullSizeY = "1", HullSizeZ = "1" });
            DrivePotentialData.Add(new DrivePotential() { DriveSize = "X", HullSizeA = "9", HullSizeB = "9", HullSizeC = "9", HullSizeD = "9", HullSizeE = "8", HullSizeF = "7", HullSizeG = "6", HullSizeH = "5", HullSizeJ = "4", HullSizeK = "4", HullSizeL = "4", HullSizeM = "3", HullSizeN = "3", HullSizeP = "3", HullSizeQ = "2", HullSizeR = "2", HullSizeS = "2", HullSizeT = "2", HullSizeU = "2", HullSizeV = "2", HullSizeW = "2", HullSizeX = "2", HullSizeY = "1", HullSizeZ = "1" });
            DrivePotentialData.Add(new DrivePotential() { DriveSize = "Y", HullSizeA = "9", HullSizeB = "9", HullSizeC = "9", HullSizeD = "9", HullSizeE = "9", HullSizeF = "7", HullSizeG = "6", HullSizeH = "5", HullSizeJ = "5", HullSizeK = "4", HullSizeL = "4", HullSizeM = "3", HullSizeN = "3", HullSizeP = "3", HullSizeQ = "3", HullSizeR = "2", HullSizeS = "2", HullSizeT = "2", HullSizeU = "2", HullSizeV = "2", HullSizeW = "2", HullSizeX = "2", HullSizeY = "2", HullSizeZ = "1" });
            DrivePotentialData.Add(new DrivePotential() { DriveSize = "Z", HullSizeA = "9", HullSizeB = "9", HullSizeC = "9", HullSizeD = "9", HullSizeE = "9", HullSizeF = "8", HullSizeG = "6", HullSizeH = "6", HullSizeJ = "5", HullSizeK = "4", HullSizeL = "4", HullSizeM = "4", HullSizeN = "3", HullSizeP = "3", HullSizeQ = "3", HullSizeR = "3", HullSizeS = "2", HullSizeT = "2", HullSizeU = "2", HullSizeV = "2", HullSizeW = "2", HullSizeX = "2", HullSizeY = "2", HullSizeZ = "2" });
            DrivePotentialData.Add(new DrivePotential() { DriveSize = "N2", HullSizeA = "9", HullSizeB = "9", HullSizeC = "9", HullSizeD = "9", HullSizeE = "9", HullSizeF = "8", HullSizeG = "7", HullSizeH = "6", HullSizeJ = "5", HullSizeK = "5", HullSizeL = "4", HullSizeM = "4", HullSizeN = "4", HullSizeP = "3", HullSizeQ = "3", HullSizeR = "3", HullSizeS = "3", HullSizeT = "2", HullSizeU = "2", HullSizeV = "2", HullSizeW = "2", HullSizeX = "2", HullSizeY = "2", HullSizeZ = "2" });
            DrivePotentialData.Add(new DrivePotential() { DriveSize = "P2", HullSizeA = "9", HullSizeB = "9", HullSizeC = "9", HullSizeD = "9", HullSizeE = "9", HullSizeF = "9", HullSizeG = "8", HullSizeH = "7", HullSizeJ = "6", HullSizeK = "5", HullSizeL = "5", HullSizeM = "4", HullSizeN = "4", HullSizeP = "4", HullSizeQ = "3", HullSizeR = "3", HullSizeS = "3", HullSizeT = "3", HullSizeU = "2", HullSizeV = "2", HullSizeW = "2", HullSizeX = "2", HullSizeY = "2", HullSizeZ = "2" });
            DrivePotentialData.Add(new DrivePotential() { DriveSize = "Q2", HullSizeA = "9", HullSizeB = "9", HullSizeC = "9", HullSizeD = "9", HullSizeE = "9", HullSizeF = "9", HullSizeG = "8", HullSizeH = "7", HullSizeJ = "6", HullSizeK = "6", HullSizeL = "5", HullSizeM = "5", HullSizeN = "4", HullSizeP = "4", HullSizeQ = "4", HullSizeR = "3", HullSizeS = "3", HullSizeT = "3", HullSizeU = "3", HullSizeV = "3", HullSizeW = "2", HullSizeX = "2", HullSizeY = "2", HullSizeZ = "2" });
            DrivePotentialData.Add(new DrivePotential() { DriveSize = "R2", HullSizeA = "9", HullSizeB = "9", HullSizeC = "9", HullSizeD = "9", HullSizeE = "9", HullSizeF = "9", HullSizeG = "9", HullSizeH = "8", HullSizeJ = "7", HullSizeK = "6", HullSizeL = "5", HullSizeM = "5", HullSizeN = "4", HullSizeP = "4", HullSizeQ = "4", HullSizeR = "4", HullSizeS = "3", HullSizeT = "3", HullSizeU = "3", HullSizeV = "3", HullSizeW = "3", HullSizeX = "2", HullSizeY = "2", HullSizeZ = "2" });
            DrivePotentialData.Add(new DrivePotential() { DriveSize = "S2", HullSizeA = "9", HullSizeB = "9", HullSizeC = "9", HullSizeD = "9", HullSizeE = "9", HullSizeF = "9", HullSizeG = "9", HullSizeH = "8", HullSizeJ = "7", HullSizeK = "6", HullSizeL = "6", HullSizeM = "5", HullSizeN = "5", HullSizeP = "4", HullSizeQ = "4", HullSizeR = "4", HullSizeS = "4", HullSizeT = "3", HullSizeU = "3", HullSizeV = "3", HullSizeW = "3", HullSizeX = "3", HullSizeY = "2", HullSizeZ = "2" });
            DrivePotentialData.Add(new DrivePotential() { DriveSize = "T2", HullSizeA = "9", HullSizeB = "9", HullSizeC = "9", HullSizeD = "9", HullSizeE = "9", HullSizeF = "9", HullSizeG = "9", HullSizeH = "9", HullSizeJ = "8", HullSizeK = "7", HullSizeL = "6", HullSizeM = "6", HullSizeN = "5", HullSizeP = "5", HullSizeQ = "4", HullSizeR = "4", HullSizeS = "4", HullSizeT = "4", HullSizeU = "3", HullSizeV = "3", HullSizeW = "3", HullSizeX = "3", HullSizeY = "3", HullSizeZ = "3" });
            DrivePotentialData.Add(new DrivePotential() { DriveSize = "U2", HullSizeA = "9", HullSizeB = "9", HullSizeC = "9", HullSizeD = "9", HullSizeE = "9", HullSizeF = "9", HullSizeG = "9", HullSizeH = "9", HullSizeJ = "8", HullSizeK = "7", HullSizeL = "6", HullSizeM = "6", HullSizeN = "5", HullSizeP = "5", HullSizeQ = "5", HullSizeR = "4", HullSizeS = "4", HullSizeT = "4", HullSizeU = "4", HullSizeV = "3", HullSizeW = "3", HullSizeX = "3", HullSizeY = "3", HullSizeZ = "3" });
            DrivePotentialData.Add(new DrivePotential() { DriveSize = "V2", HullSizeA = "9", HullSizeB = "9", HullSizeC = "9", HullSizeD = "9", HullSizeE = "9", HullSizeF = "9", HullSizeG = "9", HullSizeH = "9", HullSizeJ = "8", HullSizeK = "8", HullSizeL = "7", HullSizeM = "6", HullSizeN = "6", HullSizeP = "5", HullSizeQ = "5", HullSizeR = "5", HullSizeS = "4", HullSizeT = "4", HullSizeU = "4", HullSizeV = "4", HullSizeW = "3", HullSizeX = "3", HullSizeY = "3", HullSizeZ = "3" });
            DrivePotentialData.Add(new DrivePotential() { DriveSize = "W2", HullSizeA = "9", HullSizeB = "9", HullSizeC = "9", HullSizeD = "9", HullSizeE = "9", HullSizeF = "9", HullSizeG = "9", HullSizeH = "9", HullSizeJ = "9", HullSizeK = "8", HullSizeL = "7", HullSizeM = "7", HullSizeN = "6", HullSizeP = "6", HullSizeQ = "5", HullSizeR = "5", HullSizeS = "4", HullSizeT = "4", HullSizeU = "4", HullSizeV = "4", HullSizeW = "4", HullSizeX = "3", HullSizeY = "3", HullSizeZ = "3" });
            DrivePotentialData.Add(new DrivePotential() { DriveSize = "X2", HullSizeA = "9", HullSizeB = "9", HullSizeC = "9", HullSizeD = "9", HullSizeE = "9", HullSizeF = "9", HullSizeG = "9", HullSizeH = "9", HullSizeJ = "9", HullSizeK = "8", HullSizeL = "8", HullSizeM = "7", HullSizeN = "6", HullSizeP = "6", HullSizeQ = "5", HullSizeR = "5", HullSizeS = "5", HullSizeT = "4", HullSizeU = "4", HullSizeV = "4", HullSizeW = "4", HullSizeX = "4", HullSizeY = "3", HullSizeZ = "3" });
            DrivePotentialData.Add(new DrivePotential() { DriveSize = "Y2", HullSizeA = "9", HullSizeB = "9", HullSizeC = "9", HullSizeD = "9", HullSizeE = "9", HullSizeF = "9", HullSizeG = "9", HullSizeH = "9", HullSizeJ = "9", HullSizeK = "9", HullSizeL = "8", HullSizeM = "7", HullSizeN = "7", HullSizeP = "6", HullSizeQ = "6", HullSizeR = "5", HullSizeS = "5", HullSizeT = "5", HullSizeU = "4", HullSizeV = "4", HullSizeW = "4", HullSizeX = "4", HullSizeY = "4", HullSizeZ = "3" });
            DrivePotentialData.Add(new DrivePotential() { DriveSize = "Z2", HullSizeA = "9", HullSizeB = "9", HullSizeC = "9", HullSizeD = "9", HullSizeE = "9", HullSizeF = "9", HullSizeG = "9", HullSizeH = "9", HullSizeJ = "9", HullSizeK = "9", HullSizeL = "8", HullSizeM = "8", HullSizeN = "7", HullSizeP = "6", HullSizeQ = "6", HullSizeR = "6", HullSizeS = "5", HullSizeT = "5", HullSizeU = "5", HullSizeV = "4", HullSizeW = "4", HullSizeX = "4", HullSizeY = "4", HullSizeZ = "4" });
        }


    }

    public class StarshipDriveLine
    {
        public string EP;
        public string MDrive;
        public string GDrive;
        public string NDrive;
        public string JDrive;
        public string AntiMatter;
        public string Collector;
        public string Fission;
        public string PowerPlant;
        public string Code;
    }

    public class DriveTechLevelEff
    {
        public string TechLevel;
        public string Stage;
        public string TLMod;
        public string CostMod;
        public string Efficiency;
        public string FuelConsumptionMod;
    }

    public class StarshipTLAvailability
    {
        public string DriveType;
        public string TL8;
        public string TL9;
        public string TL10;
        public string TL11;
        public string TL12;
        public string TL13;
        public string TL14;
        public string TL15;
        public string TL16;
        public string TL17;
        public string TL18;
        public string TL19;
        public string TL20;
        public string TL21;
        public string Code;
    }

    public class DriveCost
    {
        public string MDrive = "2";
        public string GDrive = ".5";
        public string JDrive = "1";
        public string AntiMatter = "2";
        public string Collector = ".5";
        public string Fission = "1.5";
        public string PowerPlant = "1";
    }

    public class DrivePotential
    {
        public string DriveSize;
        public string HullSizeA;
        public string HullSizeB;
        public string HullSizeC;
        public string HullSizeD;
        public string HullSizeE;
        public string HullSizeF;
        public string HullSizeG;
        public string HullSizeH;
        public string HullSizeJ;
        public string HullSizeK;
        public string HullSizeL;
        public string HullSizeM;
        public string HullSizeN;
        public string HullSizeP;
        public string HullSizeQ;
        public string HullSizeR;
        public string HullSizeS;
        public string HullSizeT;
        public string HullSizeU;
        public string HullSizeV;
        public string HullSizeW;
        public string HullSizeX;
        public string HullSizeY;
        public string HullSizeZ;
        public string Code;
    }
}
