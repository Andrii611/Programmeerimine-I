using System;
using System.Collections.Generic;
using System.Text;

namespace Osa4
{
    internal class Funktsioon_ItaaliaToit
    {
        static string menuuPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "menuu.txt");
        static List<Menuu> menuuList = new List<Menuu>();

        public static void LaeAndmedFailist()
        {
            Console.WriteLine("laetakse andmeid failist...");
            if (File.Exists(menuuPath))
            {
                string[] osad = File.ReadAllLines(menuuPath);
                foreach (string line in osad)
                {
                    string[] parts = line.Split(';');
                    if (parts.Length == 3)
                    {
                        string nimetus = parts[0];
                        List<string> koostisosad = new List<string>(parts[1].Split(','));
                        double hind = double.Parse(parts[2].Replace('.', ','));
                        Menuu menuuItem = new Menuu(nimetus, koostisosad, hind);
                        menuuList.Add(menuuItem);
                    }
                    Console.WriteLine($"Andmed on edukalt laaditud. Kokku on {menuuList.Count} toitu");
                }
            }
            else
            {
                Console.WriteLine("Andmefaili ei leitud. Palun veenduge, et 'menuu.txt' on olemas. ");
            }
        }
        public static void ItaaliaRestoran()
        {
            Console.Clear();
            Console.WriteLine("Tere tulemast Itaalia restoraani!");
            Console.WriteLine("=================================");
            Console.WriteLine("Menüü:");
            Console.WriteLine("=================================");
            if (menuuList.Count == 0)
            {
                Console.WriteLine("Menüü on tühi. Palun laadige andmed failist.(Valik 1)");
            }
            else
            {
                foreach (Menuu item in menuuList)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Nimetus:{item.Nimetus}"); // Nimetus roheliselt 
                    Console.ResetColor();
                    Console.WriteLine($"Koostisosad: {string.Join(", ", item.Koostisosad)}"); // Koostisosad Tavalise värviga
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Hind: {item.Hind}€"); //Hind punaselt
                    Console.ResetColor();
                    Console.WriteLine("---------------------------------");
                }
            }
        }
        public static void LisaUusToit()
        {
            Console.WriteLine("Sisesta uue toidu info...");
            Console.WriteLine("Nimetus: ");
            string nimetus = Console.ReadLine();
            Console.WriteLine("Koostisosad: ");
            List<string> koostisosad = new List<string>();
            while (true)
            {
                Console.WriteLine("Aine (või vajuta Enter, et Lõpetada):");
                string aine = Console.ReadLine();
                if (string.IsNullOrEmpty(aine))
                {
                    break; // Lõpetame koostisosade sisestamine 
                }
                koostisosad.Add(aine);

            }
            Console.Write("Sisesta hind (nt 12.99): ");
            double hind = double.Parse(Console.ReadLine().Replace('.', ','));
            menuuList.Add(new Menuu(nimetus, koostisosad, hind));
            Console.WriteLine($"Uus toit {nimetus} on menüüsse lisatud!");
        }
        public static void SalvestAndmedFaili()
        {
            Console.WriteLine("Salvestatakse andmed faili...");
            try
            {
                List<string> failiread = new List<string>();
                foreach (Menuu item in menuuList)
                {
                    failiread.Add(item.VormidaFailijaokrea());
                }
                File.WriteAllLines(menuuPath, failiread);
                Console.WriteLine("Andmed on edukalt salvestanud faili");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Andmete salvestamisel tekkis viga: {e.Message}");
            }
        }
        public static void KustutaToit()
        {
            Console.WriteLine("Sisesta kustutava toidu nimetus;");
            string nimetus = Console.ReadLine();
            Menuu itemToRemove = menuuList.Find(item => item.Nimetus.Equals(nimetus, StringComparison.OrdinalIgnoreCase));
            if (itemToRemove != null)
            {
                menuuList.Remove(itemToRemove);
                Console.WriteLine($"Toit {nimetus} on menüüst kustutatud.");
            }
            else
            {
                Console.WriteLine($"Toitu nimega{nimetus} ei leitud menüüst.");
            }
        }
        public static void ToiduInformatsioon()
        {
            Console.WriteLine("Sisesta otsiva toidu nimetus: ");
            string nimetus = Console.ReadLine();
            Menuu itemToShow = menuuList.Find(item => item.Nimetus.Equals(nimetus, StringComparison.OrdinalIgnoreCase));
            if (itemToShow != null)
            {
                Console.WriteLine($"Toit {nimetus} koostab: ");
            }
            else
            {
                Console.WriteLine($"Toitu nimega {nimetus} ei leitud menüüs.");
            }
        }
    }
}
