using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());          
            for (int i = 1; i <= n; i++)
            {
                int sum = 0;
                int num = i;
                int startingNum = num;
                while (num > 0)
                {
                    int currentDigit = num % 10;
                    num = num / 10;
                    sum += currentDigit;
                }
                bool result = sum == 5 || sum == 7 || sum == 11;
                Console.WriteLine($"{startingNum} -> {result}");
            }
        }
    }
}
