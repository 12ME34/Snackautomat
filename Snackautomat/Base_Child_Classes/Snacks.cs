namespace Snackautomat
{
    internal abstract class Snacks 
    {
        public string Name { get; set; }        
        public double Price { get; private set; }
        public int Calories { get; set; }   
        public int Count { get; set; }  

        public Snacks(string name, double price, int calories, int count)
        {
            Name = name;
            Price = price;
            Calories = calories;
            Count = count;
        }     


    }
    

}
    

