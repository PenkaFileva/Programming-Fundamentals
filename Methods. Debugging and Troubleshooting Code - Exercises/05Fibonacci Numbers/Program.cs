using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05Fibonacci_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());

            var fibonacciNum = FibonacciNumbers(num);
            Console.WriteLine(fibonacciNum);
        }

        private static long FibonacciNumbers(long num)
        {
            var f0 = 1;
            var f1 = 1;
            for (var i = 0; i < num - 1; i++)
            {
                var fNext = f0 + f1;
                f0 = f1;
                f1 = fNext;
            }
            return f1;
        }
    }
}
