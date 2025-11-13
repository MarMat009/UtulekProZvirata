using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using UtulekProZvirata.Model;
using UtulekProZvirata.UI;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;

namespace UtulekProZvirata
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //start up
            KonzoleUI konzoleui = new KonzoleUI();

            //import dat z excelu do listu
            /*
            string projectFolder = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory)
                                          .Parent.Parent.Parent.FullName;

            // 🧾 Název souboru
            
            string filePath = Path.Combine(projectFolder, "data.xlsx");

            using (SpreadsheetDocument document = SpreadsheetDocument.Create(filePath, SpreadsheetDocumentType.Workbook))
            {
                // workbook = kniha
                WorkbookPart workbookPart = document.AddWorkbookPart();
                workbookPart.Workbook = new Workbook();

                // worksheet = list
                WorksheetPart worksheetPart = workbookPart.AddNewPart<WorksheetPart>();
                SheetData sheetData = new SheetData();

                // vytvoření řádku s jednou buňkou
                Row row = new Row() { RowIndex = 1 };
                Cell cell = new Cell()
                {
                    CellReference = "A1",
                    DataType = CellValues.String,
                    CellValue = new CellValue("Hello OpenXML!")
                };

                row.Append(cell);
                sheetData.Append(row);
                worksheetPart.Worksheet = new Worksheet(sheetData);

                // přidání listu do sešitu
                Sheets sheets = workbookPart.Workbook.AppendChild(new Sheets());
                Sheet sheet = new Sheet();
                sheet.Id = workbookPart.GetIdOfPart(worksheetPart);
                sheet.SheetId = 1;
                sheet.Name = "List1";
                sheets.Append(sheet);

                workbookPart.Workbook.Save();
            }

            Console.WriteLine("✅ Soubor úspěšně vytvořen!");
            */

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
                        Console.WriteLine(ListZvirat[ListZvirat.Count - 1].ReturnDatumPrijmu());
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
        static string GetValue(WorkbookPart wbPart, Cell cell)
        {
            if (cell.DataType != null && cell.DataType == CellValues.SharedString)
            {
                var sst = wbPart.SharedStringTablePart.SharedStringTable;
                return sst.ChildElements[int.Parse(cell.InnerText)].InnerText;
            }
            return cell.InnerText;
        }
    }
    }
