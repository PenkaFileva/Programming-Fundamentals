using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09Multiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int times = 10;
            for (int i = 1; i <= times; i++)
            {
                Console.WriteLine($"{n} X {i} = {n*i}");
            }
        }
    }
}
