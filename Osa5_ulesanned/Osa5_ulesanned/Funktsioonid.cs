using System;
using System.Collections.Generic;
using System.Text;

namespace Osa5_ulesanned
{
    class Funktsioonid
    {
        static void Main(string[] args)
        {
            List<Toode> tooted = new List<Toode>()
            {
            new Toode("Õun", 52),
            new Toode("Kana", 239),
            new Toode("Riis", 130),
            new Toode("Šokolaad", 546)
            };

            Console.WriteLine("Sisesta oma nimi:");
            string nimi = Console.ReadLine();

            Console.WriteLine("Vanus:");
            int vanus = int.Parse(Console.ReadLine());

            Console.WriteLine("Sugu (M/N):");
            string sugu = Console.ReadLine();

            Console.WriteLine("Pikkus (cm):");
            double pikkus = double.Parse(Console.ReadLine());

            Console.WriteLine("Kaal (kg):");
            double kaal = double.Parse(Console.ReadLine());

            Console.WriteLine("Aktiivsustase (1.2 - 1.9):");
            double aktiivsus = double.Parse(Console.ReadLine());

            Inimene inimene = new Inimene()
            {
                Nimi = nimi,
                Vanus = vanus,
                Sugu = sugu,
                Pikkus = pikkus,
                Kaal = kaal,
                AktiivsusTase = aktiivsus
            };

            double paevaneKalorid = inimene.ArvutaKalorid();

            Console.WriteLine($"\n{nimi}, sinu päevane energiavajadus: {paevaneKalorid:F2} kcal\n");

            Console.WriteLine("Toidud ja vajalik kogus (grammides):");

            foreach (var toode in tooted)
            {
                double grammid = (paevaneKalorid / toode.Kalorid100g) * 100;
                Console.WriteLine($"{toode.Nimi}: {grammid:F2} g");
            }
        }
    }
}
