using System.Net.NetworkInformation;

namespace OOP_Praktikum
{
    internal class StartPage
    {
        static void Main(string[] args)
        {
            List<IKujund> kujundid = new List<IKujund>();
            
            while (true)

            {
                Console.Clear();
                Console.WriteLine("\nFIGUURIDE MENÜÜ ");
                Console.WriteLine("1-ruut \n2-Ring \n3-kolmnurk \n4-ristkülik \n5-Täisnurkne kolmnurk \n0-väljund ja statistika");
                Console.Write("Teie valik: ");
                string valik = Console.ReadLine();

                if (valik == "0") break;

                switch (valik)
                {
                    case "1":
                        Console.Write("Sisesta ruudu külje pikkus: ");
                        string sisend = Console.ReadLine();

                        if (double.TryParse(sisend, out double k)) // Проверка: число ли это?
                        {
                            if (k > 0) // Проверка: подходит ли число для геометрии?
                            {
                                kujundid.Add(new Ruut(k));
                                Console.WriteLine($"Ruut küljega {k} on lisatud!");
                            }
                            else
                            {
                                // Вывод, если число 0 или меньше
                                Console.WriteLine("Viga: Ruudu külg peab olema positiivne arv!");
                            }
                        }
                        else
                        {
                            // Вывод, если ввели "abc" вместо "5"
                            Console.WriteLine(" Viga: '{sisend}' ei ole number!");
                        }
                        break;

                    case "2":
                        Console.Write("Ringi raadius: ");
                        if (double.TryParse(Console.ReadLine(), out double r))
                            kujundid.Add(new Ring(r));
                        else Console.WriteLine("Sisendi viga!");
                        break;

                    case "3":
                        Console.Write("Külg A, B, C (Enter kaudu): ");
                        if (double.TryParse(Console.ReadLine(), out double a) &&
                            double.TryParse(Console.ReadLine(), out double b) &&
                            double.TryParse(Console.ReadLine(), out double c))
                        {
                            var t = new Kolmnurk(a, b, c);
                            if (t.Tüüp != KolmnurgaTüüp.Vigane) kujundid.Add(t);
                            else Console.WriteLine("Selline kolmnurk on võimatu!");
                        }
                        break;

                    case "4":
                        Console.Write("Pikkus ja laius: ");
                        if (double.TryParse(Console.ReadLine(), out double l) &&
                            double.TryParse(Console.ReadLine(), out double w))
                            kujundid.Add(new Ristkülik(l, w));
                        break;

                    case "5":
                        Console.Write("Katet A ja B: ");
                        if (double.TryParse(Console.ReadLine(), out double ka) &&
                            double.TryParse(Console.ReadLine(), out double kb))
                            kujundid.Add(new TäisnurkneKolmnurk(ka, kb));
                        break;

                    default:
                        Console.WriteLine("Vale valik!");
                        break;
                }
            }
        }
    }
}
