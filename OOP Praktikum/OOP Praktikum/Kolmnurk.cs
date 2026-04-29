using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Praktikum
{ 
    public class Kolmnurk : IKujund
    {
        public double A { get; private set; }
        public double B { get; private set; }
        public double C { get; private set; }
        public KolmnurgaTüüp Tüüp { get; private set; }

        public Kolmnurk(double a, double b, double c)
        {
            if (a + b > c && a + c > b && b + c > a)
            {
                A = a; B = b; C = c;
                MääraTüüp();
            }
            else
            {
                Tüüp = KolmnurgaTüüp.Vigane;
            }
        }

        private void MääraTüüp()
        {
            if (A == B && B == C) Tüüp = KolmnurgaTüüp.Võrdkülgne;
            else if (A == B || B == C || A == C) Tüüp = KolmnurgaTüüp.Võrdhaarne;
            else Tüüp = KolmnurgaTüüp.Erikülgne;
        }

        public double ArvutaÜmbermõõt() => A + B + C;
        public double ArvutaPindala()
        {
            if (Tüüp == KolmnurgaTüüp.Vigane) return 0;
            double s = ArvutaÜmbermõõt() / 2;
            return Math.Sqrt(s * (s - A) * (s - B) * (s - C));
        }
    }
}
