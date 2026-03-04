using System;
using System.Collections.Generic;
using System.Text;

namespace Naidis_IKTpv25
{
    class osa4_funktsioonid
    {
        public static void StreamWriter()
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
            catch (Exception e)
            {
                Console.WriteLine("Mingi viga failiga");
            }

        }

        public static void Faili_lugemine()
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

        public static void Ridade_lugemine()
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
    }
}
