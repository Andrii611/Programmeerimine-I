using System;
using System.Collections.Generic;
using System.Text;

namespace Osa5
{
    internal class Start_Page
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Osa 5 - OOP");
            Console.WriteLine("Vali meetod");
            Console.WriteLine("1 - KaloriKalkulaator");
            Console.WriteLine("2 - MaardikTest");
            Console.WriteLine("3 - Opilased");
            Console.WriteLine("4 - Filmid");
            Console.WriteLine("5 - MassiivStatistika");
            Console.WriteLine("6 - Lemmikloomad");
            Console.WriteLine("7 - ValuutaKalkulaator");
            Console.WriteLine("8 - array_naide");
            Console.WriteLine("9 - Tuple");
            Console.WriteLine("10 - LinkedList");
            Console.WriteLine("11 - sõnatlik");
            Console.WriteLine("0 - välja");

            string valik = Console.ReadLine();

            switch (valik)
            {
                case "1": 
                    Funktsioon.KaloriKalkulaator(); 
                    break;

                case "2": 
                    Funktsioon.MaardikTest(); 
                    break;

                case "3": 
                    Funktsioon.Opilased(); 
                    break;

                case "4": 
                    Funktsioon.Filmid(); 
                    break;

                case "5": 
                    Funktsioon.MassiivStatistika(); 
                    break;

                case "6": 
                    Funktsioon.Lemmikloomad();
                    break;

                case "7": 
                    Funktsioon.ValuutaKalkulaator(); 
                    break;

                case "8": 
                    Funktsioon.ArrayNaide(); 
                    break;

                case "9":
                    Funktsioon.TupleNaide(); 
                    break; 

                case "10":
                    Funktsioon.LinkedListNaide(); 
                    break;

                case "11":
                    Funktsioon.Sonatlik();
                    break;

                case "0": 
                    return;
                default: 
                    Console.WriteLine("Vale valik. Palun vali 1-11 või 0."); break;
            }
        }
    }
}
