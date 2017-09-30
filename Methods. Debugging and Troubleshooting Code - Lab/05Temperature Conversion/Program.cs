﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05Temperature_Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            var fahrenheit = double.Parse(Console.ReadLine());
            var celsius = FahrenheitToCelsius(fahrenheit);
            Console.WriteLine("{0:f2}", celsius);
        }

        static double FahrenheitToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }
    }
}
