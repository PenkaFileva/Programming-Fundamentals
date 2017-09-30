using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08House_Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            long price1 = long.Parse(Console.ReadLine());
            long price2 = long.Parse(Console.ReadLine());

            long maxPrice = Math.Max(price1, price2);
            long minPrice = Math.Min(price1, price2);

            long priceMaterialsOfHouse = 4 * minPrice + 10 * maxPrice;
            Console.WriteLine(priceMaterialsOfHouse);
        }
    }
}
