using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Xml.Linq;

namespace Osa5
{
    internal static class Funktsioon
    {
        public class Toode
        {
            public string Nimi;
            public double Kalorid100g;
        }

        public class Inimene
        {
            public string Nimi;
            public int Vanus;
            public string Sugu;
            public double Pikkus;
            public double Kaal;
            public double Aktiivsus;
        }

        public class Opilane
        {
            public string Nimi { get; set; }
            public List<int> Hinded { get; set; }

            public Opilane(string nimi, List<int> hinded)
            {
                Nimi = nimi;
                Hinded = hinded ?? new List<int>();
            }

            public Opilane()
            {
                Hinded = new List<int>();
            }

            public double Keskmine() => Hinded.Average();
        }

        public class Film
        {
            public string Pealkiri;
            public int Aasta;
            public string Zhanr;
        }

        public class Lemmikloom
        {
            public string Nimi { get; set; }
            public string Liik { get; set; }
            public int Vanus { get; set; }
        }

        public class Valuuta
        {
        
            public string Nimi;
        
            public double Kurss;
        }


        public static void KaloriKalkulaator()
        {
            List<Toode> tooted = new List<Toode>()
            {
                new Toode { Nimi = "Salatik_burmaldadik",  Kalorid100g = 52  },
                new Toode { Nimi = "Sosiski", Kalorid100g = 239 },
                new Toode { Nimi = "Chechevichnii_sup", Kalorid100g = 130 }
            };

            Inimene inimene = new Inimene();

            Console.Write("Nimi: ");
            inimene.Nimi = Console.ReadLine();

            Console.Write("Vanus: ");
            inimene.Vanus = int.Parse(Console.ReadLine());

            Console.Write("Sugu (M/N): ");
            inimene.Sugu = Console.ReadLine();

            Console.Write("Pikkus (cm): ");
            inimene.Pikkus = double.Parse(Console.ReadLine());

            Console.Write("Kaal (kg): ");
            inimene.Kaal = double.Parse(Console.ReadLine());

            Console.Write("Aktiivsus (1.2-1.9): ");
            inimene.Aktiivsus = double.Parse(Console.ReadLine().Replace('.', ','));

            double bmr = inimene.Sugu.ToUpper() == "M"
                ? 88.36 + (13.4 * inimene.Kaal) + (4.8 * inimene.Pikkus) - (5.7 * inimene.Vanus)
                : 447.6 + (9.2 * inimene.Kaal) + (3.1 * inimene.Pikkus) - (4.3 * inimene.Vanus);

            double kalorid = bmr * inimene.Aktiivsus;
            Console.WriteLine($"Päevane vajadus: {kalorid:F2} kcal");

            foreach (var t in tooted)
            {
                double kogus = kalorid / t.Kalorid100g * 100;
                Console.WriteLine($"{t.Nimi}: {kogus:F2} g");
            }
        }

        public static void MaardikTest()
        {
            Dictionary<string, string> maakond = new Dictionary<string, string>()
            {             
                { "Harjumaa", "Tallinn" },            
                { "Tartumaa", "Tartu" },            
                { "Pärnumaa", "Pärnu" }
            };

            Console.Write("Sisesta maakond või linn: ");
            string input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Sisend ei saa olla tühi!");
                return;
            }

            if (maakond.ContainsKey(input))
            {
                Console.WriteLine("Pealinn: " + maakond[input]);
            }
            else if (maakond.ContainsValue(input))
            {
                foreach (var kv in maakond)
                    if (kv.Value == input)
                        Console.WriteLine("Maakond: " + kv.Key);
            }
            else
            {
                Console.WriteLine("Ei leitud, lisa uus.");

                Console.Write("Maakond: ");
                string m = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(m))
                {
                    Console.WriteLine("Maakond ei saa olla tühi!");
                    return;
                }

                if (maakond.ContainsKey(m))
                {
                    Console.WriteLine("See maakond on juba olemas!");
                    return;
                }

