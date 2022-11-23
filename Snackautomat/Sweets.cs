using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snackautomat
{
    internal class Sweets : Snacks
    {
        public double Weight;
        public double Sugar;

        public Sweets(string name, double price, int calories, double weight, double sugar) : base(name, price, calories)
        {
            Weight = weight;
            Sugar = sugar;
        }
    }
}
