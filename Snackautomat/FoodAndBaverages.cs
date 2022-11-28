using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snackautomat
{
    
    internal class FoodAndBaverages
    {
        public static List<Drinks> drinks = new List<Drinks>();
        public static List<Sweets> sweets = new List<Sweets>();
        public static List<Spicy> spicy = new List<Spicy>();

        public FoodAndBaverages()
        {            
            drinks.Add(new Drinks("Cola", 1.75, 500, 5, 0.5, 100));            //0     //1
            drinks.Add(new Drinks("1l Cola", 3.10, 1000, 5, 1.0, 200));        //1
            drinks.Add(new Drinks("Fanta", 1.55, 500, 5, 0.5, 100));           //2     //2
            drinks.Add(new Drinks("1l Fanta", 3.10, 1000, 5, 1.0, 200));       //3
            drinks.Add(new Drinks("Mineralwasser", 2.0, 0, 5, 0.5, 0));        //4     //3
            drinks.Add(new Drinks("1l Mineralwasser", 4.0, 0, 5, 1.0, 0));     //5
            drinks.Add(new Drinks("Eistee", 1.95, 350, 5, 0.5, 95));           //6     //4
            drinks.Add(new Drinks("1l Eistee", 3.70, 700, 5, 1.00, 190));      //7
            
            sweets.Add(new Sweets("Mars", 1.10, 210, 5, 80, 100));
            sweets.Add(new Sweets("Snickers", 1.20, 220, 5, 85, 110));
            sweets.Add(new Sweets("Bounty", 1.30, 230, 5, 90, 120));
            sweets.Add(new Sweets("Twix", 1.40, 240, 5, 95, 120));

            spicy.Add(new Spicy("Chips", 1.20, 250, 5, 80, 100));
            spicy.Add(new Spicy("Salamibrot", 2.50, 50, 5, 125, 2));
            spicy.Add(new Spicy("Erdnuesse", 3.00, 500, 5, 250, 72));
            spicy.Add(new Spicy("Streichkaese", 1.75, 75, 5, 50, 3));
     
        }

    }
}
