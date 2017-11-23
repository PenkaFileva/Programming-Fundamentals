using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Endurance_Rally
{
    class Program
    {
        static void Main(string[] args)
        {
            var players = Regex.Split(Console.ReadLine(), @"\s+")
                .Where(t => t.Length > 0).ToArray();
            double[] route = Regex.Split(Console.ReadLine(), @"\s+")
                .Where(t => t.Length > 0).Select(p => double.Parse(p) * -1).ToArray();
            long[] checkpointIndexes = Regex.Split(Console.ReadLine(), @"\s+")
                .Where(t  => t.Length > 0)
                .Distinct().Select(long.Parse).ToArray();
            //for (int i = 0; i < route.Length; i++) може директно да се умножи при четене на входа 
            //{
            //    route[i] = route[i] * -1;
            //}
            foreach (var i in checkpointIndexes)
            {
                if(i >= 0 && i < route.Length)
                    route[i] *= -1;
            }
            foreach (var p in players)
            {
                var fuel = (double) p[0];
                var index = 0;
                foreach (var r in route)
                {
                    fuel += r;
                    if (fuel <= 0)
                    {
                        Console.WriteLine("{0} - reached {1}", p, index);
                        break;
                    }
                    index++;
                }
                if (fuel > 0)
                {
                    Console.WriteLine("{0} - fuel left {1:f2}", p, fuel);
                }
            }
        }
    }
}
