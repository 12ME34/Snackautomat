using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snackautomat
{
    internal class Spicy : Snacks
    {
        public double Weight;
        public int Carbonhydrats;
        public Spicy(string name, double price, int calories, double weight, int carbonhydrats) : base(name, price, calories)
        {
            Weight = weight;
            Carbonhydrats = carbonhydrats;
        }
    }
}
