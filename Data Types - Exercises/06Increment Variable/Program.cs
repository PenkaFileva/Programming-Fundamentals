using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06Increment_Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            long num = long.Parse(Console.ReadLine());
            int overflow = (int)num / 256;
            double result = num % 256;
            if (overflow >= 1)
            {
                Console.WriteLine(result);
                Console.WriteLine("Overflowed {0} times", overflow);
            }
            else
            {
                Console.WriteLine(num);
            }

        }
    }
}
