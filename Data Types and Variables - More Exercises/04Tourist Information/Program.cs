using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04Tourist_Information
{
    class Program
    {
        static void Main(string[] args)
        {
            string imperialUnit = Console.ReadLine().ToLower().Trim();
            double valueNeedToConvert = double.Parse(Console.ReadLine());
            double convertConstant = 0.0;
            string metricUnit = String.Empty;
            switch (imperialUnit)
            {
                case "miles":convertConstant = 1.6;metricUnit = "kilometers";break;
                case "inches": convertConstant = 2.54; metricUnit = "centimeters"; break;
                case "feet": convertConstant = 30.0; metricUnit = "centimeters"; break;
                case "yards": convertConstant = 0.91; metricUnit = "meters"; break;
                case "gallons": convertConstant = 3.8; metricUnit = "liters"; break;
            }
            double convertVolue = valueNeedToConvert * convertConstant;
            Console.WriteLine("{0} {1} = {2:f2} {3}", valueNeedToConvert, imperialUnit, convertVolue, metricUnit);
        }
    }
}
