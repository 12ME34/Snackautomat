using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snackautomat
{
    class Drinks
    {
        
        public Drinks(string name, double size, double price, int calories, int sugar)
        {
            Name = name;
            Size= size;
            Price = price;
            Calories = calories;
            Sugar = sugar;

        }
        public string Name { get; set; }
        public double Size { get; set; }
        public double Price { get; private set; }
        public int Calories { get; set; }
        public int Sugar { get; set; }


    }   
}
    

