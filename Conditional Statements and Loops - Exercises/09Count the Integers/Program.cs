using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09Count_the_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalCount = 0;
            while (true)
            {
                try
                {
                    int num = int.Parse(Console.ReadLine());
                    totalCount += 1;
                }
                catch 
                {
                    break;
                }
            }
            Console.WriteLine(totalCount);
        }
    }
}
