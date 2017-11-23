using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Charity_Marathon
{
    class Program
    {
        static void Main(string[] args)
        {
            var marathoDaysCount = long.Parse((Console.ReadLine()));//rdni
            var runnersCount = long.Parse(Console.ReadLine()); //br hora
            var numberOfLaps = long.Parse(Console.ReadLine()); //br obikolki
            var trackLength = long.Parse(Console.ReadLine());// daljina
            var trackCapacity = long.Parse(Console.ReadLine()); //kapacitet
            var moneyDonatedPerKilometer = double.Parse(Console.ReadLine()); //pari za kilometar

            
            var totaldistans = (Math.Min(runnersCount, trackCapacity*marathoDaysCount)
                *numberOfLaps * trackLength)/1000 * moneyDonatedPerKilometer;
            Console.WriteLine("Money raised: {0:f2}", totaldistans);
        }
    }
}
