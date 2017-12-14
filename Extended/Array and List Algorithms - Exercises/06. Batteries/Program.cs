using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Batteries
{
    class Program
    {
        static void Main(string[] args)
        {
            var capacitiesMAh = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            var usagePerHour = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var amountOfHours = int.Parse(Console.ReadLine());
            for (int i = 0; i < amountOfHours; i++)
            {
                var currentBattery = capacitiesMAh[i];
                var used = usagePerHour[i] * amountOfHours;
                if (used <= currentBattery)
                {
                    var result = used - currentBattery;
                    var persent = (result/currentBattery)*100;
                    Console.WriteLine($"Battery 1: {result:f2} mAh ({persent:f2})%");
                }
                else if (used > currentBattery)
                {
                    var result = (used - currentBattery);

                }
            }
        }
    }
}
