﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Remove_Negatives_and_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> result = new List<int>();
            bool index = false;
            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] > 0)
                {
                    index = true;
                }
            }
            if (!index)
            {
                Console.WriteLine("empty");
            }          
            else
            {
                for (int i = 0; i < nums.Count; i++)
                {
                    if (nums[i] > 0)
                    {
                        result.Add(nums[i]);
                    }
                }
                result.Reverse();
                Console.WriteLine(String.Join(" ", result));
            }          
        }
    }
}
