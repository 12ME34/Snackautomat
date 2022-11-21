using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snackautomat
{
    internal class Menu
    {
        public Menu()
        {


            Program.drinks.Add(new Drinks() { Name = "Cola", Size = 0.5, Price = 1.25, Calories = 500, Sugar = 100 });
            Program.drinks.Add(new Drinks() { Name = "1 l Cola", Size = 1.0, Price = 2.40, Calories = 1000, Sugar = 200 });
            Program.drinks.Add(new Drinks() { Name = "Fanta", Size = 0.5, Price = 1.25, Calories = 500, Sugar = 100 });
            Program.drinks.Add(new Drinks() { Name = "1 l Fanta", Size = 1.0, Price = 2.40, Calories = 1000, Sugar = 200 });
            Program.drinks.Add(new Drinks() { Name = "Mineralwasser", Size = 0.5, Price = 1.40, Calories = 0, Sugar = 0 });
            Program.drinks.Add(new Drinks() { Name = "1 l Mineralwasser", Size = 1.0, Price = 2.80, Calories = 0, Sugar = 0 });
            Program.drinks.Add(new Drinks() { Name = "Eistee", Size = 0.5, Price = 1.40, Calories = 350, Sugar = 95 });
            Program.drinks.Add(new Drinks() { Name = "1 l Eistee", Size = 1.0, Price = 2.80, Calories = 700, Sugar = 190 });            




            bool nochmal = true;
            while (nochmal)
            {
                try
                {
                    Console.WriteLine("\n\nAuswahl:\n 1\tCola\n 2\tFanta\n 3\tMineralwasser\n 4\tEistee\n 0\tBeenden");
                    int auswahl = Convert.ToInt32(Console.ReadLine());
                    switch (auswahl)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine("\nDruecke 1 fuer ein Cola 0,5l \nDruecke 2 fuer ein Cola 1,0l");
                            int sizeCola = Convert.ToInt32(Console.ReadLine());
                            if (sizeCola == 1)                            
                            {
                                int product = 0;                                // product = 0 -> an welcher Stelle in der Liste das Produkt XY gespeichert ist
                                Payment.payment(product);                         
       
                            }else if(sizeCola == 2)
                            {
                                int product = 1;                               
                                Payment.payment(product);

                            }
                            break;
                        case 2:
                            Console.Clear();
                            Console.WriteLine("\nDruecke 1 fuer ein Fanta 0,5l \nDruecke 2 fuer ein Fanta 1,0l");
                            int sizeFanta = Convert.ToInt32(Console.ReadLine());
                            if (sizeFanta == 1)
                            {
                                int product = 2;                                
                                Payment.payment(product);

                            }
                            else if (sizeFanta == 2)
                            {
                                int product = 3;                                
                                Payment.payment(product);
                            }
                            break;
                        case 3:
                            Console.Clear();
                            Console.WriteLine("\nDruecke 1 fuer ein Mineralwasser 0,5l \nDruecke 2 fuer ein Mineralwasser 1,0l");
                            int sizeMineralwasser = Convert.ToInt32(Console.ReadLine());
                            if (sizeMineralwasser == 1)
                            {
                                int product = 4;                                
                                Payment.payment(product);

                            }
                            else if (sizeMineralwasser == 2)
                            {
                                int product = 5;                                
                                Payment.payment(product);
                            }
                            break;
                        case 4:
                            Console.Clear();
                            Console.WriteLine("\nDruecke 1 fuer ein Eistee 0,5l \nDruecke 2 fuer ein Eistee 1,0l");
                            int sizeIcetea = Convert.ToInt32(Console.ReadLine());
                            if (sizeIcetea == 1)
                            {
                                int product = 6;                                
                                Payment.payment(product);

                            }
                            else if (sizeIcetea == 2)
                            {
                                int product = 7;                               
                                Payment.payment(product);
                            }
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
