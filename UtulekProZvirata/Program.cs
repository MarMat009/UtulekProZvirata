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
            KonzoleUI konzoleui = new KonzoleUI();
            //import dat z excelu do listu
            List<Zvire> ListZvirat =  new List<Zvire>();
            ListZvirat.Add(new Zvire(1,"pes","pes",5,"M",true,"dnes","dobrý","nic"));
            //ListZvirat.Add(new Zvire());
            //ListZvirat.Add(new Zvire());

            bool Bezi = true;
            //spustit while loop
            //volani KonzoleUI.cs
            while (Bezi)
            {
                //int rozhodnuti = 0;
                int rozhodnuti = int.Parse(konzoleui.UI());
               switch (rozhodnuti)
                {
                    case 1:
                        string prefab = konzoleui.pridatzvire();
                        string[] hodnoty = prefab.Split(',');
                        bool kastrace = false;
                        if (hodnoty[4] == "ano")
                        {
                            kastrace = true;
                        }
                        if (hodnoty[5] != "")
                        {
                            ListZvirat.Add(new Zvire(ListZvirat.Count + 1, hodnoty[0], hodnoty[1], int.Parse(hodnoty[2]), hodnoty[3], kastrace, hodnoty[5], hodnoty[6], hodnoty[7]));
                        }
                        else
                        {
                            ListZvirat.Add(new Zvire(ListZvirat.Count + 1, hodnoty[0], hodnoty[1], int.Parse(hodnoty[2]), hodnoty[3], kastrace,hodnoty[6], hodnoty[7]));
                        }
                        Console.WriteLine(ListZvirat[ListZvirat.Count - 1].ReturnId());
                        Console.WriteLine(ListZvirat[ListZvirat.Count - 1].ReturnJmeno());
                        Console.WriteLine(ListZvirat[ListZvirat.Count - 1].ReturnDruh());
                        Console.WriteLine(ListZvirat[ListZvirat.Count - 1].ReturnVek());
                        Console.WriteLine(ListZvirat[ListZvirat.Count - 1].ReturnPohlavi());
                        Console.WriteLine(ListZvirat[ListZvirat.Count - 1].ReturnKastrovanost());
                        //Console.WriteLine(ListZvirat[ListZvirat.Count - 1].);
                        Console.WriteLine(ListZvirat[ListZvirat.Count - 1].ReturnZdravotniStav());
                        Console.WriteLine(ListZvirat[ListZvirat.Count - 1].ReturnPoznamka());
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
