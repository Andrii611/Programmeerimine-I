using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Praktikum
{
    public class TäisnurkneKolmnurk : IKujund
    {
        public double A { get; set; }
        public double B { get; set; }
        public TäisnurkneKolmnurk(double a, double b) { A = a; B = b; }
        public double ArvutaPindala() => (A * B) / 2;
        public double ArvutaÜmbermõõt() => A + B + Math.Sqrt(A * A + B * B);
    }
}
