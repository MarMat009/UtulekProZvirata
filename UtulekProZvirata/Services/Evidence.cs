using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtulekProZvirata.Services
{
    internal class Evidence
    {
        public void VypisVsechnaZvirata(List<Zvire> listZvirat)
        {
            Console.WriteLine("\n--- Seznam všech zvířat ---");
            foreach (var zvire in listZvirat)
            {
                Console.WriteLine($"{zvire.Jmeno} ({zvire.Druh}), věk: {zvire.Vek}, adoptováno: {(zvire.Adoptovano ? "ano" : "ne")}");
            }
        }

        public void VypisStatistiky(List<Zvire> listZvirat)
        {
            Console.WriteLine("\n--- Statistiky ---");

            if (listZvirat.Count == 0)
            {
                Console.WriteLine("Žádná zvířata v evidenci.");
                return;
            }

            int celkem = listZvirat.Count;
            int adoptovanych = listZvirat.Count(z => z.Adoptovano);
            int neadoptovanych = celkem - adoptovanych;
            double prumernyVek = listZvirat.Average(z => z.Vek);

            Console.WriteLine($"Celkem zvířat: {celkem}");
            Console.WriteLine($"Adoptovaných: {adoptovanych}");
            Console.WriteLine($"Neadoptovaných: {neadoptovanych}");
            Console.WriteLine($"Průměrný věk: {prumernyVek:F1} let");

            Console.WriteLine("\nPočet zvířat podle druhu:");
            var podleDruhu = listZvirat
                .GroupBy(z => z.Druh)
                .Select(g => new { Druh = g.Key, Pocet = g.Count() });

            foreach (var druh in podleDruhu)
            {
                Console.WriteLine($"{druh.Druh}: {druh.Pocet}");
            }
        }
    }
}
