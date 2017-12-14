using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Raindrops
{
    class Program
    {
        static void Main(string[] args)
        {
            var amountOfRegions = int.Parse(Console.ReadLine());
            var density = decimal.Parse(Console.ReadLine());

            decimal regionalCoefficientSum = 0M;
            for (int i = 0; i < amountOfRegions; i++)
            {
                var input = Console.ReadLine().Split(' ');
                var raindropsCount = decimal.Parse(input[0]);
                var squareMeters = decimal.Parse(input[1]);
                var regionalCoefficient = raindropsCount / squareMeters;
                regionalCoefficientSum += regionalCoefficient;
            }
            if (density <= 0)
            {
                Console.WriteLine($"{regionalCoefficientSum:F3}");
            }
            else
            {
                var result = regionalCoefficientSum / density;
                Console.WriteLine($"{result:F3}");
            }
            
           
        }
    }
}
