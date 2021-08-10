using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp5
{
    static public class AIservice
    {

        static List<string> SalamRequest = new List<string>
        {
            "Salam","Aleykum Salam","Salam"
        };
        static List<string> NecesenRequest = new List<string>
        {
            "Sagol sen necesen","Shukur yaxsi olasan"," Var ol brat yaxsiyam."
        };
        static List<string> HardasanRequest = new List<string>
        {
            "Evdeyem ","Ise gedirem","Mehledeyem brat nese lazim idi? "
        };
        static List<string> veSRequest = new List<string>
        {
            "Gedirem rayona","Yemey yeyirem","Istirahete gedirem","Denize gedirem","Aqua parka gedirsen?","Niye?"
        };
        static public string GetResponseSalam()
        {
            Random random = new Random();
            int index = random.Next(SalamRequest.Count);
            return SalamRequest[index];
        }
        static public string GetResponseNecesen()
        {
            Random random = new Random();
            int index = random.Next(NecesenRequest.Count);
            return NecesenRequest[index];
        }
        static public string GetResponseHardasan()
        {
            Random random = new Random();
            int index = random.Next(HardasanRequest.Count);
            return HardasanRequest[index];
        }
        static public string GetResponseVeS()
        {
            Random random = new Random();
            int index = random.Next(veSRequest.Count);
            return veSRequest[index];
        }
    }
}
