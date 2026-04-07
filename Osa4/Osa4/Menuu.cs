using System;
using System.Collections.Generic;
using System.Text;

namespace Osa4
{
    internal class Menuu
    {
        public string Nimetus { get; set; }
        public List<string> Koostisosad { get; set; }
        public double Hind { get; set; }
        public Menuu(string nimetus, List<string> koostisosad, double hind)
        {
            Nimetus = nimetus;
            Koostisosad = koostisosad;
            Hind = hind;
        }

        public string VormidaFailijaokrea()
        {
            string ained = string.Join(",", Koostisosad);
            return $"{Nimetus}; {ained}; {Hind}";
        }
    }
}
