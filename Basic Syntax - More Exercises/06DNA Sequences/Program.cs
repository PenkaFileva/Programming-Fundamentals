using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06DNA_Sequences
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = int.Parse(Console.ReadLine());
            int count = 0;
            for (int firstNum = 1; firstNum <= 4; firstNum++)
            {
                for (int secondNum = 1; secondNum <= 4; secondNum++)
                {
                    for (int thirdNum = 1; thirdNum <= 4; thirdNum++)
                    {
                        count++;
                        if (firstNum+secondNum+thirdNum >= sum)
                        {
                            Console.Write("O"+(""+firstNum+secondNum+thirdNum).Replace('1', 'A').Replace('2', 'C').Replace('3', 'G').Replace('4', 'T')+"O ");
                        }
                        else
                        {
                            Console.Write("X" + ("" + firstNum + secondNum + thirdNum).Replace('1', 'A').Replace('2', 'C').Replace('3', 'G').Replace('4', 'T') + "X ");
                        }
                        if (count % 4 == 0)
                        {
                            Console.WriteLine();
                        }
                    }
                }
            }
        }
    }
}
