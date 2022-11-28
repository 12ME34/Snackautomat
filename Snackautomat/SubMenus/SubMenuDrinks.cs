using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snackautomat
{
    
    internal class SubMenuDrinks   
    {
        
        public void ChooseDrink()
        {
            
            bool again = true;
            while (again)
            {
                try
                {                    
                    Console.Clear();
                    Console.WriteLine("\nLiebe Kundin, lieber Kunde,\nvielen Dank fuer Ihren Besuch! \nSie haben folgende Erfrischungen zur Auswahl:" +
                        "\n\n 1\t-->\tCola\t\t\t"+ FoodAndBaverages.drinks[0].Count+" Stk 0,5l verfuegbar \t  ||\t" + FoodAndBaverages.drinks[1].Count + " Stk 1l verfuegbar" +
                        "\n 2\t-->\tFanta\t\t\t" + FoodAndBaverages.drinks[2].Count + " Stk 0,5l verfuegbar \t  ||\t" + FoodAndBaverages.drinks[3].Count + " Stk 1l verfuegbar" +
                        "\n 3\t-->\tMineralwasser\t\t" + FoodAndBaverages.drinks[4].Count + " Stk 0,5l verfuegbar \t  ||\t" + FoodAndBaverages.drinks[5].Count + " Stk 1l verfuegbar" +
                        "\n 4\t-->\tEistee\t\t\t" + FoodAndBaverages.drinks[6].Count + " Stk 0,5l verfuegbar \t  ||\t" + FoodAndBaverages.drinks[7].Count + " Stk 1l verfuegbar\n"+
                        " 0\t-->\tRetour");
                    //Main menu
                    int choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            Console.Clear();
                            SizeOfDrink(choice);
                            again = false;
                            new Menu();

                            break;
                        case 2:
                            Console.Clear();
                            SizeOfDrink(choice);
                            again = false;
                            new Menu();

                            break;
                        case 3:
                            Console.Clear();
                            SizeOfDrink(choice);
                            again = false;
                            new Menu();

                            break;
                        case 4:
                            Console.Clear();
                            SizeOfDrink(choice);
                            again = false;
                            new Menu();                         
                            break;
                        case 0:
                            again = false;
                            break;
                     
                    }
                    

                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("Falsche Eingabe");
                }
            }
        }

        public void SizeOfDrink(int choice)
        {
            ShoppingBasket shoppingBasket = new ShoppingBasket();
            int counter = -1;
            int sizeOfBottle = 0;
            int indexDrink = counter + choice + (choice - 1);
            int indexOfBottle = 0;            
            bool check = true;
            do
            {
                try
                {
                    Console.WriteLine("\nDruecke 1 fuer ein " + FoodAndBaverages.drinks[indexDrink].Name + " 0,5l   \t\t" + FoodAndBaverages.drinks[indexDrink].Count+ " Stk verfuegbar\n"+
                        "Druecke 2 fuer ein " + FoodAndBaverages.drinks[indexDrink].Name + " 1,0l   \t\t" + FoodAndBaverages.drinks[indexDrink+1].Count + " Stk verfuegbar");

                    int sizeOf = Convert.ToInt32(Console.ReadLine());
                    if (sizeOf == 1 || sizeOf == 2)
                    {
                        check = false;
                        if (sizeOf == 2)
                        {
                            sizeOfBottle = 1;
                        }
                    }
                    Console.Clear();
                    
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("Bitte geben Sie die korrekte Auswahl ein");
                }

            } while (check);
            indexOfBottle = sizeOfBottle + counter + choice + (choice - 1);
            
            if (FoodAndBaverages.drinks[indexOfBottle].Count == 0)
            {
                Console.WriteLine(FoodAndBaverages.drinks[indexOfBottle].Name + " ist aktuell nicht verfuegbar!\nBitte waehlen Sie einen anderen Artikel");
                System.Threading.Thread.Sleep(4000);
            }
            else if(FoodAndBaverages.drinks[indexOfBottle].Count > 0)
            {
                FoodAndBaverages.drinks[indexOfBottle].Count = FoodAndBaverages.drinks[indexOfBottle].Count - 1;        //Anzahl der Getränke in der Liste wird aktualisiert                
                shoppingBasket.FillShoppingBasketDrink(indexOfBottle);
            }                                                                                                     
            
            
        }
    }
}
