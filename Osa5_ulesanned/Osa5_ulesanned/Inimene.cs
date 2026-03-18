using System;
using System.Collections.Generic;
using System.Text;

namespace Osa5_ulesanned
{
    internal class Inimene
    {
        public string Nimi { get; set; }
        public int Vanus { get; set; }
        public string Sugu { get; set; } // "M" или "N"
        public double Pikkus { get; set; } // см
        public double Kaal { get; set; } // кг
        public double AktiivsusTase { get; set; }

        public double ArvutaKalorid()
        {
            double bmr;

            if (Sugu.ToUpper() == "M")
            {
                // Мужчины
                bmr = 88.36 + (13.4 * Kaal) + (4.8 * Pikkus) - (5.7 * Vanus);
            }
            else
            {
                // Женщины
                bmr = 447.6 + (9.2 * Kaal) + (3.1 * Pikkus) - (4.3 * Vanus);
            }

            return bmr * AktiivsusTase;
        }
    }
}