                Console.Write("Linn: ");
                string l = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(l))
                {
                    Console.WriteLine("Linn ei saa olla tühi!");
                    return;
                }

                maakond[m] = l;
                Console.WriteLine("Lisatud!");
            }

            int correct = 0;
            Random rnd = new Random();
            var keys = maakond.Keys.ToList();

            for (int i = 0; i < 3; i++)
            {
                string k = keys[rnd.Next(keys.Count)];
                Console.Write($"Mis on {k} keskus? ");
                string ans = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(ans))
                {
                    Console.WriteLine("Vastus ei saa olla tühi!");
                    continue;
                }

                if (ans.Trim() == maakond[k])
                    correct++;
            }

            Console.WriteLine($"Tulemus: {correct * 100 / 3}%");
        }

        public static void Opilased()
        {
            List<Opilane> list = new List<Opilane>()
            {
                new Opilane("Anna", new List<int> { 5, 4, 5 }),
                new Opilane("Mark", new List<int> { 3, 4, 2 }),
                new Opilane("Jaan", new List<int> { 5, 5, 5 })
            };

            Console.Write("Lisage õpilase nimi: ");
            string uusNimi = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(uusNimi))
            {
                Console.WriteLine("Nimi ei saa olla tühi!");
                return;
            }

            List<int> uusHinded = new List<int>();

            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Sisesta hinne {i + 1} (1-5): ");

                if (!int.TryParse(Console.ReadLine(), out int hinne) || hinne < 1 || hinne > 5)
                {
                    Console.WriteLine("Hinne peab olema 1-5 vahel!");
                    return;
                }

                uusHinded.Add(hinne);
            }

            foreach (var o in list)
                Console.WriteLine($"{o.Nimi}: {o.Keskmine():F2}");

            var best = list.OrderByDescending(x => x.Keskmine()).First();
            Console.WriteLine("Parim: " + best.Nimi);

            Console.WriteLine("Sorteeritud:");
            foreach (var o in list.OrderBy(x => x.Keskmine()))
                Console.WriteLine(o.Nimi);
        }

        public static void Filmid()
        {
            List<Film> filmid = new List<Film>()
            {
           
                new Film { Pealkiri = "Matrix",  Aasta = 1999, Zhanr = "Sci-Fi"  },        
                new Film { Pealkiri = "Titanic", Aasta = 1997, Zhanr = "Romance" },        
                new Film { Pealkiri = "Avatar",  Aasta = 2009, Zhanr = "Sci-Fi"  },        
                new Film { Pealkiri = "Joker",   Aasta = 2019, Zhanr = "Drama"   },
                new Film { Pealkiri = "Batman",  Aasta = 2022, Zhanr = "Action"  }
            };

            Console.Write("Sisesta žanr: ");
            string z = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(z))
            {
                Console.WriteLine("Žanr ei tohi olla tühi!");
                return;
            }

            z = z.ToLower();

            var leitud = filmid
                .Where(f => f.Zhanr.ToLower() == z)
                .ToList();

            if (leitud.Count == 0)
            {
                Console.WriteLine("Sellise žanriga filme ei leitud.");
            }
            else
            {
                Console.WriteLine("Leitud filmid:");
                foreach (var f in leitud)
                    Console.WriteLine(f.Pealkiri);
            }

            if (filmid.Any())
            {
                var uusim = filmid.OrderByDescending(f => f.Aasta).First();
                Console.WriteLine("Uusim: " + uusim.Pealkiri);
            }

            foreach (var g in filmid.GroupBy(f => f.Zhanr))
            {
                Console.WriteLine("Žanr: " + g.Key);
                foreach (var f in g)
                    Console.WriteLine(" - " + f.Pealkiri);
            }
        }

        public static void MassiivStatistika()
        {
            Console.Write("Sisesta arvud: ");
            double[] arr = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            double avg = arr.Average();
            Console.WriteLine($"Max: {arr.Max()}, Min: {arr.Min()}, Avg: {avg}, Sum: {arr.Sum()}");
            Console.WriteLine("Suuremad kui keskmine: " + arr.Count(x => x > avg));

            Array.Sort(arr);
            Console.WriteLine("Sorteeritud: " + string.Join(", ", arr));
        }

        public static void Lemmikloomad()
        {
            List<Lemmikloom> list = new List<Lemmikloom>();

            for (int i = 0; i < 5; i++)
            {
                Lemmikloom l = new Lemmikloom();
                Console.Write("Nimi: "); l.Nimi = Console.ReadLine();
                Console.Write("Liik: "); l.Liik = Console.ReadLine();
                Console.Write("Vanus: "); l.Vanus = int.Parse(Console.ReadLine());
                list.Add(l);
            }

            Console.WriteLine("Kassid:");
            foreach (var l in list.Where(x => x.Liik == "kass"))
                Console.WriteLine(l.Nimi);

            Console.WriteLine("Keskmine vanus: " + list.Average(x => x.Vanus));
            Console.WriteLine("Vanim: " + list.OrderByDescending(x => x.Vanus).First().Nimi);

            Console.Write("Otsi nime: ");
            string nimi = Console.ReadLine();
            var leitud = list.FirstOrDefault(x => x.Nimi == nimi);
            if (leitud != null) Console.WriteLine("Leitud: " + leitud.Nimi);
        }

        public static void ValuutaKalkulaator()
        {
            Dictionary<string, Valuuta> val = new Dictionary<string, Valuuta>()
            {
                { "USD", new Valuuta { Nimi = "USD", Kurss = 1.1  } },
                { "GBP", new Valuuta { Nimi = "GBP", Kurss = 0.85 } }
            };

            Console.Write("Summa: ");
            double summa = double.Parse(Console.ReadLine());

            Console.Write("Valuuta (USD/GBP): ");
            string v = Console.ReadLine().ToUpper();

            if (val.ContainsKey(v))
            {
                double eur = summa / val[v].Kurss;
                Console.WriteLine($"EUR: {eur:F2}");
                Console.WriteLine($"{v}: {eur * val[v].Kurss:F2}");
            }
        }

        public static void ArrayNaide()
        {
            ArrayList nimed = new ArrayList { "Kati", "Mati", "Juku" };

            if (nimed.Contains("Mati")) Console.WriteLine("Mati olemas");
            Console.WriteLine("Nimesid kokku: " + nimed.Count);

            nimed.Insert(1, "Sass");
            Console.WriteLine("Mati indeks: " + nimed.IndexOf("Mati"));
            Console.WriteLine("Mari indeks: " + nimed.IndexOf("Mari"));

            nimed.Sort();
            foreach (string n in nimed) Console.WriteLine(n);
        }

        public static void TupleNaide()
        {
            Tuple<float, char> route = new Tuple<float, char>(2.5f, 'N');
            Console.WriteLine($"Vahemaa: {route.Item1}, Suund: {route.Item2}");
        }

        public static void LinkedListNaide()
        {
            LinkedList<int> loetelu = new LinkedList<int>();
            loetelu.AddLast(5);
            loetelu.AddLast(3);
            loetelu.AddFirst(0);

            Console.WriteLine("-----------------------------");
            foreach (int arv in loetelu) Console.WriteLine(arv);

            loetelu.RemoveFirst();
            loetelu.RemoveLast();
            loetelu.AddLast(555);
            loetelu.Remove(555);

            LinkedListNode<int> node = loetelu.Find(5);
            loetelu.AddBefore(node, 11);
            loetelu.AddAfter(node, 22);

            Console.WriteLine("-----------------------------");
            foreach (int arv in loetelu) Console.WriteLine(arv);
        }

        public static void Sonatlik()
        {
            Dictionary<int, string> riigid = new Dictionary<int, string>
            {
                { 1, "Hiina"   },
                { 2, "Eesti"   },
                { 3, "Itaalia" }
            };

            foreach (var paar in riigid)
                Console.WriteLine($"{paar.Key} - {paar.Value}");

            riigid[2] = "Eestimaa";
            riigid.Remove(3);
        }
    }
}
