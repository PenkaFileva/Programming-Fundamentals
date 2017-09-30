using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07Primes_in_Given_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            var startNum = int.Parse(Console.ReadLine());
            var endNum = int.Parse(Console.ReadLine());
            var primes = FindPrimesInRange(startNum, endNum);
            Console.WriteLine(string.Join(", ", primes));
        }

        static List<int> FindPrimesInRange(int startNum, int endNum)
        {
            var primes = new List<int>();
            for (int currentNum = startNum; currentNum <= endNum; currentNum++)
            {
                if (IsPrime(currentNum))
                {
                    primes.Add(currentNum);
                }

            }
            return primes;
        }

        static bool IsPrime(int currentNum)
        {
            if (currentNum == 0 || currentNum == 1)
            {
                return false;
            }
            if (currentNum == 2)
            {
                return true;
            }
            var maxNum = Math.Sqrt(currentNum);
            for (int j = 2; j <= maxNum; j++)
            {
                if (currentNum % j == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
