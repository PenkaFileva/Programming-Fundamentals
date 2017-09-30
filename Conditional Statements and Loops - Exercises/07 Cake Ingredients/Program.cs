using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Cake_Ingredients
{
    class Program
    {
        static void Main(string[] args)
        {
            string ingredients = Console.ReadLine();
            var countIngredients = 0;
            while (true)
            {
                if (ingredients == "Bake!")
                {
                    Console.WriteLine($"Preparing cake with {countIngredients} ingredients.");
                    break;
                }
                else
                {
                    Console.WriteLine($"Adding ingredient {ingredients}.");
                    countIngredients += 1;
                    ingredients = Console.ReadLine();

                }
            }
        }
    }
}
