using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08Calories_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            int ingredientsNum = int.Parse(Console.ReadLine());
            int totalCaloriesAmount = 0;
            for (int i = 1; i <= ingredientsNum; i++)
            {
                string ingredients = Console.ReadLine().ToLower().Trim();
                switch (ingredients)
                {
                    case "cheese":totalCaloriesAmount += 500; break;
                    case "tomato sauce":totalCaloriesAmount += 150;break;
                    case "salami":totalCaloriesAmount += 600; break;
                    case "pepper":totalCaloriesAmount += 50;break;
                    default:
                        break;
                }
            }
            Console.WriteLine("Total calories: {0}", totalCaloriesAmount);
        }
    }
}
