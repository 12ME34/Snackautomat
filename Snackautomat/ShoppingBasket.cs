using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snackautomat
{
    internal class ShoppingBasket
    {
        
        public List<ShoppingBasket> shoppingBasket = new List<ShoppingBasket>();
        
            public string Name { get; set; }
            public double Price { get; private set; }
            public int Calories { get; set; }
            public double IngedientFour { get; set; }
            public int IngedientFive { get; set; }

        public ShoppingBasket(string name, double price, int calories, double ingredientFour, int ingredientFive)
            {
                Name = name;
                Price = price;
                Calories = calories;
                IngedientFour =ingredientFour;
                IngedientFive = ingredientFive;
            }

        public ShoppingBasket()
        {
        }
        public void FillShoppingBasketSweets(int indexOf)
        {
            shoppingBasket.Add(new ShoppingBasket(FoodAndBaverages.sweets[indexOf].Name, FoodAndBaverages.sweets[indexOf].Price, FoodAndBaverages.sweets[indexOf].Calories, 
                FoodAndBaverages.sweets[indexOf].Weight, FoodAndBaverages.sweets[indexOf].Sugar));            
            Console.WriteLine("Ausgabe ShoppingBasket " + shoppingBasket[0].Price);           
        }
        public void FillShoppingBasketSpicy(int indexOf)
        {
            shoppingBasket.Add(new ShoppingBasket(FoodAndBaverages.spicy[indexOf].Name, FoodAndBaverages.spicy[indexOf].Price, FoodAndBaverages.spicy[indexOf].Calories,
                FoodAndBaverages.spicy[indexOf].Weight, FoodAndBaverages.spicy[indexOf].Carbonhydrats));
            Console.WriteLine("Ausgabe ShoppingBasket " + shoppingBasket[0].Price);
        }
        public void FillShoppingBasketDrink(int indexOf)
        {
            shoppingBasket.Add(new ShoppingBasket(FoodAndBaverages.drinks[indexOf].Name, FoodAndBaverages.drinks[indexOf].Price, FoodAndBaverages.drinks[indexOf].Calories,
                FoodAndBaverages.drinks[indexOf].Size, FoodAndBaverages.drinks[indexOf].Sugar));
            Console.WriteLine("Ausgabe ShoppingBasket " + shoppingBasket[0].Price);
        }
    }
    
}
