using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03Last_K_Numbers_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            long[] seq = new long[n];
            seq[0] = 1;
            for (int i = 1; i < n; i++)
            {
                long sum = 0;
                int startDigit = i - k;
                int endDigit = i - 1;
                for (int prev = startDigit; prev <= endDigit; prev++)
                {
                    if (prev >= 0)
                    {
                        sum += seq[prev];
                    }
                }
                seq[i] = sum;
            }
            Console.WriteLine(String.Join(" ", seq));

        }
    }
}
