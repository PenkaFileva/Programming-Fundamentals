using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04Grab_and_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] arr = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            long num = long.Parse(Console.ReadLine());

            long sum = 0;
            long currentSum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == num)
                {
                    sum += currentSum;
                    currentSum = 0;
                }
                currentSum += arr[i];
            }
            if (sum != 0)
            {
                Console.WriteLine(sum);
            }
            else
            {
                Console.WriteLine("No occurrences were found!");
            }
            
        }
    }
}
