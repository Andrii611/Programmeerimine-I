using System;
using System.Collections.Generic;
using System.Text;

namespace Osa5
{
    internal class Class
    {
        class inimene
        {
            static string Nimi { get; set; }
            static int Vanus { get; set; }
            static string Sugu { get; set; }
            static double Pikkus { get; set; }
            static double Kaal { get; set; }
            static int AktiivsusTase { get; set; }

            public inimene(string nimi, int vanus, string sugu, double pikkus, double kaal, int aktiivsusTase)
            {
                Nimi = nimi;
                Vanus = vanus;
                Sugu = sugu;
                Pikkus = pikkus;
                Kaal = kaal;
                AktiivsusTase = aktiivsusTase;
            }

            public double ArvutaBMR()
            {
                if (Sugu == "m")
                {
                    return 88.36 + (13.4 * Kaal) + (4.8 * Pikkus) - (5.7 * Vanus);
                }
                else
                {
                    return 447.6 + (9.2 * Kaal) + (3.1 * Pikkus) - (4.3 * Vanus);
                }
            }

        }
        class Toode
        {
            static string Nimi { get; set; }
            static int Kalorid100g { get; set; }

            public Toode (string nimi, int kalorid)
            {
                Nimi = nimi;
                Kalorid100g = kalorid;
            }
        }   
    }
}
