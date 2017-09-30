using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Max_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            var num1 = double.Parse(Console.ReadLine());
            var num2 = double.Parse(Console.ReadLine());
            var num3 = double.Parse(Console.ReadLine());

            var biggestDigit = GetMax(num1, num2, num3);
            Console.WriteLine(biggestDigit);
        }

        private static double GetMax(double num1, double num2, double num3)
        {
            var max = Math.Max(num1, num2);
            var maxDigit = Math.Max(max, num3);
            return maxDigit;

        }
    }
}
