using System;

namespace Snackautomat
{
    public class Menu
    {

        public static void MainMenu()
        {                       
            bool again = true;                  

            do
            {
                try
                {                                                                               //Main Menu
                    Console.Clear();
                    Console.WriteLine("\nLiebe Kundin, lieber Kunde,\nvielen Dank fuer Ihren Besuch! \nSie haben folgende Erfrischungen zur " +
                    "Auswahl:\n\n 1\t-->\tGetraenke\n 2\t-->\tSuesses\n 3\t-->\tPikantes\n 0\t-->\tBeenden"); 
                    int choiceMain = Convert.ToInt32(Console.ReadLine());
                    SubMenuDrinks subMenuDrinks = new SubMenuDrinks();                          //Creat the classes to get access to the methods in those classes                                                                                                
                    SubMenuSweets subMenuSweets = new SubMenuSweets();
                    SubMenuSpicy subMenuSpicy = new SubMenuSpicy();


                    switch (choiceMain)
                    {
                        case 1:
                            Console.Clear();
                            subMenuDrinks.ChooseDrink();                                            //23.11. Ansprechen der Methode                            
                            break;
                        case 2:
                            Console.Clear();
                            subMenuSweets.ChooseSweets();
                            break;
                        case 3:
                            Console.Clear();
                            subMenuSpicy.ChooseSpicy();
                            break;
                        case 0:
                            again = false;
                            Console.WriteLine("Danke fuer Ihren Besuch!\nAuf Wiedersehen");
                            Environment.Exit(0);
                            Console.ReadKey();

                            break;
                    }
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("Falsche Eingabe");
                }

            } while (again);            
                         
            
        }
        

    }
}
