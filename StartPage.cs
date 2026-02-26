using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Timers;

namespace Naidis_IKTpv25
{
    public class StartPage
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("1. Osa Andmetüübid, Alamfunktsioonid/meetodid");
            // Console.BackgroundColor = ConsoleColor.DarkCyan;
            // Console.ForegroundColor = ConsoleColor.Blue;
            string tekst = "Tere tulemast C#'i maailma";
            // System.Console.WriteLine($"Oli loodud muutuja tekst, mis võrdub: {tekst}");
            // System.Console.WriteLine("Oli loodud muutuja tekst, mis võrdub: {0}", tekst);
            // Console.Write("Mis on sinu nimi: ");
            // string nimi = Console.ReadLine();
            // while (true)
            // {
            //     try
            //     {
            //         Console.Write("Kui vana sa oled: ");
            //         byte vanus = Convert.ToByte(Console.ReadLine());
            //         System.Console.WriteLine($"Tere, {nimi}. Sa oled {vanus} aastat vana!");
            //         break;  
            //     }
            //     catch (Exception e)
            //     {
            //         System.Console.WriteLine(e);
            //     }
            // }
            // while (true)
            // {
            //     try
            //     {
            //         System.Console.Write("Sisestage arv 1: ");
            //         float a = float.Parse(Console.ReadLine());
            //         System.Console.Write("Sisestage arv 2:");
            //         float b = float.Parse(Console.ReadLine());
            //         float res = Naidis_funktsioonid.Summa(a, b);
            //         System.Console.WriteLine(res);
            //         break;
            //     }
            //     catch (Exception e)
            //     {
            //         Console.WriteLine(e);
            //     }    
            // }         
            // Random rnd = new Random();
            // int juhuslik_arv = rnd.Next(-5, 25);
            // System.Console.WriteLine(juhuslik_arv);
            // Console.WriteLine(Naidis_funktsioonid.Kuu_nimetus(juhuslik_arv));
            // juhuslik_arv = rnd.Next(-5, 25);
            // System.Console.WriteLine(juhuslik_arv);
            // tekst = Naidis_funktsioonid.Kuu_nimetus(juhuslik_arv);
            // System.Console.WriteLine(tekst);


            // System.Console.WriteLine(TeineOsa_funktsioonid.Juku(nimi));


            // TeineOsa_funktsioonid.Pinginaaber();


            // TeineOsa_funktsioonid.PorandRemont();


            // while (true)
            // {
            //     try
            //     {
            //             System.Console.Write("Sisestage hind soodustusega 30%: ");
            //             float hind = float.Parse(Console.ReadLine());
            //             float alghind = TeineOsa_funktsioonid.AlgHind(hind);
            //             System.Console.WriteLine($"Alghind on: {Math.Round(alghind, 2)} €");
            //             break;
            //     }
            //     catch (System.FormatException)
            //     {
            //         System.Console.WriteLine("Sisestage number, mitte tekst\nVõi proovige ',' asemel '.'");
            //     }
            // }


            // while (true)
            // {
            //     try
            //     {
            //             System.Console.Write("Sisestage toatemperatuur: ");
            //             float temperatuur = float.Parse(Console.ReadLine());
            //             string Recommend = TeineOsa_funktsioonid.Temperatuur(temperatuur);
            //             System.Console.WriteLine(Recommend);
            //             break;
            //     }
            //     catch (System.FormatException)
            //     {
            //         System.Console.WriteLine("Sisestage number, mitte tekst\nVõi proovige ',' asemel '.'");
            //     }


            // System.Console.WriteLine(TeineOsa_funktsioonid.InimesePikkus());


            // TeineOsa_funktsioonid.InimesePikkusSugu();
            // System.Console.WriteLine("3. Osa. Kordused ja Listid, massivid");
            // for (int i = 0; i < 10; i++)
            // {
            //     System.Console.WriteLine($"Tere, {i + 1}");
            // }
            // System.Console.WriteLine("While: ");
            // int j = 0;
            // while (j < 10)
            // {
            //     System.Console.WriteLine($"Tere, {j + 1}");
            //     j++;
            // }
            // System.Console.WriteLine("Do while: ");
            // do
            // {
            //     System.Console.WriteLine($"Tere, {j}");
            //     j--;
            // }
            // while(j != 0);
            
            int[] arvud = new int[5];
            // for(int i = 0; i < arvud.Length; i++)
            // {
            //     System.Console.Write($"Sisesta {i + 1}. arv: ");
            //     try
            //     {
            //         arvud[i] = int.Parse(System.Console.ReadLine());
            //     }
            //     catch (Exception e)
            //     {
            //         System.Console.WriteLine(e);
            //     }
            // }
            // System.Console.WriteLine("Foreach abil: ");
            // foreach (int arv in arvud)
            // {
            //     System.Console.WriteLine($"Sisestatud arv: {arv}");
            // }
            // System.Console.WriteLine("For abil");
            // for(int i = 0; i < arvud.Length; i++)
            // {
            //     System.Console.WriteLine($"Sisestatud arv: {arvud[i]}");
            // }
            // System.Console.WriteLine("For abil: viimane -> esimene");
            // for (int i = arvud.Length - 1; i > -1; i--)
            // {
            //     System.Console.WriteLine($"Sisestatud arv: {arvud[i]}");
            // }
            //Kusi mis potsioonil muuda element ja mis vaartuseks, muuda element ja kuva massiiv
            // System.Console.Write("Sisestage mis element tahate muuda (1-5)");
            // try
            // {
            //     int el = int.Parse(Console.ReadLine());
            //     System.Console.Write("Sisestage mida tahate panna sellisse elemendisse: ");
            //     int number = int.Parse(System.Console.ReadLine());
            //     arvud[el - 1] = number;
            // }
            // catch (Exception e)
            // {
            //     System.Console.WriteLine(e);
            // }
            // foreach (int el in arvud)
            // {
            //     System.Console.WriteLine(el);
            // }
            // Naidis_funktsioonid.Taida_Massiiv(arvud);
            // Naidis_funktsioonid.Muuda_Element_Massiivis(arvud);
            // Naidis_funktsioonid.Kuva_Massiiv_Foreach_Abil(arvud);
            // Naidis_funktsioonid.Kuva_Massiiv_For_Abil(arvud);
            // Naidis_funktsioonid.Kuva_Massiiv_For_Abil_Reserved(arvud);

            List<Isik> inimesed = new List<Isik>();

            for (int i = 0; i < 3; i++)
            {
                Console.Write("Sisesta nimi: ");
                string nimi = Console.ReadLine();

                Console.Write("Sisesta vanus: ");
                int vanus = int.Parse(Console.ReadLine());

                Isik uusIsik = new Isik();
                uusIsik.Nimi = nimi;
                uusIsik.Vanus = vanus;

                inimesed.Add(uusIsik);
            }

            Console.WriteLine("\nKõik inimesed tervitavad:\n");

            foreach (Isik isik in inimesed)
            {
                isik.Tervita();
            }
            double[] double_arvud = new double[5];
            double_arvud = Naidis_funktsioonid.Taida_Massiiv_double(double_arvud);
        }
    }
}