using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int k = nums.Length / 4;
            int[] leftArray = new int[k];
            int[] midlleArray = new int[k * 2];
            int[] rightArray = new int[k];

            int[] resultArray = new int[2 * k];
            for (int i = 0; i < k; i++)
            {
                leftArray[i] = nums[i];
            }
            for (int i = 0; i < k; i++)
            {
                rightArray[i] = nums[nums.Length - 1 - i];
            }
            for (int i = 0; i < k*2; i++)
            {
                midlleArray[i] = nums[i + k];
            }
            Array.Reverse(leftArray);
            for (int i = 0; i < k; i++)
            {
                resultArray[i] = leftArray[i] + midlleArray[i];

                resultArray[i+k] = rightArray[i] + midlleArray[i+k];
            }
            Console.WriteLine(String.Join(" ", resultArray));
            //Console.WriteLine(String.Join(" ", rightArray));
            //Console.WriteLine(String.Join(" ", midlleArray));
        }
    }
}
