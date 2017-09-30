using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double bigVolume = 0.0;
            string firstName = String.Empty;
            for (int i = 0; i < n; i++)
            {
                string name1 = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                double volume = Math.PI * Math.Pow(radius, 2) * height;
                if (volume >= bigVolume)
                {
                    bigVolume = volume;
                    firstName = name1;
                }
            }
            Console.WriteLine(firstName);
        }
    }
}
