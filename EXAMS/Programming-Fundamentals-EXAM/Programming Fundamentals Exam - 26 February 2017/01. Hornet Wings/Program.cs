using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Hornet_Wings
{
    class Program
    {
        static void Main(string[] args)
        {
            var wingFlaps = long.Parse(Console.ReadLine());
            var distance1000WingFlaps = double.Parse(Console.ReadLine());

            var endurancOfHornet = long.Parse(Console.ReadLine());
            var distans = (wingFlaps / 1000) * distance1000WingFlaps; // m.
            var pochivka = wingFlaps / endurancOfHornet* 5; //sec
            var end = wingFlaps / 100; //sec

            var totalSec = pochivka + end;
            Console.WriteLine($"{distans:f2} m.");
            Console.WriteLine($"{totalSec} s.");
        }
    }
}
