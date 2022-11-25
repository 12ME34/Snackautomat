using System;

namespace Snackautomat
{
    internal class MenuBase
    {
        public void Menu()
        {
            bool again = true;
            //Input of drinks            
            new FoodAndBaverages();
            //!!!!!Input Absicherung nicht vergessen!!!!!!!!
            do
            {
                try
                {
                    Console.WriteLine("\nLiebe Kundin, lieber Kunde,\nvielen Dank fuer Ihren Besuch! \nSie haben folgende Erfrischungen zur " +
                    "Auswahl:\n\n 1\t-->\tGetraenke\n 2\t-->\tSuesses\n 3\t-->\tPikantes\n 0\t-->\tBeenden"); //Main menu
                    int choiceMain = Convert.ToInt32(Console.ReadLine());
                    SubMenuDrinks subMenuDrinks = new SubMenuDrinks();                          //Um eine Mothode einer anderen Klasse aufzurufen muss ein Objekt dieser Klasse erzeugt werden
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
                            break;
                    }
                }
                catch
                {
                    Console.WriteLine("Falsche Eingabe");
                }

            } while (again);


        }
    }
}