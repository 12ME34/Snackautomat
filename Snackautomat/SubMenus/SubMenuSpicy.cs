using System;

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
                                                        //Sub Menu spicy
                    Console.Clear();
                    Console.WriteLine("\nLiebe Kundin, lieber Kunde,\nvielen Dank fuer Ihren Besuch! \nSie haben folgende Erfrischungen zur " +
                        "Auswahl:\n\n" +
                        " 1\t-->\tChips\t\t\t " + FoodAndBaverages.spicy[0].Count + " Stk verfuegbar\n" +
                        " 2\t-->\tSalamibrot\t\t " + FoodAndBaverages.spicy[1].Count + " Stk verfuegbar\n" +
                        " 3\t-->\tErdnuesse\t\t " + FoodAndBaverages.spicy[2].Count + " Stk verfuegbar\n" +
                        " 4\t-->\tStreichkaese\t\t " + FoodAndBaverages.spicy[3].Count + " Stk verfuegbar\n" +
                        " 0\t-->\tRetour"); 
                    int choice = Convert.ToInt32(Console.ReadLine());                    
                    
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
                            again = false;
                            break;
                    }
                }
                catch
                {
                    Console.Clear();
                   
                }
            }
        }
        public void WhichSpicy(string choice)                                           //Search in the list for the choosen item to get its index
        {
            ShoppingBasket shoppingBasket = new ShoppingBasket();
            int i = 0;
            int indexOfSpicy = 0;
            foreach (var swe in FoodAndBaverages.spicy)                                 //All items of list will be searched by the choice of the customer(Chips, Peanutes,...)
            {
                
                if (swe.Name == choice)
                {                    
                    indexOfSpicy = i;                                                   //Index of the item in the list
                }
                i++;
            }
          

            if (FoodAndBaverages.spicy[indexOfSpicy].Count == 0)                        //Check if the chosen item is still in the vending machine
            {
                Console.WriteLine(FoodAndBaverages.spicy[indexOfSpicy].Name + " ist aktuell nicht verfuegbar!\nBitte waehlen Sie einen anderen Artikel");
                System.Threading.Thread.Sleep(4000);
            }
            else if (FoodAndBaverages.spicy[indexOfSpicy].Count > 0)
            {
                FoodAndBaverages.spicy[indexOfSpicy].Count = FoodAndBaverages.spicy[indexOfSpicy].Count - 1;        
                shoppingBasket.FillShoppingBasketSpicy(indexOfSpicy);
            }
        }
    }
}
