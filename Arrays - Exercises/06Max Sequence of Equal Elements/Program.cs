using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var bestIndex = 0;
            var bestLength = 0;

            var currentIndex = arr[0];
            var currentLength = 1;
            
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] == arr[i-1])
                {
                    currentLength++;
                    if (currentLength > bestLength)
                    {
                        bestLength = currentLength;
                        bestIndex = arr[i - 1];
                    }
                }
                else
                {
                    //if (currentLength > bestLength)
                    //{
                    //    bestLength = currentLength;
                    //    bestIndex = arr[i-1];
                    //}
                    currentIndex = arr[i];
                    currentLength = 1;
                }
            }
            if (bestLength == 0)
            {
                for (int i = 0; i < currentLength; i++)
                {
                    Console.Write(currentIndex + " ");
                }
            }
            else
            {
                for (int i = 0; i < bestLength; i++)
                {
                    Console.Write(bestIndex + " ");
                }
            }        
            Console.WriteLine();
        }
    }
}
