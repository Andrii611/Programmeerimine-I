using System;
using System.Collections.Generic;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace Osa4
{
    internal class StartPage
    {
        public static void Osa4Main()
        {
            Console.WriteLine("Osa 4 - Failid");
            Console.WriteLine("Vali meetod");
            Console.WriteLine("1 - tekstisisestamine");
            Console.WriteLine("2 - Tekstilugemine");
            Console.WriteLine("3 - Ridade_lugemine");
            Console.WriteLine("4 - listi_muutmine");
            Console.WriteLine("5 - Otsing");
            Console.WriteLine("6 - Listisalvestamine");
            Console.WriteLine("------------------------------");
            Console.WriteLine("7 - ItaliaToit ");
            string valik = Console.ReadLine();
            switch (valik)
            {
                case "1":
                    Funktsioon.TekstiSisestus();
                    break;
                case "2":
                    Funktsioon.TekstiLugemine();
                    break;
                case "3":
                    Console.WriteLine("Sisesta faili nimi: ");
                    string file = Console.ReadLine();
                    Funktsioon.LoeReadListi(file);
                    break;
                case "4":
                    Funktsioon.KuvaRead("test.txt");
                    break;
                case "5":
                    Funktsioon.MuudaListi("test.txt");
                    break;
                case "6":
                    Funktsioon.SalvestaListFaili("test.txt");
                    break;
                case "7":
                    MainPageItaaliaToit.MainItalia(new string[0]);
                    break;
                default:
                    Console.WriteLine("Vale valik. Palun vali 1-7.");
                    break;
            }
        }
}
