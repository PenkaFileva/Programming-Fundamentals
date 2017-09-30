using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04Triple_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            bool result = false;
            for (int a = 0; a < nums.Length; a++)
            {
                for (int b = a+1; b < nums.Length; b++)
                {
                    int sum = nums[a] + nums[b];
                    if (nums.Contains(sum))
                    {
                        Console.WriteLine("{0} + {1} == {2}", nums[a], nums[b], sum);
                        result = true;
                    }
                }
            }
            if (! result)
            {
                Console.WriteLine("No");
            }

        }
    }
}
