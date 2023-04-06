using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanMemberKelas
{
    class Program
    {
        static void Main(string[] args)
        {
            PlaneTiket tiket1 = new PlaneTiket();

            PlaneTiket tiket2 = new PlaneTiket();


            tiket1.origin = "JOGJA";
            tiket1.currency = "USD";
            tiket1.destination = "PKU";
            tiket1.cost = 100;

            tiket2.origin = "JKT";
            tiket2.currency = "IDR";
            tiket2.destination = "PKU";
            tiket2.cost = 750000;

            tiket1.printSummary();
            tiket2.printSummary();
            Console.ReadKey();
        }
    }
}
