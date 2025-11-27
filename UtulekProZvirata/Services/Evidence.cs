using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtulekProZvirata.Model;

namespace UtulekProZvirata.Services
{
    public class Evidence
    {
        // Výpis všech zvířat
        public void VypisVsechnaZvirata(List<Zvire> listZvirat)
        {
            Console.WriteLine("\n--- Seznam všech zvířat ---");

            if (listZvirat.Count == 0)
            {
                Console.WriteLine("Žádná zvířata nejsou v evidenci.");
                return;
            }

            foreach (var z in listZvirat)
            {
                Console.WriteLine($"ID: {z.ReturnId()} | {z.ReturnJmeno()} ({z.ReturnDruh()}), věk: {z.ReturnVek()}, adoptováno: {(z.ReturnAdoptovan() ? "ano" : "ne")}");
            }
        }

        // Vyhledávání nebo filtrování zvířat
        public void VyhledatZvirata(List<Zvire> listZvirat)
        {
            Console.WriteLine("\n--- Vyhledávání / filtrování ---");
            if (listZvirat.Count == 0)
            {
                Console.WriteLine("V evidenci nejsou žádná zvířata.");
                return;
            }

            Console.WriteLine("Zadej hledaný text (jméno, druh, nebo část slova): ");
            string hledanyText = Console.ReadLine().ToLower();

            var vysledky = listZvirat
                .Where(z => z.ReturnJmeno().ToLower().Contains(hledanyText) ||
                            z.ReturnDruh().ToLower().Contains(hledanyText))
                .ToList();

            if (vysledky.Count == 0)
            {
                Console.WriteLine("Nebylo nalezeno žádné zvíře odpovídající filtru.");
                return;
            }

            Console.WriteLine($"\nNalezeno {vysledky.Count} zvířat:");
            foreach (var z in vysledky)
            {
                Console.WriteLine($"ID: {z.ReturnId()} | {z.ReturnJmeno()} ({z.ReturnDruh()}), věk: {z.ReturnVek()}, adoptováno: {(z.ReturnAdoptovan() ? "ano" : "ne")}");
            }
        }

        // Statistiky
        public void VypisStatistiky(List<Zvire> listZvirat)
        {
            Console.WriteLine("\n--- Statistiky ---");

            if (listZvirat.Count == 0)
            {
                Console.WriteLine("Žádná zvířata v evidenci.");
                return;
            }

            int celkem = listZvirat.Count;
            int adoptovanych = listZvirat.Count(z => z.ReturnAdoptovan());
            int neadoptovanych = celkem - adoptovanych;
            double prumernyVek = listZvirat.Average(z => z.ReturnVek());

            Console.WriteLine($"Celkem zvířat: {celkem}");
            Console.WriteLine($"Adoptovaných: {adoptovanych}");
            Console.WriteLine($"Neadoptovaných: {neadoptovanych}");
            Console.WriteLine($"Průměrný věk: {prumernyVek:F1} let");

            Console.WriteLine("\nPočet zvířat podle druhu:");
            var podleDruhu = listZvirat
                .GroupBy(z => z.ReturnDruh())
                .Select(g => new { Druh = g.Key, Pocet = g.Count() });

            foreach (var druh in podleDruhu)
            {
                Console.WriteLine($"{druh.Druh}: {druh.Pocet}");
            }
        }
    }
}
