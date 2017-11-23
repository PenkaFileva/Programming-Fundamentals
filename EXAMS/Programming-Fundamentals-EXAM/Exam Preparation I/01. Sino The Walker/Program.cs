using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace _01.Sino_The_Walker
{
    class Program
    {
        static void Main(string[] args)
        {
            //var time = DateTime.ParseExact(Console.ReadLine(), "H:m:s", CultureInfo.InvariantCulture);
            //long stepsCount = long.Parse(Console.ReadLine());
            //long timeForStep = long.Parse(Console.ReadLine());
            //var secondsToAdd = stepsCount * timeForStep;
            //
            //var day = 24 * 60 * 60;
            ////var days = secondsToAdd / day;
            //secondsToAdd = secondsToAdd % day;
            //var resultDate = time.AddSeconds(secondsToAdd);
            //Console.WriteLine("Time Arrival: {0:HH:mm:ss}", resultDate);


            var time = Console.ReadLine().Split(':').Select(int.Parse).ToArray();
            long seconds = time[2] + time[1] * 60 + time[0] * 60 * 60;
            long secondsToAdd = long.Parse(Console.ReadLine()) * 
                long.Parse(Console.ReadLine());
            seconds = seconds + secondsToAdd;
            var secs = seconds % 60;
            var min = (seconds / 60) % 60;
            var hours = (seconds /60/60) % 24;
            Console.WriteLine("Time Arrival: {0:d2}:{1:d2}:{2:d2}", hours, min, secs);
        }
    }
}
