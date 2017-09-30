using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05BPM_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            var bpm = double.Parse(Console.ReadLine());
            var numOfBeats = int.Parse(Console.ReadLine());
            var bpmToBars = bpm / 4.0;
            var numBars = Math.Round((numOfBeats / 4.0), 1);
            var barsSecond = (numBars*60)/ bpmToBars;
            var minutes = Math.Floor(barsSecond / 60);
            var seconds = Math.Floor(barsSecond % 60);
            Console.WriteLine("{0} bars - {1}m {2}s", numBars, minutes, seconds);
        }
    }
}
