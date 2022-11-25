using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snackautomat
{
    internal class SubMenuSweets
    {
        public void ChooseSweets()
        {
            bool again = true;
            while (again)
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("\nLiebe Kundin, lieber Kunde,\nvielen Dank fuer Ihren Besuch! \nSie haben folgende Erfrischungen zur " +
                        "Auswahl:\n\n 1\t-->\tMars\n 2\t-->\tSnickers\n 3\t-->\tBounty\n 4\t-->\tTwix\n 0\t-->\tRetour"); //Main menu
                    int choice = Convert.ToInt32(Console.ReadLine());
                    //Liste durchsuchen
                    //Eine Liste anlegen in der die items variabel sind!!!
                    

                    switch (choice)
                    {
                        case 1:
                            Console.Clear();
                            WhichSweet("Mars");
                            again = false;
                            break;
                        case 2:
                            Console.Clear();
                            WhichSweet("Snickers");
                            again = false;
                            break;
                        case 3:
                            Console.Clear();
                            WhichSweet("Bounty");
                            again = false;
                            break;
                        case 4:
                            Console.Clear();
                            WhichSweet("Twix");
                            again = false;
                            break;
                        case 0:                            
                            again = false;
                            break;
                    }
                }
                catch
                {
                    Console.WriteLine("Falsche Eingabe");
                }
            }
        }
        public void WhichSweet(string choice)
        {
            ShoppingBasket shoppingBasket = new ShoppingBasket();
            //SubMenuSweets subMenuSweets = new SubMenuSweets();
            int i = 0;
            int indexOfSweet = 0;
            foreach (var swe in FoodAndBaverages.sweets)
            {
               
                if (swe.Name == choice)
                {                    
                    indexOfSweet=i;                    
                }
                i++;
            }
            Console.WriteLine("Ein " + FoodAndBaverages.sweets[indexOfSweet].Name + " kostet " + FoodAndBaverages.sweets[indexOfSweet].Price + " Euro");
            shoppingBasket.FillShoppingBasketSweets(indexOfSweet);
            // shoppingBasket.shoppingBasket.Add(FoodAndBaverages.sweets[indexOfSweet].Name + FoodAndBaverages.sweets[indexOfSweet].Price + FoodAndBaverages.sweets[indexOfSweet].Calories + FoodAndBaverages.sweets[indexOfSweet].Weight + FoodAndBaverages.sweets[indexOfSweet].Sugar);

        }
    }
}
