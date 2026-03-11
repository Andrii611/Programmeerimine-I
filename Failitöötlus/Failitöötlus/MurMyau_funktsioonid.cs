using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naidis_C.OsaUlesanded.Osa4
{
    internal class Ulesanded
    {
        public static void retseptid()
        {
            try
            {

                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Retseptid.txt");
                StreamWriter text = new StreamWriter(path, true);
                Console.WriteLine("Sisesta Itaalia toidu nime");
                string lause = Console.ReadLine();
                text.WriteLine(lause);
                text.Close();



            }
            catch (Exception)
            {
                Console.WriteLine("Mingi viga failiga");
            }

        }
        public static void retseptilistiavamine()
        {
            try
            {
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Retseptid.txt");
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
        public static void KoostisosadFail()
        {
            try
            {
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "KoostisOsad.txt");
                StreamWriter text = new StreamWriter(path, true);
                Console.WriteLine("Sisesta koostis osad");
                string lause = Console.ReadLine();
                text.WriteLine(lause);
                text.Close();



            }
            catch (Exception)
            {
                Console.WriteLine("Mingi viga failiga");
            }
        }
        public static void KoostisOsadelugemine()
        {
            try
            {
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "KoostisOsad.txt");
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
        public static List<string> Koostisosadelist(string fail)
        {
            List<string> KoostisOsade_list = new List<string>();
            try
            {
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "KoostisOsad.txt");
                foreach (string rida in File.ReadAllLines(path))
                {
                    KoostisOsade_list.Add(rida);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Viga failiga");
            }
            return KoostisOsade_list;
        }

        public static void Koostisosademuutmine(string fail)
        {
            List<string> KoostisOsade_List = Koostisosadelist(fail);

            foreach (string KoostisOsad in KoostisOsade_List)
            {
                Console.WriteLine(KoostisOsad);
            }
            KoostisOsade_List.Remove("Ketšup");

            if (KoostisOsade_List.Count > 1)
                KoostisOsade_List[1] = "Kvaliteetne Oliiviõli";

            Console.WriteLine(" kustutasime Ketšup");
            foreach (string KoostisOsad in KoostisOsade_List)
            {
                Console.WriteLine(KoostisOsad);
            }
        }
        public static void Otsing(string file)
        {
            List<string> KoostisOsade_List = Koostisosadelist(file);
            Console.WriteLine("Sisesta Koostisosa nimi, mida otsida:");
            string otsitav = Console.ReadLine();

            if (KoostisOsade_List.Contains(otsitav))
                Console.WriteLine("KoostisOsa " + otsitav + " on olemas.");
            else
                Console.WriteLine("Sellist KoostisOsa pole.");
        }
        public static void Koostisosadesalvestamine(string file)
        {
            List<string> KoostisOsade_List = Koostisosadelist(file);
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Kuud.txt");
            File.WriteAllLines(path, KoostisOsade_List);
            Console.WriteLine("Koostis osad on salvestatud.");

        }
    }
}
