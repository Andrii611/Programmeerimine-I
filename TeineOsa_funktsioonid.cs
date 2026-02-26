using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Security.Cryptography;
using System.Text;

namespace Naidis_IKTpv25
{
    public class TeineOsa_funktsioonid
    {
        public static string Juku(string nimi)
        {
            string vastus = "";
            string pilet = "";
            if (nimi.ToLower() == "juku")
            {
                try
                {
                    System.Console.Write("Kui vana Juku on: ");
                    byte vanus = byte.Parse(Console.ReadLine());
                    if (vanus > 0 && vanus < 100)
                    {
                        switch (vanus)
                        {
                            case <= 6:
                                pilet = "tasutapilet";
                                break;
                            case <= 14:
                                pilet = "lastepilet";
                                break;
                            case <= 65:
                                pilet = "täispilet";
                                break;
                            case <= 100:
                                pilet = "sooduspilet";
                                break;
                        }
                    vastus = $"{nimi.ToUpper()}, me läheme kinno, sul on vaja {pilet}";
                    }
                    else
                    {
                        vastus = "Vale andmed";
                    }
                }
                catch (Exception e)
                {
                    System.Console.WriteLine(e);
                }
            }
            else
            {
                vastus = "Me läheme kinno ainult Jukuga";
            }
            return vastus;
        }
        public static void Pinginaaber()
        {
            System.Console.Write("Sisestage oma nimi: ");
            string nimi1 = Console.ReadLine();
            System.Console.Write("Sisestage teie sõbra nimi: ");
            string nimi2 = Console.ReadLine();
            System.Console.WriteLine($"{nimi1} ja {nimi2} on täna pinginaabrid!");
        }
        public static void PorandRemont()
        {
            while (true)
            {
                try
                {
                    Console.Write("Mis on põrandi pikkus: ");
                    float pikkus = float.Parse(Console.ReadLine());
                    System.Console.Write("Min on põrandi laius: ");
                    float laius = float.Parse(Console.ReadLine());
                    float pindala = pikkus * laius;
                    System.Console.WriteLine("Põrandi pindala on: {0} m²", pindala);
                    while (true)
                    {
                        System.Console.Write("Kas tahate remondi teha?\n[y/n] ");
                        string valik = Console.ReadLine();
                        if (valik == "y")
                        {
                            System.Console.Write("Siis sisestage kui palju maksab 1m²: ");
                            float maksus = float.Parse(Console.ReadLine());
                            maksus *= pindala;
                            System.Console.WriteLine($"Sinu remond maksab: {Math.Round(maksus, 2)} €");
                            return;
                        }
                        else if (valik == "n")
                        {
                            return;
                        }
                        else
                        {
                            System.Console.WriteLine("Peab olema [y/n]");
                        }
                    }
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Sisestage number, mitte tekst\nVõi proovige ',' asemel '.'");
                }
            }
        }
        public static float AlgHind(float hind)
        {
            Math.Round(hind, 2);
            hind /= 0.7f;
            return hind;
        }
        public static string Temperatuur(float temperatuur)
        {
            if (temperatuur > 12)
            {
                return "Soovitav toasoojus talvel";       
            }
            else
            {
                return "Toasoojus ei soovita";
            }
        }
        public static string InimesePikkus()
        {
            string vastus = "";
            while (true)
            {
                try
                {
                    Console.Write("Kui pikk te olete: ");
                    short pikkus = Convert.ToInt16(Console.ReadLine());
                    if (pikkus > 0)
                    {
                        switch (pikkus)
                        {
                            case < 170:
                                vastus = "Olete lühike";
                                break;
                            case < 185:
                                vastus = "Olete keskmine";
                                break;
                            default:
                                vastus = "Olete pikk";
                                break;
                        }
                        break;
                    }
                    else
                    {
                        System.Console.WriteLine("Te ei saa olla lühikesem kui 0");
                    }
                }
                catch (System.FormatException)
                {
                    System.Console.WriteLine("Sisestage number, mitte tekst\nVõi proovige ',' asemel '.'");
                }
                catch (System.OverflowException)
                {
                    System.Console.WriteLine("Olete liiga pikk");
                }
            }
            return vastus;
        }
        public static void InimesePikkusSugu()
        {
            while (true)
            {
                System.Console.Write("Sisestage oma sugu\n[m/n] ");
                string sugu = Console.ReadLine();
                if (sugu.ToLower() == "m")
                {
                    while (true)
                    {
                        try
                        {
                            System.Console.Write("Kui pikk te olete: ");
                            short pikkus = Convert.ToInt16(Console.ReadLine());
                            if (pikkus > 0)
                            {
                                switch (pikkus)
                                {
                                    case < 170:
                                        System.Console.WriteLine("Olete lühike");
                                        break;
                                    case < 190:
                                        System.Console.WriteLine("Olete keskmine");
                                        break;
                                    default:
                                        System.Console.WriteLine("Olete pikk");
                                        break;    
                                }
                                break;
                            }
                            else
                            {
                                System.Console.WriteLine("Te ei saa olla lühikesem kui 0");
                            }
                        }
                        catch (System.FormatException)
                        {
                            System.Console.WriteLine("Sisestage numbrid, mitte tekst");
                        }
                    }
                    break;
                }
                else if (sugu == "n")
                {
                    while (true)
                    {
                        try
                        {
                            System.Console.Write("Kui pikk te olete: ");
                            short pikkus = Convert.ToInt16(Console.ReadLine());
                            if (pikkus > 0)
                            {
                                switch (pikkus)
                                {
                                    case < 160:
                                        System.Console.WriteLine("Olete lühike");
                                        break;
                                    case < 175:
                                        System.Console.WriteLine("Olete keskmine");
                                        break;
                                    default:
                                        System.Console.WriteLine("Olete pikk");
                                        break;    
                                }
                                break;
                            }
                            else
                            {
                                System.Console.WriteLine("Te ei saa olla lühikesem kui 0");
                            }
                        }
                        catch (System.FormatException)
                        {
                            System.Console.WriteLine("Sisestage numbrid, mitte tekst");
                        }
                    }
                    break;
                }
                else
                {
                    System.Console.WriteLine("Kes te olete?");
                }
            }
        }
        public void Pood()
        {
            
        }
    }
}