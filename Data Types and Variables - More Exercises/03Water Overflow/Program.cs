using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int capacityOfTank = 255;
            int curreantCaracity = 0;
            int sumOfLiters = 0;
            for (int i = 0; i < n; i++)
            {
                int liters = int.Parse(Console.ReadLine());
                sumOfLiters = liters + curreantCaracity;
                if (sumOfLiters <= capacityOfTank)
                {
                    curreantCaracity = sumOfLiters;
                    sumOfLiters = 0;
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }
            }
            Console.WriteLine(curreantCaracity);
        }
    }
}
 