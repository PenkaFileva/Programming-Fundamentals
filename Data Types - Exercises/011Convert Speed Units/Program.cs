using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _011Convert_Speed_Units
{
    class Program
    {
        static void Main(string[] args)
        {
            float distanceInMeters = float.Parse(Console.ReadLine());
            float hours = float.Parse(Console.ReadLine());
            float minutes = float.Parse(Console.ReadLine());
            float seconds = float.Parse(Console.ReadLine());
            float oneMileToKm = 1609f;
            float km = distanceInMeters / 1000;
            float mile = distanceInMeters / oneMileToKm;
            float totalSeconds = seconds + minutes * 60 + hours * 60 * 60;
            float minutesPerSeconds = distanceInMeters / totalSeconds;
            double kilometersPerHours = (distanceInMeters / 1000.0)/(totalSeconds/60/60);
            float milePerHours = mile / (totalSeconds / 60 / 60);

            Console.WriteLine("{0}", minutesPerSeconds);
            Console.WriteLine($"{(float)kilometersPerHours}");
            Console.WriteLine($"{milePerHours}");
        }
    }
}
