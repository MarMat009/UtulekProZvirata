using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace UtulekProZvirata.UI
{
    internal class KonzoleUI
    {

        

         public string UI()
        {
            string uvodmsg_odpověď = "";
            Console.Write( @"=-=-= Útulek pro zvířata =-=-= 
1) Přidat zvíře 
2) Vypsat všechna zvířata
3) Vyhledat/filtrovat
4) Označit adopci
5) Statistiky
0) Konec

Volba: "); 

            uvodmsg_odpověď =  Console.ReadLine();
            return uvodmsg_odpověď;
            
        }

        public string pridatzvire()
        {
            //id = automatic, jmeno, druh, vek, pohlavi, kastrovanost, datum prijmu, zdravotnistav, poznamka
            string pridatzvire = "";
            Console.WriteLine("=-=-= Útulek pro zvířata =-=-= ");
            Console.WriteLine("Zadejte ID: ");
            pridatzvire += Console.ReadLine() + "|";
            Console.WriteLine("Zadejte jmeno: ");
            pridatzvire += Console.ReadLine() + "|";
            Console.WriteLine("Zadejte druh: ");
            pridatzvire += Console.ReadLine() + "|";
            Console.WriteLine("Zadejte vek: ");
            pridatzvire += Console.ReadLine() + "|";
            Console.WriteLine("Zadejte pohlaví: ");
            pridatzvire += Console.ReadLine() + "|";
            Console.WriteLine("Zadejte jestli byl kastovaný (ano/ne): ");
            pridatzvire +="Kasrovaný = "+ Console.ReadLine()  +"|";
            Console.WriteLine("Zadejte dnešní datum: ");
            pridatzvire += Console.ReadLine() + "|";
            Console.WriteLine("Zadejte zdravotni stav: ");
            pridatzvire += Console.ReadLine() + "|";
            Console.WriteLine("Zadejte poznámku (nepovinné): ");
            pridatzvire += Console.ReadLine();


            return pridatzvire;
        }

        static string vypsat_zvirata()
        {
            //dělá se v evidence
            string vypsat_zvirata = "";

            return vypsat_zvirata;
        }


        static string vyhledat_zvirata()
        {
            string vyhledat_zvire = "";
            int choice = 0;
            Console.Write(@"=-=-= Útulek pro zvířata =-=-=
Filtrovat podle:
1) ID
2) Jmena
3) Druhu
4) Věku
5) Pohlaví
6) Kastrovanosti
7) Datumu příjmu
8) Zdravotního stavu

0) Zpět

Volba: ");
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                choice = int.Parse(Console.ReadLine());
                vyhledat_zvire += choice + "|";
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Zadej ID: ");
                        vyhledat_zvire += Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine("Zadej jméno: ");
                        vyhledat_zvire += Console.ReadLine();
                        break;
                    
                    case 3:
                        Console.WriteLine("Zadej Druh: ");
                        vyhledat_zvire += Console.ReadLine();
                        break;

                    case 4:
                        Console.WriteLine("Zadej věk: ");
                        vyhledat_zvire += Console.ReadLine();
                        break;

                    case 5:
                        Console.WriteLine("Zadej pohlaví: ");
                        vyhledat_zvire += Console.ReadLine();
                        break;

                    case 6:
                        Console.WriteLine("Zadej Kastrovanost (ano/ne: ");
                        vyhledat_zvire += "kastrovanost: "+ Console.ReadLine();
                        break;

                    case 7:
                        Console.WriteLine("Zadej datum příjmu: ");
                        vyhledat_zvire += Console.ReadLine();
                        break;
                    case 8:
                        Console.WriteLine("Zadej zdravotní stav: ");
                        vyhledat_zvire += Console.ReadLine();
                        break;
                    case 0:

                        break;
                }
            }
            else
            {
                Console.WriteLine("Špatný input");
            }

                return vyhledat_zvire;
        }

        static string Označit_adopci()
        {
            //dělá se v evidence
            string adopce = "";

            return adopce;
        }
    }
}
