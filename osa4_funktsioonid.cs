﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Naidis_csharp
{
    internal class osa4_funktsioonid
    {
        static List<string> kuude_list = new List<string>()
        {
            "jaanuar",
            "veebruar",
            "märts",
            "aprill",
            "mai",
            "juuni",
            "juuli",
            "august",
            "september",
            "oktoober",
            "november",
            "detsember"
        };

        public static void Faili_kirjutamine()
        {
            try
            {
                string path =  @"..\..\..\Kuud.txt"; //@"..\..\..\Kuud.txt"
                StreamWriter text = new StreamWriter(path, true); // true = lisa lõppu
                Console.WriteLine("Sisesta mingi tekst: ");
                string lause = Console.ReadLine();
                text.WriteLine(lause);
                text.Close();
                using (StreamWriter sw = new StreamWriter(path, true))
                {
                    sw.WriteLine("Midagi");
                } // Fail suletakse automaatselt siin
            }
            catch (Exception e)
            {
                Console.WriteLine("Mingi viga failiga");
            }
           
        }
        public static void Faili_lugemine()
        {

            try
            {
                string path = @"..\..\..\Kuud.txt";
                StreamReader text = new StreamReader(path);
                string laused = text.ReadToEnd();
                text.Close();
                Console.WriteLine(laused);
            }
            catch (Exception)
            {
                Console.WriteLine("Mingi viga failiga, ei saa faili lugeda");
            }
        }

        public static void Ridade_lugemine(string file)
        {
            
            List<string> kuude_list = new List<string>();
            try
            {

                string path = @$"..\..\..\{file}";
                foreach (string rida in File.ReadAllLines(path))
                {
                    kuude_list.Add(rida);

                }
                foreach (string i in kuude_list) Console.WriteLine(i);
                
            }
            
            catch (Exception)
            {
                Console.WriteLine("Viga failiga!");
            }

        }
        public static List<string> Ridade_lugemine_listiks(string file)
        {

            List<string> kuude_list = new List<string>();
            try
            {

                string path = @$"..\..\..\{file}";
                foreach (string rida in File.ReadAllLines(path))
                {
                    kuude_list.Add(rida);

                }                

            }

            catch (Exception)
            {
                Console.WriteLine("Viga failiga!");
            }
            return kuude_list;
          

        }
        public static List<string> Listi_muutmine_kuvamine()
        {
    
            foreach (string k in kuude_list)
            {
                Console.WriteLine(k);
            }

            Console.WriteLine("sisesta kuu kustutamiseks");
           
            string kuu = Console.ReadLine();
            kuude_list.Remove($"{kuu}");

            // Muuda esimest elementi
            if (kuude_list.Count > 0)
                kuude_list[0] = "Veeel kuuu";

            Console.WriteLine("--------------Kustutasime kuu-----------");

            foreach (string k in kuude_list)
            {
                Console.WriteLine(k);
            }

            return kuude_list;
        }
        public static void Otsing_nimekirjast()
        {
            kuude_list = Ridade_lugemine_listiks("Kuud.txt");
            Console.WriteLine("Sisesta kuu nimi, mida otsida:");
            string otsitav = Console.ReadLine();

            if (kuude_list.Contains(otsitav))
                Console.WriteLine("Kuu " + otsitav + " on olemas.");
            else
                Console.WriteLine("Sellist kuud pole.");
        }
        public static void Listi_salvestamine()
        {
            string path = @"..\..\..\Kuud.txt";
            File.WriteAllLines(path, kuude_list);
            Console.WriteLine("Andmed on salvestatud.");

        }
    }
}
