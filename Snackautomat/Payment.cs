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
        public Payment() {
                       
        
        }
        //public static double cashInput(double input)
        //{

        //    Console.WriteLine("\n\nAchtung! Automat nimmt zur Zeit ausschließlich 5 oder 10 Euro Scheine!\nMit welchem Schein möchten Sie bezahlen?");
        //    double bankNote = Convert.ToDouble(Console.ReadLine());
        //    return bankNote;
        //}
        public static void payment(int product)
        {
            
            Console.WriteLine(Program.drinks[product].Name + "\t\t" + Program.drinks[product].Price + "\tEuro" + "\n\t\t" + Program.drinks[product].Calories + "\tKalorien" + "\n\t\t" + Program.drinks[product].Sugar + "g \tZucker");
            Console.WriteLine("\n\nAchtung! Automat nimmt zur Zeit ausschließlich 5 oder 10 Euro Scheine!\nMit welchem Schein möchten Sie bezahlen?");
            double bankNote = Convert.ToDouble(Console.ReadLine());            
            double price = Program.drinks[product].Price;
            double change = bankNote-price;
            Console.WriteLine("Ihr Restgeld betraegt " + change);
        }
        
        


    }
}
