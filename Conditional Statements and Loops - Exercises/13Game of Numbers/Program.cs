using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13Game_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int magicalNumber = int.Parse(Console.ReadLine());
            int firstNumber = 0;
            int secondNumber = 0;
            int combinations = 0;

            for (int i = n; i <= m; i++)
            {
                for (int j = n; j <= m; j++)
                {
                    int sum = i + j;
                    combinations += 1;
                    if (sum == magicalNumber)
                    {
                        firstNumber = i;
                        secondNumber = j;
                    }
                }
            }
            if (firstNumber != 0 && secondNumber != 0)
            {
                Console.WriteLine($"Number found! {firstNumber} + {secondNumber} = {magicalNumber}");
            }
            else
            {
                Console.WriteLine($"{combinations} combinations - neither equals {magicalNumber}");
            }
        }
    }
}