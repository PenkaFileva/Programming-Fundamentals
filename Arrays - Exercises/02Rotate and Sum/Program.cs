using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Rotate_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());

            int[] sumArray = new int[nums.Length];
            for (int i = 0; i < n; i++)
            {
                RotateNums(nums);
                for (int j = 0; j < nums.Length; j++)
                {
                    sumArray[j] += nums[j];
                }

            }
            Console.WriteLine(String.Join(" ", sumArray));
        }

        private static void RotateNums(int[] nums)
        {
            int lastDigit = nums[nums.Length - 1];
            for (int i = nums.Length-1; i > 0 ; i--)
            {
                nums[i] = nums[i-1];
            }
            nums[0] = lastDigit;
        }
    }
}
