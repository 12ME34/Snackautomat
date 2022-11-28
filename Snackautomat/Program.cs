using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Snackautomat
{
    
    internal class Program
    {
        

        static public void Main(string[] args)
        {
            new FoodAndBaverages();
            Menu.MainMenu();            
            Console.ReadKey();
            
        }
    }
}
