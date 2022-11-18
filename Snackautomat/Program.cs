using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Snackautomat
{
    internal class Program
    {
        //private static void inhaltsstoffeCola()
        //{

        //}
        //private static void cola()
        //{
        //    string auswahl;           
            
        //        Console.WriteLine("Taste 1 = Cola 0,5 für 2,50,-\nTaste 2 = Cola 1l für 4,-");
        //        auswahl = Console.ReadLine();
        //        if (auswahl == "1")
        //    {
        //        Console.WriteLine("Sie haben sich fuer 0,5 Cola zum Preis von 2,50,- entschieden\nFolgende Inhaltsstoffe sind enthalten\n");
        //    }        

        //}
        static void Main(string[] args)
        {
            Console.WriteLine("Snackautomat [Start]\n");
            List<Drinks> drinks = new List<Drinks>();
            drinks.Add(new Drinks() { Name = "Cola", Size = 0.5, Price = 1.25, Calories = 500, Sugar = 100 });
            drinks.Add(new Drinks() { Name = "1 l Cola", Size = 1.0, Price = 2.40, Calories = 1000, Sugar = 200 });
            drinks.Add(new Drinks() { Name = "Fanta", Size = 0.5, Price = 1.25, Calories = 500, Sugar = 100 });
            drinks.Add(new Drinks() { Name = "1 l Fanta", Size = 1.0, Price = 2.40, Calories = 1000, Sugar = 200 });
            drinks.Add(new Drinks() { Name = "Mineralwasser", Size = 0.5, Price = 1.40, Calories = 0, Sugar = 0 });
            drinks.Add(new Drinks() { Name = "1 l Mineralwasser", Size = 1.0, Price = 2.80, Calories = 0, Sugar = 0 });
            drinks.Add(new Drinks() { Name = "Ice Tea", Size = 0.5, Price = 1.40, Calories = 350, Sugar = 95 });
            drinks.Add(new Drinks() { Name = "1 l Ice Tea", Size = 1.0, Price = 2.80, Calories = 700, Sugar = 190 });
            



            bool nochmal = true;
            while (nochmal)
            {
                try
                {
                    Console.WriteLine("Auswahl:\n 1\tCola\n 2\tFanta\n 3\tMineralwasser\n 4\tEistee\n 0\tAbbruch");
                    int auswahl = Convert.ToInt32(Console.ReadLine());
                    switch (auswahl)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine("\nDruecke 1 fuer ein Cola 0,5l \nDruecke 2 fuer ein Cola 1,0l");
                            int sizeCola = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine(drinks.Count);
                            
                            break;
                        case 2:
                            Console.Clear();
                            Console.WriteLine("\nDruecke 1 fuer ein Fanta 0,5l \nDruecke 2 fuer ein Fanta 1,0l");
                            int sizeFanta = Convert.ToInt32(Console.ReadLine());
                            break;
                        case 3:
                            Console.Clear();
                            Console.WriteLine("\nDruecke 1 fuer ein Mineralwasser 0,5l \nDruecke 2 fuer ein Mineralwasser 1,0l");
                            int sizeMineralwasser = Convert.ToInt32(Console.ReadLine());
                            break;
                        case 4:
                            Console.Clear();
                            Console.WriteLine("\nDruecke 1 fuer einen Eistee 0,5l \nDruecke 2 fuer einen Eistee 1,0l");
                            int sizeEistee = Convert.ToInt32(Console.ReadLine());
                            break;                        
                        case 0:
                            Console.WriteLine("Auf Wiedersehen");
                            nochmal = false;
                            break;
                    }

                }
                catch
                {
                    Console.WriteLine("Falsche Eingabe");
                }
            }
            
            
                


        }
    }
}
