using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Count_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToList();
            input.Sort();
            var count = 1;
            for (int i = 0; i < input.Count; i++)
            {
                int num = input[i];
                if ((i < input.Count-1 && input[i] != input[i+1]) || i == input.Count-1)
                {
                    Console.WriteLine($"{num} -> {count}");
                    count = 0;
                }
                count++;
            }
        }
    }
}
