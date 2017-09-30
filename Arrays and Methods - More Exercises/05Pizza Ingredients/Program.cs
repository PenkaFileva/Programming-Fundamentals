using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05Pizza_Ingredients
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nameIngredients = Console.ReadLine().Split(' ').ToArray();
            int maxLengthIngredient = int.Parse(Console.ReadLine());
            int count = 0;
            List<string>  ingredients= new List<string>();
            for (int i = 0; i < nameIngredients.Length; i++)
            {
                if (nameIngredients[i].Length == maxLengthIngredient)
                {
                    Console.WriteLine($"Adding {nameIngredients[i]}.");
                    count++;
                    ingredients.Add (nameIngredients[i]);
                }
                if (count >= 10)
                {
                    break;
                }
            }

            //string[] ingredient = ingredients.Split().ToArray();
            //Console.WriteLine(String.Join(", ", ingredient));
            Console.WriteLine($"Made pizza with total of {count} ingredients.");
            Console.WriteLine($"The ingredients are: {String.Join(", ", ingredients)}.");
        }
    }
}
