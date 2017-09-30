using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03Miles_to_Kilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            var miles = double.Parse(Console.ReadLine());
            var convertsMilesToKilometers = miles * 1.60934;
            Console.WriteLine("{0:F2}", convertsMilesToKilometers);
        }
    }
}
