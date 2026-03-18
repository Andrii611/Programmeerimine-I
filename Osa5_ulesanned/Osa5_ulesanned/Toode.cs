using System;
using System.Collections.Generic;
using System.Text;

namespace Osa5_ulesanned
{
    class Toode
    {
        public string Nimi { get; set; }
        public double Kalorid100g { get; set; }

        public Toode(string nimi, double kalorid100g)
        {
            Nimi = nimi;
            Kalorid100g = kalorid100g;

        }
    }
}
