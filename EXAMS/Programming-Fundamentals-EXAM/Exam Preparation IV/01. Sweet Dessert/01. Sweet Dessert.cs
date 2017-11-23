using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Sweet_Dessert
{
    class Program
    {
        static void Main(string[] args)
        {
            var availableAmount = double.Parse(Console.ReadLine());
            var numberOfGuests = long.Parse(Console.ReadLine());
            var priceOfBananasForSingleUnit = double.Parse(Console.ReadLine());
            var priceOfEggsForSingleUnit = double.Parse(Console.ReadLine());
            var priceOfBerriesForKilo = double.Parse(Console.ReadLine());

            var numOfDessert = (int)Math.Ceiling(numberOfGuests / 6.0);
            var priceOfProducts = numOfDessert * (2 * priceOfBananasForSingleUnit) + numOfDessert*(4 * priceOfEggsForSingleUnit) +
                                  numOfDessert*(0.2 * priceOfBerriesForKilo);
            
            //var diff = availableAmount - priceOfProducts;
            if (availableAmount >= priceOfProducts)
            {
                Console.WriteLine("Ivancho has enough money - it would cost {0:f2}lv.", priceOfProducts);   
            }
            else
            {
                Console.WriteLine("Ivancho will have to withdraw money - he will need {0:f2}lv more.", (priceOfProducts-availableAmount));
            }
            
        }
    }
}
