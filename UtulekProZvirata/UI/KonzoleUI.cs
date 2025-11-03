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

        

        static string UI()
        {
            string uvodmsg = @"=-=-= Útulek pro zvířata =-=-= 
1) Přidat zvíře 
2) Vypsat všechna zvířata
3) Vyhledat/filtrovat
"; 
            return uvodmsg;
        }
    }
}
