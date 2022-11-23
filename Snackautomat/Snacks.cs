using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snackautomat
{
    internal abstract class Snacks {
        public string Name { get; set; }        
        public double Price { get; private set; }
        public int Calories { get; set; }        

        public Snacks(string name, double price, int calories )
        {
            Name = name;            
            Price = price;
            Calories = calories;         

        }

        
    }

}
    

