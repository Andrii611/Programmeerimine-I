using System;
using System.Collections.Generic;
using System.Text;

namespace Failitöötlus
{
    internal class MurMyau_funktsioonid
    {
        public static void Lemmiktoidu_salvestamine_faili()
        {
            Console.Write("Sisestage Itaalia roa nimi: ");
            string roog = Console.ReadLine();

            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Retseptid.txt");

            StreamWriter writer = null;

            try
            {
                writer = new StreamWriter(path, true);
                writer.WriteLine(roog);

                Console.WriteLine("Roog salvestati faili edukalt.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Viga faili kirjutamisel: " + ex.Message);
            }
        }

        public static void Kogu_menüü_kuvamine()
        {

        }
    }
}
