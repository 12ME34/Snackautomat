using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snackautomat
{
    internal class SubMenuDrinks   {


        public void ChoiceDrinks()
        {
            bool again = true;
            while (again)
            {
                try
                {
                    Console.WriteLine("\nLiebe Kundin, lieber Kunde,\nvielen Dank fuer Ihren Besuch! \nSie haben folgende Erfrischungen zur Auswahl:\n\n 1\t-->\tCola\n 2\t-->\tFanta\n 3\t-->\tMineralwasser\n 4\t-->\tEistee\n 0\t-->\tBeenden"); //Main menu
                    int choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            Console.Clear();
                            SizeOfDrink(choice);

                            break;
                        case 2:
                            Console.Clear();
                            SizeOfDrink(choice);

                            break;
                        case 3:
                            Console.Clear();
                            SizeOfDrink(choice);

                            break;
                        case 4:
                            Console.Clear();
                            SizeOfDrink(choice);

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

    
        public void SizeOfDrink(int choice)
        {
            int counter = -1;
            int sizeOfBottle = 0;
            bool check = true;
            do
            {
                try
                {
                    Console.WriteLine("\nDruecke 1 fuer ein " + FoodAndBaverages.drinks[counter + choice + (choice - 1)].Name + " 0,5l \nDruecke 2 fuer ein " + FoodAndBaverages.drinks[counter + choice + (choice - 1)].Name + " 1,0l");

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
                    Console.WriteLine("Bitte geben Sie die korrekte Auswahl ein");
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("Bitte geben Sie die korrekte Auswahl ein");
                }

            } while (check);
            Payment.Cashout(counter + choice + (choice - 1) + sizeOfBottle);      //The call is now dynamic, the list of drinks can be enhanced infinite unless there are always 0,5 and 1l bottles                   
        }                                                                       //Ich muss es erneut programmieren, Liste soll auf Speicherplatz untersucht werden!!!

    }
}
