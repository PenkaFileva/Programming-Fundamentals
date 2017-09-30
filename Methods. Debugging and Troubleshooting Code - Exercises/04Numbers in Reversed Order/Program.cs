using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04Numbers_in_Reversed_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = double.Parse(Console.ReadLine());
            var reverseNum = ReverseNumDigits(num);
            Console.WriteLine(reverseNum);
        }

        private static double ReverseNumDigits(double num)
        {
            var numString = num.ToString();
            var result = String.Empty;
            for (int i = numString.Length - 1; i >= 0; i--)
            {
                result += numString[i];
            }
            return double.Parse(result);
        }
    }
}
