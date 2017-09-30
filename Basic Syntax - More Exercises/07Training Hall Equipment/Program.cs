using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07Training_Hall_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int num = int.Parse(Console.ReadLine());
            var subtotal = 0.0;
            for (int i = 1; i <= num; i++)
            {
                string itemName = Console.ReadLine();
                double itemPrice = double.Parse(Console.ReadLine());
                int itemCount = int.Parse(Console.ReadLine());
                subtotal += (itemPrice * itemCount);
                if (itemCount > 1)
                {
                    itemName += "s";
                }
                Console.WriteLine("Adding {0} {1} to cart.", itemCount, itemName);
            }
            if (budget>= subtotal)
            {
                Console.WriteLine("Subtotal: ${0:f2}", subtotal);
                Console.WriteLine("Money left: ${0:f2}", (budget - subtotal));
            }
            else if (budget < subtotal)
            {
                Console.WriteLine("Subtotal: ${0:f2}", subtotal);
                Console.WriteLine("Not enough. We need ${0:f2} more.", subtotal - budget);
            }
        }
    }
}
