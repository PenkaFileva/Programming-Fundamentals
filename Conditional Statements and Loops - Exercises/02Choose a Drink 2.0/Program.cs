using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Choose_a_Drink_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            string profession = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            var price = 0.0;
            switch (profession)
            {
                case "Athlete": price = 0.70; break;
                case "Businessman":
                case "Businesswoman": price = 1.00; break;
                case "SoftUni Student": price = 1.70; break;
                default:
                    price = 1.20;
                    break;
            }
            Console.WriteLine("The {0} has to pay {1:f2}.", profession, quantity*price);
        }
    }
}
