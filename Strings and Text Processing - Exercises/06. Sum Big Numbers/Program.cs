using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Sum_Big_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var num1 = Console.ReadLine();
            var num2 = Console.ReadLine();
            if (num1.Length > num2.Length)
            {
                num2 = num2.PadLeft(num1.Length, '0');
            }
            else
            {
                num1 = num1.PadLeft(num2.Length, '0');
            }
            StringBuilder sb = new StringBuilder();
            var sum = 0;
            var number = 0;
            var remainder = 0;
            for (int i = num1.Length-1; i >= 0; i--)
            {
                sum = num1[i] - 48 + num2[i] - 48 + remainder;
                number = sum % 10;
                sb.Append(number);
                remainder = sum / 10;
                if (i == 0 && remainder > 0)
                {
                    sb.Append(remainder);
                }                
            }
            Console.WriteLine(new string(sb.ToString().TrimEnd('0').ToCharArray().Reverse().ToArray()));
        }
    }
}
