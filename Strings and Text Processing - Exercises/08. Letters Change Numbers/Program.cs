using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Letters_Change_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var strings = Console.ReadLine().Split(" \t".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            var sum = 0.0;
            foreach (var str in strings)
            {
                var firstLetter = str.First();
                var lastLetter = str.Last();
                var number = double.Parse(str.Substring(1, str.Length - 2));
                //var sum = 0.0;
                if (char.IsUpper(firstLetter))
                {
                    number /= firstLetter - ('A' - 1);
                }
                else
                {
                    number *= firstLetter - ('a' - 1);
                }
                if (char.IsUpper(lastLetter))
                {
                    number -= lastLetter - ('A' - 1);
                }
                else
                {
                    number += lastLetter - ('a' - 1);
                }
                sum += number;
                
            }
            Console.WriteLine("{0:f2}", sum);
        }
    }
}
