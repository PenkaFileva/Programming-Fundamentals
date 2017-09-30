using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05Rounding_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] num = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            int[] roundedNums = new int[num.Length];
            for (int i = 0; i < num.Length; i++)
            {
                roundedNums[i] = (int)Math.Round(num[i], MidpointRounding.AwayFromZero);
                Console.WriteLine($"{num[i]} => {roundedNums[i]}");
                
            }

        }
    }
}
