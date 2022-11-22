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
            //Input of drinks

            Program.drinks.Add(new Drinks("Cola", 0.5, 1.75, 500, 100 ));
            Program.drinks.Add(new Drinks("1l Cola", 1.0, 3.40, 1000, 200 ));
            Program.drinks.Add(new Drinks("Fanta", 0.5, 1.55, 500,  100 ));
            Program.drinks.Add(new Drinks("1l Fanta", 1.0, 3.10,  1000,  200 ));
            Program.drinks.Add(new Drinks("Mineralwasser", 0.5,  2.40,  0,  0 ));
            Program.drinks.Add(new Drinks( "1 l Mineralwasser",  4.2,  2.80,  0,  0 ));
            Program.drinks.Add(new Drinks("Eistee",  0.5, 1.40,  350,  95 ));
            Program.drinks.Add(new Drinks("1l Eistee",  1.0,  2.80,  700,  190 ));            


            bool nochmal = true;
            while (nochmal)
            {
                try
                {
                    Console.WriteLine("\n\nAuswahl:\n 1\t-->\tCola\n 2\t-->\tFanta\n 3\t-->\tMineralwasser\n 4\t-->\tEistee\n 0\t-->\tBeenden"); //Main menu
                    int auswahl = Convert.ToInt32(Console.ReadLine());
                    switch (auswahl)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine("\nDruecke 1 fuer ein Cola 0,5l \nDruecke 2 fuer ein Cola 1,0l");
                            int sizeCola = Convert.ToInt32(Console.ReadLine());
                            if (sizeCola == 1)                            
                            {
                                int product = 0;                                // product = 0 -> is the position of the drink in the list. In this case "0,5 cola"
                                Payment.Cashout(product);                         
       
                            }else if(sizeCola == 2)
                            {
                                int product = 1;                               
                                Payment.Cashout(product);

                            }
                            break;
                        case 2:
                            Console.Clear();
                            Console.WriteLine("\nDruecke 1 fuer ein Fanta 0,5l \nDruecke 2 fuer ein Fanta 1,0l");
                            int sizeFanta = Convert.ToInt32(Console.ReadLine());
                            if (sizeFanta == 1)
                            {
                                int product = 2;                                
                                Payment.Cashout(product);

                            }
                            else if (sizeFanta == 2)
                            {
                                int product = 3;                                
                                Payment.Cashout(product);
                            }
                            break;
                        case 3:
                            Console.Clear();
                            Console.WriteLine("\nDruecke 1 fuer ein Mineralwasser 0,5l \nDruecke 2 fuer ein Mineralwasser 1,0l");
                            int sizeMineralwasser = Convert.ToInt32(Console.ReadLine());
                            if (sizeMineralwasser == 1)
                            {
                                int product = 4;                                
                                Payment.Cashout(product);

                            }
                            else if (sizeMineralwasser == 2)
                            {
                                int product = 5;                                
                                Payment.Cashout(product);
                            }
                            break;
                        case 4:
                            Console.Clear();
                            Console.WriteLine("\nDruecke 1 fuer ein Eistee 0,5l \nDruecke 2 fuer ein Eistee 1,0l");
                            int sizeIcetea = Convert.ToInt32(Console.ReadLine());
                            if (sizeIcetea == 1)
                            {
                                int product = 6;                                
                                Payment.Cashout(product);

                            }
                            else if (sizeIcetea == 2)
                            {
                                int product = 7;                               
                                Payment.Cashout(product);
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
