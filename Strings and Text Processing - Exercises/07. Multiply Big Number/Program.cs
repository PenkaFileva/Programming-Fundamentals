using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Multiply_Big_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var num1 = Console.ReadLine().TrimStart('0');
            var num2 = int.Parse(Console.ReadLine());
            if (num1 == "0" || num2 == 0 || num1 == "")
            {
                Console.WriteLine(0);
                return;
            }

            StringBuilder sb = new StringBuilder();
            var sum = 0;
            var number = 0;
            var remainder = 0;
            for (int i = num1.Length - 1; i >= 0; i--)
            {
                sum = (num1[i] - 48) * num2 + remainder;
                number = sum % 10;
                sb.Append(number);
                remainder = sum / 10;
                if (i == 0 && remainder > 0)
                {
                    sb.Append(remainder);
                }
            }
            Console.WriteLine(new string(sb.ToString().ToCharArray().Reverse().ToArray()));
        }
    }
}
