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
        private bool Adoptovan;

        public Zvire(int Id, string Jmeno, string Druh, int Vek, string Pohlavi, bool Kastrovanost, string DatumPrijmu, string ZdravotniStav, string Poznamka)
        {
            this.Id = Id;
            this.Jmeno = Jmeno;
            this.Druh = Druh;
            this.Vek = Vek;
            this.Pohlavi = Pohlavi;
            this.Kastrovanost = Kastrovanost;
            this.DatumPrijmu = DatumPrijmu;
            this.ZdravotniStav = ZdravotniStav;
            this.Poznamka = Poznamka;
            Adoptovan = false;
        }
        public Zvire(int Id, string Jmeno, string Druh, int Vek, string Pohlavi, bool Kastrovanost, string ZdravotniStav, string Poznamka)
        {
            this.Id = Id;
            this.Jmeno = Jmeno;
            this.Druh = Druh;
            this.Vek = Vek;
            this.Pohlavi = Pohlavi;
            this.Kastrovanost = Kastrovanost;
            DatumPrijmu = DateTime.Now.ToString("dd.MM.yyyy");
            this.ZdravotniStav = ZdravotniStav;
            this.Poznamka = Poznamka;
            Adoptovan = false;
        }



        // Metody pro vracení informací o zvířeti

        public override string ToString()
        {
            return "{Id}§{Jmeno}§{Druh}§{Vek}§{Pohlavi}§{Kastrovanost}§{DatumPrijmu}§{ZdravotniStav}§{Poznamka}";
        }
        public int ReturnId()
        {
            return Id;
        }
        public string ReturnJmeno()
        {
            return Jmeno;
        }
        public string ReturnDruh()
        {
            return Druh;
        }
        public int ReturnVek()
        {
            return Vek;
        }
        public string ReturnPohlavi()
        {
            return Pohlavi;
        }
        public bool ReturnKastrovanost()
        {
            return Kastrovanost;
        }
        public string ReturnZdravotniStav()
        {
            return ZdravotniStav;
        }
        public string ReturnPoznamka()
        {
            return Poznamka;
        }



        // Metody pro měnění informací o zvířeti

        public void Zestarnout(int zmena)
        {
            Vek += zmena;
        }
        public void ZestarnoutORok()
        {
            Vek += 1;
        }
        public void Vykastrovat()
        {
            Kastrovanost = true;
        }
        public void ZmenZdravotniStav(string zmena)
        {
            ZdravotniStav = zmena;
        }
        public void ZmenPoznamka(string zmena)
        {
            Poznamka = zmena;
        }
    }
}
