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
        public static List<Drinks> drinks = new List<Drinks>();

        static public void Main(string[] args)
        {
            Console.WriteLine("Snackautomat [Start]\n");
            

            new Menu();
           
            

        }
    }
}
