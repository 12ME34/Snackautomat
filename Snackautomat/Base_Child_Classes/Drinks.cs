﻿namespace Snackautomat
{
    internal class Drinks : Snacks
    {
        public Drinks(string name, double price, int calories, int count, double size, int sugar) : base(name, price, calories, count)
        {
            Size = size;
            Sugar = sugar;
        }

        public double Size { get; set; }
        public int Sugar { get; set; }
              

    }

}
