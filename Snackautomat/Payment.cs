using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Snackautomat
{
    
    internal class Payment
    {
        

        public static void Cashout(int product)                              //product =  the position of the ordered drink in the list
        {

            bool check = true;
            Console.WriteLine("\n\n" +  FoodAndBaverages.drinks[product].Name + "\n\t\t" + FoodAndBaverages.drinks[product].Price + "\tEuro" + "\n\t\t" + FoodAndBaverages.drinks[product].Calories + "\tKalorien" + "\n\t\t" + FoodAndBaverages.drinks[product].Sugar + "g \tZucker");
            Console.WriteLine("\n\nAchtung! Automat nimmt zur Zeit ausschließlich 5 oder 10 Euro Scheine!\nMit welchem Schein möchten Sie bezahlen?");
            do
            {
                try
                {                    
                    double bankNote = Convert.ToDouble(Console.ReadLine());
                    if(bankNote == 5 || bankNote == 10)
                    {
                        check = false;                                          //correct bill inserted, boolean is set false so that while loop finishes
                        double price = FoodAndBaverages.drinks[product].Price;
                        double change = bankNote - price;
                        Console.WriteLine("Ihr Restgeld betraegt " + Math.Round(change, 2));
                    }
                    else
                    {
                        Console.WriteLine("Der Automat nimmt aktuell nur 5 Euro oder 10 Euro Scheine");
                    }
                    
                }catch
                {
                    Console.WriteLine("\nFalsche Eingabe! Bitte nur 5 und 10 Euro Noten");
                }
            }while(check);
        }
    }
}
