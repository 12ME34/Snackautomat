using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snackautomat
{
    internal class Menu
    {
        public Menu()
        {
            //Input of drinks            
            new FoodAndBaverages();           


            Console.WriteLine("\nLiebe Kundin, lieber Kunde,\nvielen Dank fuer Ihren Besuch! \nSie haben folgende Erfrischungen zur Auswahl:\n\n 1\t-->\tGetraenke\n 2\t-->\tSuesses\n 3\t-->\tPikantes\n 4\t-->\tBeenden"); //Main menu
            int choiceMain = Convert.ToInt32(Console.ReadLine());

            switch (choiceMain)
            {
                case 1:
                    Console.Clear();
                    ChoiceDrinks();             //23.11. Ansprechen der Methode
                    break;
            }

        }

        
    }
}
