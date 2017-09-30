using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _14FactorialTrailingZeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            BigInteger result = GetFactorial(num);
            var count = GetNumberOfZero(result);
            Console.WriteLine(count);
        }

        private static BigInteger GetNumberOfZero(BigInteger result)
        {
            var count = 0;
            while (result % 10 == 0)
            {
                count++;
                result = result / 10;
            }
            return count;
        }

        private static BigInteger GetFactorial(int num)
        {
            BigInteger result = 1;
            for (int i = 1; i <= num; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
