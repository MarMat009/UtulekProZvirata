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
            string pridatzvire_jmeno = "";
            string pridatzvire_druh = "";
            string pridatzvire_vek = "";

            return pridatzvire_jmeno;
            return pridatzvire_vek;
            return pridatzvire_druh;
        }
    }
}
