using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07Max_Sequence_of_Increasing_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var bestIndex = 0;
            var bestLength = 0;

            var currentIndex = 0;
            var currentLength = 1;

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > arr[i - 1])
                {
                    currentLength++;
                    if (currentLength > bestLength)
                    {
                        bestLength = currentLength;
                        bestIndex = currentIndex;
                    }
                }
                else
                {
                    currentIndex = i;
                    currentLength = 1;
                }
            }
            for (int i = bestIndex; i < bestIndex+bestLength; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
