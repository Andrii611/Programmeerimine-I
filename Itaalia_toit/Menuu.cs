using System;
using System.Collections.Generic;
using System.Text;

namespace Itaalia_toit
{
    public class Menuu
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
        //meetod, mis teeb objektist tektsirea
        //Tulemus: "Nimetus;Koostisosad1,Koostisosad2,...;Hind"
        //Näiteks: "Pizza;Tomat,Juust,Peperoni;12.99"

        public string VormindaFailiJaoksrea()
        {
            string ained = string.Join(", ", Koostisosad);
            return $"{Nimetus};{ained};{Hind}";
        }
    }
}
