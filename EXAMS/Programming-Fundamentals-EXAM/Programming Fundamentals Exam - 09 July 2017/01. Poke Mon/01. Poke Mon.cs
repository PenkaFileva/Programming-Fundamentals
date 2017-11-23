using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            var powerPokeMon = long.Parse(Console.ReadLine());
            var distance = long.Parse(Console.ReadLine());
            var exhaustionFactor = long.Parse(Console.ReadLine());

            int count = 0;
            long startPower = powerPokeMon;
            while (startPower >= distance)
            {
                startPower -= distance;
                count++;
                if (startPower == powerPokeMon * 0.5 && exhaustionFactor != 0)
                {
                    startPower /= exhaustionFactor;
                }
            }
            Console.WriteLine(startPower);
            Console.WriteLine(count);
        }
    }
}
