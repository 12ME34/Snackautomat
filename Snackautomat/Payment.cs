using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Snackautomat
{
    
    public class Payment
    {
        

        public static void Cashier(double totalPrice)
        {
 
            double totalInsertedMoney = 0;
            double insertedMoney = 0;
            
            Console.Clear();
                Console.WriteLine("Der komplette Betrag Ihres Einkaus ist " + totalPrice);
            do
            {
                try
                {
                    
                    Console.WriteLine("\n\nDer Automat nimmt folgende Scheine und Muenzen entgegen:\n" +
                        "5 und 10 Euro Scheine\n" +
                        "2 Euro, 1 Euro, 50 Cent, 20 Cent, 10 Cent, 5 Cent");

                    do
                    {
                        insertedMoney = Convert.ToDouble(Console.ReadLine());
                        if (insertedMoney==10|| insertedMoney == 5 || insertedMoney == 2 || insertedMoney == 1 || insertedMoney == 0.50 || insertedMoney == 0.20 ||
                            insertedMoney == 0.10 || insertedMoney == 0.05)
                        {
                            totalInsertedMoney = totalInsertedMoney + insertedMoney;
                            if (totalInsertedMoney < totalPrice)
                            {
                                Console.WriteLine("Sie muessen noch " + (totalPrice - totalInsertedMoney) + " Euro einwerfen");
                            }
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("\nDer Automat nimmt folgende Scheine und Muenzen entgegen:\n" +
                            "5 und 10 Euro Scheine\n" +
                            "2 Euro, 1 Euro, 50 Cent, 20 Cent, 10 Cent, 5 Cent");
                            Console.WriteLine("\nDer komplette Betrag Ihres Einkaus ist " + totalPrice);
                            Console.WriteLine("Sie muessen noch " + (totalPrice - totalInsertedMoney) + " Euro einwerfen");
                        }
                        
                    } while (totalInsertedMoney < totalPrice);
                    Console.WriteLine("Ihr Restgeld betraegt " + Math.Round((totalInsertedMoney - totalPrice), 2) + "\nVielen Dank fuer Ihren Einkauf");
                    System.Threading.Thread.Sleep(5000);
                    ShoppingBasket.shoppingBasket.Clear();                  //After the payment, the shoppingBasket List will be deleted
                }
                catch
                {
                    Console.WriteLine("Bitte geben Sie die gueltigen Zahlungsmoeglichkeiten ein");
                }
            } while (totalInsertedMoney < totalPrice);            

        }
    }
}
