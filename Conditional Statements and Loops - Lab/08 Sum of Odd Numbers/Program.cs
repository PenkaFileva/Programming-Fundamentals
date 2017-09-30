using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Sum_of_Odd_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= num ; i++)
            {
                Console.WriteLine(i*2-1);
                sum += i*2-1;
            }
            Console.WriteLine("Sum: {0}", sum);
        }
    }
}
