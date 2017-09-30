using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03Megapixels
{
    class Program
    {
        static void Main(string[] args)
        {
            var width = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());
            var pixels = Math.Round((width * height)/1000000, 1);
            Console.WriteLine($"{width}x{height} => {pixels}MP");
        }
    }
}
