﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snackautomat
{
    internal class Sweets : Snacks
    {
        public double Weight { get; set; }
        public int Sugar { get; set; }

        public Sweets(string name, double price, int calories, double weight, int sugar) : base(name, price, calories)
        {
            Weight = weight;
            Sugar = sugar;
        }
    }
}
