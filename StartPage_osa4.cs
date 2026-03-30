using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naidis_csharp
{
    internal class start_page_Osa4cs

    {
        public static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("4. Osa Funktsioonid");
                string valik = Console.ReadLine();
                string fail = "";
                List<string> list= new List<string>();
                switch (valik)
                {
                    case "1": Osa4_funktsioonid.Faili_kirjutamine(); break;
                    case "2": Osa4_funktsioonid.Faili_lugemine(); break;
                       
                    case "3":
                        Console.Write("failinimi: ");
                        fail = Console.ReadLine();
                        Osa4_funktsioonid.Ridade_lugemine(fail);
                  

                        break;
                    case "4":
                        Console.Write("failinimi: ");
                        fail = Console.ReadLine();
                        list =  Osa4_funktsioonid.Ridade_lugemine_listiks(fail);
                        break;

                    case "5": Osa4_funktsioonid.Listi_muutmine_kuvamine(); break;
                    case "6": Osa4_funktsioonid.Otsing_nimekirjast(); break;
                    case "7":Osa4_funktsioonid.Listi_salvestamine(); break;
                        



                        break;
                    default: Console.Write("sisesta kehtiv number: "); break;
                }
            }
        }
    }
}
