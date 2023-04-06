using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanMemberKelas
{
    class PlaneTiket
    {
        public string origin { get; set; }
        public int cost { get; set; }
        public string currency { get; set; }
        public string destination { get; set; }

        public void printSummary()
        {
            Console.WriteLine("Origin\t\t= {0}", origin);
          
            Console.WriteLine("destination\t= {0}", destination);
            Console.WriteLine("cost\t\t= {0}({1})", cost,currency);
            if (currency == "IDR")
            {
                int dolar = cost / 15000;
                Console.WriteLine("Convert to Dolar : {0}", dolar);

            }
            else if(currency == "USD")
            {
                int idr = cost * 15000;
                Console.WriteLine("Convert to  Rupiah : {0}", idr);
            }
            Console.WriteLine();
        }
    }
}
