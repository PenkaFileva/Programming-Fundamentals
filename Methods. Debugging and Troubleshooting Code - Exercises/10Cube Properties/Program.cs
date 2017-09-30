using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10Cube_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            var side = double.Parse(Console.ReadLine());
            string parameter = Console.ReadLine().ToLower();
            var result = 0.0;
            if (parameter == "face")
            {
                result = PrintFaceDiagonals(side);
            }
            else if (parameter == "space")
            {
                result = PrintSpaceDiagonals(side);
            }
            else if (parameter == "volume")
            {
                result = PrintVolume(side);
            }
            else if (parameter == "area")
            {
                result = PrintArea(side);
            }
            Console.WriteLine($"{result:f2}");
        }

        private static double PrintArea(double side)
        {
            var result = 6 * Math.Pow(side, 2);
            return result;
        }

        private static double PrintVolume(double side)
        {
            var result = Math.Pow(side, 3);
            return result;
        }

        private static double PrintSpaceDiagonals(double side)
        {
            var result = Math.Sqrt(3 * Math.Pow(side, 2));
            return result;
        }

        private static double PrintFaceDiagonals(double side)
        {
            var result = Math.Sqrt(2 * Math.Pow(side, 2));
            return result;
        }
    }
}
