using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07From_Terabytes_to_Bits
{
    class Program
    {
        static void Main(string[] args)
        {
            double terabytes = double.Parse(Console.ReadLine());
            double bits = terabytes * (Math.Pow(1024, 4) * 8);
            Console.WriteLine(bits);
        }
    }
}
