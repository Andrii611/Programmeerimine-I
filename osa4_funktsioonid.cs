using System;
using System.Collections.Generic;
using System.Text;

namespace Naidis_IKTpv25
{
<<<<<<< HEAD
    class osa4_funktsioonid
    {
        public static void StreamWriter()
=======
    internal class osa4_funktsioonid
    {
        static List<string> kuude_list = new List<string>()
        {
            "Jaanuar",
            "Veebruar",
            "Märts",
            "Aprill",
            "Mai",
            "Juuni",
            "Juuli",
            "August",
            "September",
            "Oktoober",
            "November",
            "Detsember"
        };

        public static void Failikirjutamine()
>>>>>>> a6ef45118bf66ef5fd4bc7e4d201537049eba000
        {
            try
            {
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Kuud.txt"); //@"..\..\..\Kuud.txt"
                StreamWriter text = new StreamWriter(path, true); // true = lisa lõppu
                Console.WriteLine("Sisesta mingi tekst: ");
                string lause = Console.ReadLine();
                text.WriteLine(lause);
                text.Close();
            }
<<<<<<< HEAD
            catch (Exception e)
            {
                Console.WriteLine("Mingi viga failiga");
            }

        }

        public static void Faili_lugemine()
=======
            catch (Exception)
            {
                Console.WriteLine("Mingi viga failiga");
            }
        }

        public static void Faililugemine()
>>>>>>> a6ef45118bf66ef5fd4bc7e4d201537049eba000
        {
            try
            {
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Kuud.txt");
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

<<<<<<< HEAD
        public static void Ridade_lugemine()
=======
        public static void Ridadelugemine()
>>>>>>> a6ef45118bf66ef5fd4bc7e4d201537049eba000
        {
            List<string> kuude_list = new List<string>();
            try
            {
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Kuud.txt");
                foreach (string rida in File.ReadAllLines(path))
                {
                    kuude_list.Add(rida);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Viga failiga!");
            }
        }
<<<<<<< HEAD
=======

        public static void ListiMuutmineJaKuvamine()
        {
            foreach (string kuu in kuude_list)
            {
                Console.WriteLine(kuu);
            }

            // Eemalda "Juuni"
            kuude_list.Remove("Juuni");

            // Muuda esimest elementi
            if (kuude_list.Count > 0)
                kuude_list[0] = "Veeel kuuu";

            Console.WriteLine("--------------Kustutasime juuni-----------");

            foreach (string kuu in kuude_list)
            {
                Console.WriteLine(kuu);
            }
        }
>>>>>>> a6ef45118bf66ef5fd4bc7e4d201537049eba000
    }
}
