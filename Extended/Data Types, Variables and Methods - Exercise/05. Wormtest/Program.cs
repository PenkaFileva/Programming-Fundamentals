using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Wormtest
{
    class Program
    {
        static void Main(string[] args)
        {
            var length = double.Parse(Console.ReadLine());
            var width = double.Parse(Console.ReadLine());

            var lengthInCM = length * 100;

            if (lengthInCM % width == 0 || width == 0)
            {
                Console.WriteLine($"{lengthInCM * width:F2}");
            }
            else
            {
                Console.WriteLine($"{((lengthInCM / width) * 100):F2}%");
            }
        }
    }
}
