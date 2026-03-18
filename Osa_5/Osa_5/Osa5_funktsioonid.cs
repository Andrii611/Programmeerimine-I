using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Osa_5
{
    internal class osa5_funktsioonid
    {
        public static void array_naide()
        {
            ArrayList nimed = new ArrayList();
            {
                nimed.Add("Kati");
                nimed.Add("Mati");
                nimed.Add("Juku");

                if (nimed.Contains("Mati"))
                    Console.WriteLine("Mati olemas");

                Console.WriteLine("Nimesid kokku: " + nimed.Count);

                nimed.Insert(1, "Sass");

                Console.WriteLine("Mati indeks: " + nimed.IndexOf("Mati"));
                Console.WriteLine("Mari indeks: " + nimed.IndexOf("Mari"));

                nimed.Sort();
                foreach (string nimi in nimed)
                    Console.WriteLine(nimi);
            }
        }
        public static void Tuple()
        {
            Tuple<float, char> route = new Tuple<float, char>(2.5f, 'N');
            Console.WriteLine($"Vahemaa: {route.Item1}, Suund: {route.Item2}");
        }

        public static void Osa5_List3()
        {
            //List on üldine kogum, mis võimaldab salvestada erinevat tüüpi objekte. 
            List<Person> people = new List<Person>();
            people.Add(new Person() { Name = "Kadi" });
            people.Add(new Person() { Name = "Mirje" });

            Person Lisa = new Person() { Name = "Lisa" };
            foreach (Person p in people)
                Console.WriteLine(p.Name);
            //kustutame Lisa nimega objekti listi
            people.Remove(Lisa);
            //näitab, et Lisa nimega objekti listis ei olnudki, sest see oli erinev objekt, kuigi nime poolest sama
            foreach (Person p in people)
                Console.WriteLine(p.Name);
            //kustutame listi esimene objekti
            people.RemoveAt(0);
            people.Insert(0, "Anna");
            people.Insert(1, "Mari");
            people.Sort();
            foreach (string p in people)
                Console.WriteLine(p);
            //sortime nimed pikkuse järgi
            people.Sort((a, b) => a.Length.CompareTo(b.Length));
            foreach (string p in people)
                Console.WriteLine(p);

        }
    }
}
