using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtulekProZvirata.Model
{
    internal class Zvire
    {
        private int Id;
        private string Jmeno;
        private string Druh;
        private int Vek;
        private string Pohlavi;
        private bool Kastrovanost;
        private string DatumPrijmu;
        private string ZdravotniStav;
        private string Poznamka;

        public Zvire(string Jmeno, string Druh, int Vek, string Pohlavi, bool Kastrovanost, string DatumPrijmu, string ZdravotniStav, string Poznamka)
        {
            int i = Program.ListZvirat.Count;
            Id = Program.ListZvirat[i]+1;
            this.Jmeno = Jmeno;
            this.Druh = Druh;
            this.Vek = Vek;
            this.Pohlavi = Pohlavi;
            this.Kastrovanost = Kastrovanost;
            this.DatumPrijmu = DatumPrijmu;
            this.ZdravotniStav = ZdravotniStav;
            this.Poznamka = Poznamka;
        }
        public Zvire(string Jmeno, string Druh, int Vek, string Pohlavi, bool Kastrovanost, string ZdravotniStav, string Poznamka)
        {
            int i = Program.ListZvirat.Count;
            Id = Program.ListZvirat[i] + 1;
            this.Jmeno = Jmeno;
            this.Druh = Druh;
            this.Vek = Vek;
            this.Pohlavi = Pohlavi;
            this.Kastrovanost = Kastrovanost;
            DatumPrijmu = DateTime.Now.ToString("dd.MM.yyyy");
            this.ZdravotniStav = ZdravotniStav;
            this.Poznamka = Poznamka;
        }
    }
}
