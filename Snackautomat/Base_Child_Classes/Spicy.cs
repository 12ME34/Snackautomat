namespace Snackautomat
{
    internal class Spicy : Snacks
    {
        public double Weight { get; set; }
        public int Carbonhydrats { get; set; }
        public Spicy(string name, double price, int calories, int count, double weight, int carbonhydrats) : base(name, price, calories, count)
        {
            Weight = weight;
            Carbonhydrats = carbonhydrats;
        }       
        
    }
}
