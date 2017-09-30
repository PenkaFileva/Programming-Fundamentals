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

            int index = 0;
            bool isFound = false;
            for (int i = arr.Length-1; i >= 0; i--)
            {
                if (arr[i] == num)
                {
                    index = i;
                    isFound = true;
                    break;
                }
            }
            long sum = 0;
            if (isFound)
            {
                for (int i = 0; i < index; i++)
                {
                    sum += arr[i];
                }
                Console.WriteLine(sum);
            }
            else
            {
                Console.WriteLine("No occurrences were found!");
            }

        }
    }
}
