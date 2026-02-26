using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;

namespace Naidis_IKTpv25
{
    public class Naidis_funktsioonid
    {
        public static float Summa(float arv1, float arv2)
        {
            return arv1 + arv2;
        }
        public static string Kuu_nimetus(int kuu_nr)
        {
            string kuu = "";
            switch (kuu_nr)
            {
                case 1: kuu = "Jaanuar"; break;
                case 2: kuu = "Veebruar"; break;
                case 3: kuu = "Märts"; break;
                case 4: kuu = "Aprill"; break;
                case 5: kuu = "Mai"; break;
                case 6: kuu = "Juuni"; break;
                case 7: kuu = "Juuli"; break;
                case 8: kuu = "August"; break;
                case 9: kuu = "September"; break;
                case 10: kuu = "Oktoober"; break;
                case 11: kuu = "Novemberr"; break;
                case 12: kuu = "Detsember"; break;

                default:
                    kuu = "???";
                    break;
            }
            return kuu;
        }
        public static string Hooaeg(int kuu_nr) 
        {
            string hoo = "";
            if (kuu_nr==1 || kuu_nr==2 || kuu_nr==12) //&& - and, || - or
            {
                hoo = "Talv";
            }
            else if (kuu_nr>2 && kuu_nr<6)
            {
                hoo = "Kevad";
            }
            else if (kuu_nr > 5 && kuu_nr < 9)
            {
                hoo = "Suvi";
            }
            else if (kuu_nr > 8 && kuu_nr < 12) //9,10,11
            {
                hoo = "Sügis";
            }
            else
            {
                hoo = "???";  
            }
                return hoo;
        }
        public static void Muuda_Element_Massiivis(int[] arvud)
        {
            System.Console.Write("Sisestage mis element tahate muuda (1-5)");
            try
            {
                int el = int.Parse(Console.ReadLine());
                System.Console.Write("Sisestage mida tahate panna sellisse elemendisse: ");
                int number = int.Parse(System.Console.ReadLine());
                arvud[el - 1] = number;
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e);
            }
            foreach (int el in arvud)
            {
                System.Console.WriteLine(el);
            }
        }
        public static int[] Taida_Massiiv(int[] arvud)
        {
            for(int i = 0; i < arvud.Length; i++)
            {
                System.Console.Write($"Sisesta {i + 1}. arv: ");
                try
                {
                    arvud[i] = int.Parse(System.Console.ReadLine());
                }
                catch (Exception e)
                {
                    System.Console.WriteLine(e);
                }
            }
            return arvud;
        }
        public static double[] Taida_Massiiv_double(double[] arvud)
        {
            for(int i = 0; i < arvud.Length; i++)
            {
                System.Console.Write($"Sisesta {i + 1}. arv: ");
                try
                {
                    arvud[i] = double.Parse(System.Console.ReadLine());
                }
                catch (Exception e)
                {
                    System.Console.WriteLine(e);
                }
            }
            return arvud;
        }

        public static void Kuva_Massiiv_For_Abil(int[] arvud)
        {
            for(int i = 0; i < arvud.Length; i++)
            {
                System.Console.WriteLine($"Sisestatud arv: {arvud[i]}");
            }
        }
        public static void Kuva_Massiiv_Foreach_Abil(int[] arvud)
        {
            foreach (int arv in arvud)
            {
                System.Console.WriteLine($"Sisestatud arv: {arv}");
            }
        }
        public static void Kuva_Massiiv_For_Abil_Reserved(int[] arvud)
        {
            System.Console.WriteLine("For abil: viimane -> esimene");
            for (int i = arvud.Length - 1; i > -1; i--)
            {
                System.Console.WriteLine($"Sisestatud arv: {arvud[i]}");
            }
        }
    }
}