using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06Interval_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstNum = int.Parse(Console.ReadLine());
            var secondNum = int.Parse(Console.ReadLine());
            var num1 = Math.Min(firstNum, secondNum);
            var num2 = Math.Max(firstNum, secondNum);
            for (int i = num1; i <= num2; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
