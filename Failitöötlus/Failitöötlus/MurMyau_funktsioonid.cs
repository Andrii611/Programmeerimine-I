﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Text;
namespace osa4ülesanded
{
    public class funktsioonid
    {
        // 1
        public static void lemmiktoiduSalvestamine()
        {
            try
            {
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Retseptid.txt");
                StreamWriter retsept = new StreamWriter(path, true);
                Console.WriteLine("Sisesta üks Itaalia toidu nimi");
                string lause = Console.ReadLine();
                retsept.WriteLine(lause);
                retsept.Close();
            }
            catch (Exception)
            {
                Console.WriteLine("Viga failiga!");
            }

        }
        // 2
        public static void menuuKuvamine()
        {
            try
            {
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Retseptid.txt");
                StreamReader text = new StreamReader(path);
                string laused = text.ReadToEnd();
                text.Close();
                Console.WriteLine(laused);
            }
            catch (Exception)
            {
                Console.WriteLine("Mingi viga failiga, ei saa faili lugeda");
            }
        }

        // 3
        public static void KoostisosadeMuutmine()
        {
            try
            {
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Koostisosad.txt");
                foreach (string rida in File.ReadAllLines(path))
                {
                    List<string> koostisosadlist = new List<string>();
                    string[] koostisosad = rida.Split(", ");

                    foreach (string i in koostisosad)
                    {
                        koostisosadlist.Add(i);
                    }

                    if (koostisosadlist.Count > 0)
                        koostisosadlist[0] = "Kvaliteetne oliiviõli";

                    for (int i = koostisosadlist.Count - 1; i >= 0; i--)
                    {
                        if (koostisosadlist[i].ToLower() == "ketšup")
                        {
                            koostisosadlist.RemoveAt(i);
                            Console.WriteLine("Kustutasime ketšupi koostisosast!");
                        }
                    }
                    foreach (string koostiosa in koostisosadlist)
                        Console.WriteLine(koostiosa);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Viga! {e}");
            }

        }

        public static void otsingListist()
        {
            
        }
    }
}
