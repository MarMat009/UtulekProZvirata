using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtulekProZvirata.Model;
using UtulekProZvirata.UI;

namespace UtulekProZvirata
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //start up

            //import dat z excelu do listu
            List<Zvire> ListZvirat =  new List<Zvire>();
            ListZvirat.Add(new Zvire(1,"pes","pes",5,"M",true,"dnes","dobrý","nic"));
            //ListZvirat.Add(new Zvire());
            //ListZvirat.Add(new Zvire());

            bool Bezi = false;
            Console.WriteLine(ListZvirat.Count);
            Console.ReadLine();
            //spustit while loop
            //volani KonzoleUI.cs
            while (Bezi)
            {
                int rozhodnuti = 0;
                //int rozhodnuti = int.Parse(KonzoleUI.UI());
               switch (rozhodnuti)
                {
                    case 1:
                        //pridat zviře pomoci Zvire.cs
                        break;
                    case 2:
                        //vypsat vsechna zvirata pomoci
                      break;
                    case 3:
                        //vyhledat/filtrovat pomoci
                        break;
                    case 4:
                        //oznacit adopci pomoci
                        break;
                    case 5:
                        //statistiky pomoci
                        break;
                    case 0:
                        Bezi = false;
                        break;
                }
            }

            //ukoncovani
                //export do excelu
            
        }
    }
}
