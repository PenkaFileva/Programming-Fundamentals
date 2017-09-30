using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Reverse_Array_of_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] num = new int[n];
            for (int i = 0; i < num.Length; i++)
            {
                num[i] = int.Parse(Console.ReadLine());
            }
            int[] reverced = new int[num.Length];
            for (int i = 0; i < num.Length; i++)
            {
                reverced[i] = num[num.Length - 1 - i];
            }
            Console.WriteLine(String.Join(" ", reverced));
        }
    }
}
