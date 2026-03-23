using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Naidis_IKTpv25
{
    internal class KolmasOsa_Funktsioonid
    {
        static Random rnd = new Random();

        public static int[] GenereeriRuudud(int min, int max)
        {

            int N = rnd.Next(min, max);
            int M = rnd.Next(min, max);

            int start = Math.Min(N, M);
            int end = Math.Max(N, M);
            Console.WriteLine($"{start}, {end}, {end - start + 1}");
            int[] masiiv = new int[end - start + 1];
            for (int i = start; i <= end; i++)
            {
                masiiv[i - start] = i * i;
            }
            return masiiv;
        }
        public static Tuple<double, double, double> arvuAnaluus(double[] arvud)
        {
            double sum = arvud.Sum();
            double keskmine = arvud.Average();
            double korrutis = 1;

            foreach (double arv in arvud)
            {

                korrutis *= arv;

            }
            string tulemus = string.Join(", ", arvud);
            Console.WriteLine($"Sa sisetatud: {tulemus}");
            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Korrutis: {korrutis}");
            Console.WriteLine($"Keskmine: {keskmine}");
            return Tuple.Create(sum, keskmine, korrutis);


        }
        public static Tuple<int, double, Inimene, Inimene> Statistika(List<Inimene> inimesed)
        {
            int summa = inimesed.Sum(i=>i.Vanus);
            double keskmine = inimesed.Average(i => i.Vanus);
            Inimene vanim = inimesed.OrderByDescending(i => i.Vanus).First();
            Inimene noorim = inimesed.OrderBy(i => i.Vanus).First();
            return Tuple.Create(summa, keskmine, vanim, noorim);
        }
       

        public static void ostsElevantAra()
        {
            string vastus;
            do
            {
                Console.WriteLine("Osts elevant ära");
                vastus = Console.ReadLine().ToLower();

            } while (vastus != "jah");

            while (true)
            {
                Console.WriteLine("Osts elevant ära");
                vastus = Console.ReadLine().ToLower();
                if (vastus == "jah")
                {
                    Console.WriteLine("Oled ostnud elevandi!");
                    break;
                }
                else
                {
                    Console.WriteLine("Kõik nii rakivad, aga Osts elevant ära");
                }

            }



        }

        public static void arvumang()
        {
           
            int arv = rnd.Next(1, 101);
            int katse = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Arva ära number 1-100: ");
                int arva = int.Parse(Console.ReadLine());
                katse++;
                if (arva > arv)
                {
                    Console.WriteLine("Sinu number on väiksem");
                }
                else if (arva < arv)
                {
                    Console.WriteLine("Sinu number on suurem");
                }
                else
                {
                    Console.WriteLine($"Õige! Arvasid ära {katse} katsel.");
                    break;
                }
            }

        }

        public static void SuurimNeliarv()
        {
            Console.WriteLine("Sisesta neli arvu:");

            double[] arvud = new double[4];
            for (int i = 0; i < arvud.Length; i++)
            {

                Console.Write($"Sisesta {i + 1}. arv: ");
                int arvu = int.Parse(Console.ReadLine());


                foreach (double arv in arvud)
                {
                    string tulemus = string.Join(", ", arvud);
                }
            }
        }
        public static int[,] GenereeriKorrutustabel(int ridadeArv, int veergudeArv)
        {
            int[,] tabel = new int[ridadeArv, veergudeArv];
            for (int i = 0; i < ridadeArv; i++)
            {
                for (int j = 0; j < veergudeArv; j++)
                {
                    tabel[i, j] = (i + 1) * (j + 1);
                    Console.Write(tabel[i, j].ToString().PadLeft(5));
                }
                Console.WriteLine(); // Uus rida pärast iga rea täitmist
            }
            return tabel;
        }

        public static void ÕpilastegaMängimine(string[] nimed)
        {
            
            Console.Write("milleks:  ");
            string nimi = Console.ReadLine();
            nimed[2] = nimi;
            nimed[5] = "Mati";
            int i = 0;
                while (i<nimed.Length)
            {
                if (nimed[i].StartsWith("A"))
                {
                    Console.WriteLine($"Tere, {nimed[i]}!");
                }
                i++;
            }
                for (int j = 0; j < nimed.Length; j++)
            {
                Console.WriteLine($"Indeks: {j}, Nimi: {nimed[j]}");
            }
                foreach (string nimi1 in nimed)
            {
                Console.WriteLine(nimi1.ToLower());
            }
            i = 0;
            do
            {
                if (nimed[i] =="Mati")
                {
                    Console.WriteLine("Leidsin Mati! ");
                    break;
                }
                Console.WriteLine($"Tere, {nimed[i]}!");
                i++;
            } while (i<nimed.Length);
        }


        public static void arvudRuudud()
        {
            int[] arvud = { 2, 4, 6, 8, 10, 12 };
            for (int i = 0; i < arvud.Length; i++)
            {
                Console.WriteLine($"arv: {arvud[i]} ruut: {arvud[i] * arvud[i]}");
            }
            foreach (int arv in arvud)
            {
                Console.WriteLine($"arv: {arv} ruut: {arv * 2}");
            }
            while (true)
            {
                int i = 0;
                int count = 0;

                while (i < arvud.Length)
                {
                    if (arvud[i] % 3 == 0) // 0 kui on õige
                    {
                        count++;
                    }

                    i++;
                }

                Console.WriteLine("Jagab 3: " + count);

            }


        }
        public static void Positiivsed_ja_negatiivsed()
        {
            int[] arvud = { 5, -3, 0, 8, -1, 4, -7, 2, 0, -5, 6, 9 };

            int positiivsed = 0;
            int negatiivsed = 0;
            int nullid = 0;
            foreach (int arv in arvud)
            {
                if (arv > 0)
                {
                    positiivsed++;
                }
                else if (arv < 0)
                {
                    negatiivsed++;
                }
                else
                {
                    nullid++;
                }

            }
            Console.WriteLine($"Positiivsed: {positiivsed}");
            Console.WriteLine($"Negatiivsed: {negatiivsed}");
            Console.WriteLine($"Nullid: {nullid}");
        }

        public static void rohkemkuiKeskmine()
        {
            int arvu = rnd.Next(1, 101);
            int[] arvud = new int[15];
            int summa = 0;
            foreach (int arv in arvud)
            {
                summa += arv;
            }
            double keskmine = summa / arvud.Length;
            Console.WriteLine($"Keskmine: {keskmine}");
            Console.WriteLine("Arvud, mis on suuremad kui keskmine:");
            foreach (int arv in arvud)
            {
                if (arv > keskmine)
                {
                    Console.WriteLine(arv);
                }
            }
        }
        public static void suurimJaIndeks()
        {
            int[] numbrid = { 12, 56, 78, 2, 90, 43, 88, 67 };

            int max = numbrid[0]; // Eeldame, et esimene element on suurim
            int index = 0;

            for (int i = 1; i < numbrid.Length; i++)
            {
                if (numbrid[i] > max)
                {
                    max = numbrid[i]; // Uuendame suurimat väärtust
                    index = i;
                }
            }

            Console.WriteLine("surim: " + max);
            Console.WriteLine("indeks: " + index);

        }


        public static void binaariOsting()
        {
            int[] numbrid = { 12, 56, 78, 2, 90, 43, 88, 67 };
            numbrid = numbrid.OrderBy(n => n).ToArray(); // Sortime massiivi kasvavalt
            int vasak = 0;
            int parem = numbrid.Length - 1;
            while (vasak <= parem)
            {
                int keskmine = vasak + (parem - vasak) / 2; // Arvutame keskmise indeksi, vasak + on oluline, et vältida ülevoolu, kui vasak ja parem on suured arvud
                //vasak = 4
                //parem = 7
                //keskmine = vasak + (parem - vasak) / 2
                //          = 4 + (7 - 4) / 2
                //          = 4 + 3 / 2
                //          = 4 + 1
                //          = 5
                if (numbrid[keskmine] == 78)
                {
                    Console.WriteLine("Leidsin 78 indeksil: " + keskmine);
                    return;
                }
                else if (numbrid[keskmine] < 78)
                {
                    vasak = keskmine + 1; // Otsime paremas pooles
                }
                else
                {
                    parem = keskmine - 1; // Otsime vasemas pooles
                }
            }
        }

        public static void PaariPaaritud()
        {
            List<int> Arvud = new List<int>();
            int summa = 0;
            int keskmine = 0;
            for (int i = 0; i < 20; i++)
            {
                Arvud.Add(rnd.Next(1,21));
            }
            for (int i = 0; i < Arvud.Count; i++)
            {

           
                if (Arvud[i] % 2 == 0)
                {
                    summa += Arvud[i];
                }
                else
                {
                   keskmine += Arvud[i];

                }
            }
            Console.WriteLine($"Summa: {summa}, keskmine: {keskmine}");

        }

    }
}
