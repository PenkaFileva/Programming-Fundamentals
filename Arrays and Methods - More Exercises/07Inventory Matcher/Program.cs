using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07Inventory_Matcher
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] products = Console.ReadLine().Split().ToArray();
            long[] quantities = Console.ReadLine().Split().Select(long.Parse).ToArray();
            decimal[] price = Console.ReadLine().Split().Select(decimal.Parse).ToArray();
            var command = Console.ReadLine();
            while (command != "done")
            {
                int index = Array.IndexOf(products, command);
                Console.WriteLine($"{products[index]} costs: {price[index]}; Available quantity: {quantities[index]}");
                command = Console.ReadLine();
            }
        }
    }
}
