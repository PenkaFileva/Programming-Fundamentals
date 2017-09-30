using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Append_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split('|').ToArray();
            var result = new List<string>();

            Array.Reverse(nums);
            for (int i = 0; i < nums.Length; i++)
            {
                var numbers = nums[i].Split(' ').ToArray();
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (numbers[j] != "")
                    {
                        result.Add(numbers[j]);
                    }
                }
                
            }
            //foreach (var token in nums)
            //{
            //    string[] numbers = token.Split(' ');
            //    foreach (var item in numbers)
            //    {
            //
            //        if (item != " ")
            //        {
            //            result.Add(item);
            //        }
            //    }
            //}
            Console.WriteLine(String.Join(" ",result));

        }
    }
}
