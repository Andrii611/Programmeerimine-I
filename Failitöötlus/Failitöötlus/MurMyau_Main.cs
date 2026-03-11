using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naidis_C.OsaUlesanded.Osa4
{
    public class Startpage
    {
        static void Main(string[] args)
        {
            Console.WriteLine("vali funktisoon");
            Console.WriteLine("1 - retsepti sisestamine");
            Console.WriteLine("2 - retsepti lugemine");
            Console.WriteLine("3 - koostis osade faili tekkimine");
            Console.WriteLine("4 - koostis osade lugemine");
            Console.WriteLine("5 - koostis osade muutmine ");
            Console.WriteLine("6 - Koostisosa otsing");
            int[] arvud = new int[5];
            string valik = Console.ReadLine();

            if (valik == "1")
            {
                Ulesanded.retseptid();
            }
            else if (valik == "2")
            {
                Ulesanded.retseptilistiavamine();
            }
            else if (valik == "3")
            {
                Ulesanded.KoostisosadFail();
            }
            else if (valik == "4")
            {
                Ulesanded.KoostisOsadelugemine();
            }
            else if (valik == "5")
            {
                Ulesanded.Koostisosademuutmine("KoostisOsad.txt");
            }
            else if (valik == "6")
            {
                Ulesanded.Otsing("KoostisOsad.txt");
            }
            else if (valik == "7")
            {
                Ulesanded.Koostisosadesalvestamine("KoostisOsad.txt");
            }
            else
            {
                Console.WriteLine("viga");
            }
        }
    }
}
