using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naidis_csharp
{
    internal class osa3
    {
        public static void GenereeriRuudud()
        {
            Random rnd = new Random();
            int min = 1;
            int max = 10;

            int N = rnd.Next(min, max + 1);
            int M = rnd.Next(min, max + 1);

            int start = Math.Min(N, M);
            int end = Math.Max(N, M);


            for (int i = start; i <= end; i++)
            {
                int ruut = i * i;
                Console.WriteLine($"{i} - {ruut}");
            }

        }
        public static Tuple<double, double, double> arvuAnaluus(double[] arvud)
        {
            double summa = arvud.Sum();
            double keskmine = arvud.Average();
            double korrutis = 1;

            foreach (double arv in arvud)
            {
                korrutis *= arv;
            }
            return Tuple.Create(summa, keskmine, korrutis);
        }


        public static void ostsElevantAra()
        {
            while (true)
            {
                Console.WriteLine("Osts elevant ära");
                string vastus = Console.ReadLine().ToLower();
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
            Random rnd = new Random();
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

                foreach (double arv in arvud)
                {
                    Console.WriteLine(arv);
                }
            }
        }
    }
}
    
