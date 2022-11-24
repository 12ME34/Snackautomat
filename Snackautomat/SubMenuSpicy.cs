using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snackautomat
{
    internal class SubMenuSpicy
    {
        public void ChooseSpicy()
        {
            bool again = true;
            while (again)
            {
                try
                {
                    Console.WriteLine("\nLiebe Kundin, lieber Kunde,\nvielen Dank fuer Ihren Besuch! \nSie haben folgende Erfrischungen zur " +
                        "Auswahl:\n\n 1\t-->\tChips\n 2\t-->\tSalamibrot\n 3\t-->\tErdnuesse\n 4\t-->\tStreichkaese\n 0\t-->\tBeenden"); //Main menu
                    int choice = Convert.ToInt32(Console.ReadLine());
                    //Liste durchsuchen
                    //Eine Liste anlegen in der die items variabel sind!!!
                    switch (choice)
                    {
                        case 1:
                            Console.Clear();
                            WhichSpicy("Chips");
                            again = false;
                            break;
                        case 2:
                            Console.Clear();
                            WhichSpicy("Salamibrot");
                            again = false;
                            break;
                        case 3:
                            Console.Clear();
                            WhichSpicy("Erdnuesse");
                            again = false;
                            break;
                        case 4:
                            Console.Clear();
                            WhichSpicy("Streichkaese");
                            again = false;
                            break;
                        case 0:
                            Console.WriteLine("Auf Wiedersehen");
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
        public void WhichSpicy(string choice)
        {
            ShoppingBasket shoppingBasket = new ShoppingBasket();
            int i = 0;
            int indexOfSpicy = 0;
            foreach (var swe in FoodAndBaverages.spicy)
            {
                
                if (swe.Name == choice)
                {
                    Console.WriteLine(i);
                    indexOfSpicy = i;
                }
                i++;
            }
            Console.WriteLine("Ein " + FoodAndBaverages.spicy[indexOfSpicy].Name + " kostet " + FoodAndBaverages.spicy[indexOfSpicy].Price + " Euro");
            shoppingBasket.FillShoppingBasketSpicy(indexOfSpicy);
            // shoppingBasket.shoppingBasket.Add(FoodAndBaverages.sweets[indexOfSweet].Name + FoodAndBaverages.sweets[indexOfSweet].Price + FoodAndBaverages.sweets[indexOfSweet].Calories + FoodAndBaverages.sweets[indexOfSweet].Weight + FoodAndBaverages.sweets[indexOfSweet].Sugar);

        }
    }
}
