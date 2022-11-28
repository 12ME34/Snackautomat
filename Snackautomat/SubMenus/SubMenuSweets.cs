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
                        "Auswahl:\n\n " +
                        "1\t-->\tMars\t\t " + FoodAndBaverages.sweets[0].Count +" Stk verfuegbar"+"\n " + 
                        "2\t-->\tSnickers\t " + FoodAndBaverages.sweets[1].Count + " Stk verfuegbar" + "\n " +
                        "3\t-->\tBounty\t\t " + FoodAndBaverages.sweets[2].Count + " Stk verfuegbar" + "\n " +
                        "4\t-->\tTwix\t\t " + FoodAndBaverages.sweets[3].Count + " Stk verfuegbar" + "\n " +
                        "0\t-->\tRetour"); 
          
                    int choice = Convert.ToInt32(Console.ReadLine());
                    
                    

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
        public void WhichSweet(string choice)                   //Liste durchsuchen
                                                                //Eine Liste anlegen in der die items variabel sind!!!
        {
            ShoppingBasket shoppingBasket = new ShoppingBasket();
            
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

            if (FoodAndBaverages.sweets[indexOfSweet].Count == 0)
            {
                Console.WriteLine(FoodAndBaverages.sweets[indexOfSweet].Name + " ist aktuell nicht verfuegbar!\nBitte waehlen Sie einen anderen Artikel");
                System.Threading.Thread.Sleep(4000);
            }
            else if (FoodAndBaverages.sweets[indexOfSweet].Count > 0)
            {
                FoodAndBaverages.sweets[indexOfSweet].Count = FoodAndBaverages.sweets[indexOfSweet].Count - 1;        //Anzahl der Getränke in der Sweets wird aktualisiert
                
                shoppingBasket.FillShoppingBasketSweets(indexOfSweet);
            }
           
        }
    }
}
