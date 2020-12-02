using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteGeraCashUnitInfo
{
    public class CashUnits
    {
        public List<CashUnit> cashUnits { get; set; }
    }

    public class CashUnit
    {
        public int number { get; set; }
        public int kind { get; set; }
        public int cashTypeKind { get; set; }
        public int type { get; set; }
        public string unitID { get; set; }
        public int status { get; set; }
        public int value { get; set; }
        public string currency { get; set; }
        public int count { get; set; }
        public int depositCount { get; set; }
        public int rejectCount { get; set; }
        public int dispenseCount { get; set; }
        public int initialCount { get; set; }
        public int thresholdState { get; set; }
        public int thrFull { get; set; }
        public int thrEmpty { get; set; }
        public int thrHigh { get; set; }
        public int thrLow { get; set; }
        public List<Physical> physicals { get; set; }

        public override string ToString()
        {
            string tipo = "";

            //6018_6023 REC
            //6019_6021 REJ
            //6019_6026 RET
            //6017_6023 DEP
            //6019_6029 ESC
            //6019_6019 OUT

            switch(kind.ToString() + "_" + type.ToString())
            {
                case "6018_6023":
                    tipo = "REC";
                    break;
                case "6019_6021":
                    tipo = "REJ";
                    break;
                case "6019_6026":
                    tipo = "RET";
                    break;
                case "6017_6023":
                    tipo = "DEP";
                    break;
                case "6019_6029":
                    tipo = "ESC";
                    break;
                case "6019_6019":
                    tipo = "OUT";
                    break;
            }

            return number.ToString() + "_" + tipo + "_" + value.ToString();
        }
    }

    public class Physical
{
        public string name { get; set; }
        public string unitID { get; set; }
        public int status { get; set; }
        public int count { get; set; }
    }
}
