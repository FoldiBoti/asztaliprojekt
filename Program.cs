using System;
using System.Collections.Generic;
using System.IO;

namespace FilmProjekt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Film> filmek = new List<Film>();
            foreach (string sor in File.ReadAllLines("film.txt"))
            {
                filmek.Add(new Film(sor));
            }

            Console.WriteLine($"1. feladat: A fájl {filmek.Count} film adatait tartalmazza.");

            Console.Write("2. feladat: Add meg a műfajt: ");
            string keresettMufaj = Console.ReadLine();

            Console.WriteLine($"{keresettMufaj} műfajú filmek:");
            foreach (var f in filmek)
            {
                if (f.Mufaj == keresettMufaj)
                {
                    Console.WriteLine($"  - {f.Cim} ({f.Ev})");
                }
            }

            Console.WriteLine("3. feladat: A filmek adatai:");
            foreach (var f in filmek)
            {
                Console.WriteLine($"{f.Cim} - {f.Mufaj}, {f.Ev}, {f.Hossz} perc, értékelés: {f.Ertekeles}/10");
            }

            List<Film> hosszabbak = new List<Film>();
            foreach (var f in filmek)
            {
                if (f.Hossz > 120) 
                {
                    hosszabbak.Add(f);
                }
            }

            using (StreamWriter sw = new StreamWriter("hosszabb.txt"))
            {
                foreach (var f in hosszabbak)
                {
                    sw.WriteLine($"{f.Cim};{f.Mufaj};{f.Ev};{f.Hossz};{f.Ertekeles}");
                }
            }

            Console.WriteLine("4. feladat: A hosszabb filmek adatai a 'hosszabb.txt' fájlba kerültek.");
        }
    }
}