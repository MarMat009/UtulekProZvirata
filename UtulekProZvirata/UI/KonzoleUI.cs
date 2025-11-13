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

        

        static string uvodmsg()
        {
            //toto vypiš s console.write ne s console.writeline
            string uvodmsg = @"=-=-= Útulek pro zvířata =-=-= 
1) Přidat zvíře 
2) Vypsat všechna zvířata
3) Vyhledat/filtrovat
4) Označit adopci
5) Statistiky
0) Konec

Volba: "; 
            return uvodmsg;
            
        }

        static string pridatzvire()
        {
            //id = automatic, jmeno, druh, vek, pohlavi, kastrovanost, datum prijmu, zdravotnistav, poznamka
            string pridatzvire = "";

            Console.WriteLine("Zadejte jmeno: ");
            pridatzvire += Console.ReadLine() + ", ";
            Console.WriteLine("Zadejte druh: ");
            pridatzvire += Console.ReadLine() + ", ";
            Console.WriteLine("Zadejte vek: ");
            pridatzvire += Console.ReadLine() + ", ";
            Console.WriteLine("Zadejte pohlaví: ");
            pridatzvire += Console.ReadLine() + ", ";
            Console.WriteLine("Zadejte jestli byl kastovaný (ano/ne): ");
            pridatzvire +="Kasrovaný = "+ Console.ReadLine()  +", ";
            Console.WriteLine("Zadejte dnešní datum: ");
            pridatzvire += Console.ReadLine() + ", ";
            Console.WriteLine("Zadejte zdravotni stav: ");
            pridatzvire += Console.ReadLine() + ", ";
            Console.WriteLine("Zadejte poznámku (nepovinné): ");
            pridatzvire += Console.ReadLine();


            return pridatzvire;
        }
    }
}
