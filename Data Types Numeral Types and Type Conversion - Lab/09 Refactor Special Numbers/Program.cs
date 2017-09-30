using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Refactor_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int cnt = 1; cnt <= n; cnt++)
            {
                int sum = 0;
                int num = cnt;
                int startNum = num;
                while (num > 0)
                {
                    int currentNum= num % 10;
                    num = num / 10;
                    sum += currentNum;
                }
                bool result = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine($"{startNum} -> {result}");
            }
        }
    }
}
