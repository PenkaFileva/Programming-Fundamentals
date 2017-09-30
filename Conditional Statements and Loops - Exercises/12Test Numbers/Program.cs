using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12Test_Numbers
{
    class Program
    {
        static void Main(string[] args)

        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int maxSum = int.Parse(Console.ReadLine());
            int totalSum = 0;
            int combinations = 0;
            for (int i = n; i >= 1; i--)
            {
                for (int j = 1; j <= m; j++)
                {
                    int sum = 3 * (i * j);
                    if (totalSum < maxSum)
                    {
                        totalSum += sum;
                        combinations += 1;
                    }
                    else if (totalSum >= maxSum)
                    {
                        break;
                    }
                }
            }
            if (totalSum >= maxSum)
            {
                Console.WriteLine("{0} combinations", combinations);
                Console.WriteLine($"Sum: {totalSum} >= {maxSum}");
            }
            else
            {
                Console.WriteLine("{0} combinations", combinations);
                Console.WriteLine($"Sum: {totalSum}");
            }
        }
    }
}
