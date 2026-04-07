using System;
using System.Collections.Generic;
using System.Text;

namespace Osa4
{
    internal class Funktsioon
    {
        public static void TekstiSisestus()
        {
            string failitee = @"/../../../Fail.txt";

            try
            {
                Console.WriteLine("Sisesta tekst:");
                string kasutajaTekst = Console.ReadLine();

                using (StreamWriter sw = new StreamWriter(failitee, append: true))
                {
                    sw.WriteLine(kasutajaTekst);
                }
            }
            catch(Exception)
            {
                Console.WriteLine("Failiga tekkis viga!");
            }
        }

        public static void TekstiLugemine()
        {
            try
            {
                string failitee = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Kuud.txt");

                using (StreamReader sr = new StreamReader(failitee))
                {
                    string sisu = sr.ReadToEnd();
                    Console.WriteLine(sisu);
                }
            }
            catch
            {
                Console.WriteLine("Faili lugemine ebaõnnestus!");
            }
        }

        public static List<string> LoeReadListi(string fail)
        {
            List<string> read = new List<string>();
            string failitee = @$"..\..\..\{fail}";

            try
            {
                foreach (string rida in File.ReadAllLines(failitee))
                {
                    read.Add(rida);
                }
            }
            catch
            {
                Console.WriteLine("Faili ei õnnestunud lugeda!");
            }

            return read;
        }

        public static void KuvaRead(string fail)
        {
            List<string> read = LoeReadListi(fail);

            foreach (var r in read)
            {
                Console.WriteLine(r);
            }
        }

        public static void MuudaListi(string fail)
        {
            List<string> read = LoeReadListi(fail);

            Console.WriteLine("Algne sisu:");
            foreach (string r in read)
            {
                Console.WriteLine(r);
            }

            read.Remove("Juuni");

            if (read.Count > 0)
            {
                read[0] = "Muudetud kuu";
            }

            Console.WriteLine("\nPärast muutmist:");
            foreach (string r in read)
            {
                Console.WriteLine(r);
            }
        }

        public static void OtsiKuu(string fail)
        {
            List<string> read = LoeReadListi(fail);

            Console.Write("Sisesta otsitav kuu: ");
            string otsitav = Console.ReadLine();

            if (read.Contains(otsitav))
            {
                Console.WriteLine($"Kuu {otsitav} on olemas.");
            }
            else
            {
                Console.WriteLine("Sellist kuud ei leitud.");
            }
        }

        public static void SalvestaListFaili(string fail)
        {
            List<string> read = LoeReadListi(fail);
            string failitee = @$"..\..\..\{fail}";

            File.WriteAllLines(failitee, read);

            Console.WriteLine("Andmed salvestatud faili.");
        }
    }
}