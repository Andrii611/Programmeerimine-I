using System;
using System.Collections.Generic;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace Osa4
{
    internal class MainPage_ItaaliaToit
    {
        public static void MainItalia(string[] args)
        {
            Funktsioon_ItaaliaToit.LaeAndmedFailist();

            while (true)
            {
                Console.WriteLine("\nTere tulemast Itaalia restorani");
                Console.WriteLine("1. Lae andmed failist");
                Console.WriteLine("2. Menüü vaatamine");
                Console.WriteLine("3. Uue toidu lisamine");
                Console.WriteLine("4. Andmete salvestamine");
                Console.WriteLine("5. Toidu kustutamine");
                Console.WriteLine("6. Toidu info");
                Console.WriteLine("0. Välju");

                Console.Write("Sisesta valik: ");

                if (!int.TryParse(Console.ReadLine(), out int valik))
                {
                    Console.WriteLine("Vale sisend!");
                    continue;
                }

                switch (valik)
                {
                    case 1:
                        Funktsioon_ItaaliaToit.LaeAndmedFailist();
                        break;

                    case 2:
                        Funktsioon_ItaaliaToit.ItaaliaRestoran();
                        break;

                    case 3:
                        Funktsioon_ItaaliaToit.LisaUusToit();
                        break;

                    case 4:
                        Funktsioon_ItaaliaToit.SalvestAndmedFaili();
                        break;

                    case 5:
                        Funktsioon_ItaaliaToit.KustutaToit();
                        break;

                    case 6:
                        Funktsioon_ItaaliaToit.ToiduInformatsioon();
                        break;

                    case 0:
                        Console.WriteLine("Programm lõpetab töö...");
                        return;

                    default:
                        Console.WriteLine("Vale valik!");
                        break;
                }
            }
        }
    }
}
