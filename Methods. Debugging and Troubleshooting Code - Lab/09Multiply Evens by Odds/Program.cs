using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = Math.Abs(int.Parse(Console.ReadLine()));
            Console.WriteLine(GetMultipleOfEvensAndOdds(num));
        }

        static int GetMultipleOfEvensAndOdds(int num)
        {
            int result = GetSumOfEvenDigits(num) * GetSumOfOddsDigits(num);
            return result;
        }

        static int GetSumOfEvenDigits(int num)
        {
            int sum = 0;
            while (num > 0)
            {
                int lastdigit = num % 10;
                if (lastdigit % 2 == 0)
                {
                    sum += lastdigit;
                }
                num /= 10;
            }
            return sum;
        }

        static int GetSumOfOddsDigits(int num)
        {
            int sum = 0;
            while (num > 0)
            {
                int lastdigit = num % 10;
                if (lastdigit % 2 != 0)
                {
                    sum += lastdigit;
                }
                num /= 10;
            }
            return sum;
        }
    }
}
