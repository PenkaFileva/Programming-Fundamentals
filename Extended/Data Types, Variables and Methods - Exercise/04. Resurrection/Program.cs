using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Resurrection
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var length = long.Parse(Console.ReadLine());
                var width = decimal.Parse(Console.ReadLine());
                var wing = long.Parse(Console.ReadLine());
                var totalYears = length * length * (width + (2 * wing));
                Console.WriteLine(totalYears);
            }
        }
    }
}
