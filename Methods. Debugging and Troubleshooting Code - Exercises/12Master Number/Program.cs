using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12Master_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = long.Parse(Console.ReadLine());
            for (int currentNum = 1; currentNum <= num; currentNum++)
            {
                if (IsPalindrome(currentNum))
                {
                    if (SumOfDigits(currentNum))
                    {
                        if (ContainsEvenDigits(currentNum))
                        {
                            Console.WriteLine(currentNum);
                        }
                    }
                }
            }
        }

        private static bool ContainsEvenDigits(long currentNum)
        {
            while (currentNum > 0)
            {
                if ((currentNum % 10) % 2 == 0 )
                {
                    return true;
                }
                currentNum = currentNum / 10;
            }
            return false;
        }

        private static bool SumOfDigits(long currentNum)
        {
            long sum = 0;
            while (currentNum > 0)
            {
                sum += currentNum % 10;
                currentNum = currentNum / 10;
            }
            if (sum % 7 == 0)
            {
                return true;
            }
            return false;
        }

        private static bool IsPalindrome(long currentNum)
        {
            bool palindrome = true;
            string num = currentNum.ToString();
            for (int i = 0; i <= num.Length/2; i++)
            {
                if (num[i] != num[num.Length - 1 - i])
                {
                    palindrome = false;
                    break;
                }
            }
            return palindrome;
        }
    }
}
