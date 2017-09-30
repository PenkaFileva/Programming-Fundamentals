using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07Sum_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] line1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] line2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] result = new int[Math.Max(line1.Length, line2.Length)];
            for (int i = 0; i < result.Length; i++) 
            {
                result[i] = line1[i % line1.Length] + line2[i % line2.Length];
            }
            Console.WriteLine(String.Join(" ", result));
        }
    }
}
