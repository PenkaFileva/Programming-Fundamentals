using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08Upgraded_Matcher
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] products = Console.ReadLine().Split().ToArray();
            decimal[] quantities = Console.ReadLine().Split().Select(decimal.Parse).ToArray();
            decimal[] price = Console.ReadLine().Split().Select(decimal.Parse).ToArray();


            var text = Console.ReadLine();
            while (text != "done")
            {
                var command = text.Split().ToArray();
                var command1 = command[0];
                var currentQuantitie = decimal.Parse(command[1]);

                int index = Array.IndexOf(products, command1);
                var quantitiesL = quantities.Length;
                if (index >= quantitiesL)
                {                   
                    quantities = new decimal[quantitiesL + index];
                    for (int i = 0; i < index; i++)
                    {
                        quantities[quantitiesL - 1 + i] = 0;
                    }                   
                }
                if (quantities[index] >= currentQuantitie)
                {
                    Console.WriteLine($"{products[index]} x {currentQuantitie} costs {(price[index] * currentQuantitie):f2}");
                    quantities[index] -= currentQuantitie;
                }
                else
                {
                    Console.WriteLine($"We do not have enough {products[index]}");
                }              
                text = Console.ReadLine();
            }
        }
    }
}
