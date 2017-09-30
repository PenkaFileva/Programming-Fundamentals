using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine().ToLower().Trim();
            int nightsCount = int.Parse(Console.ReadLine());

            var studioPerNight = 0.0;
            var doublePerNight = 0.0;
            var suitePerNight = 0.0;
            switch (month)
            {
                case "may":
                case "october":studioPerNight = 50; doublePerNight = 65; suitePerNight = 75;break;
                case "june":
                case "september": studioPerNight = 60; doublePerNight = 72; suitePerNight = 82; break;
                case "july":
                case "august":
                case "december": studioPerNight = 68; doublePerNight = 77; suitePerNight = 89; break;
            }
            if ((month == "may" || month == "october") && nightsCount > 7)
            {
                studioPerNight -= 0.05 * studioPerNight;
            }
            else if ((month == "june" || month == "september") && nightsCount > 14)
            {
                doublePerNight -= doublePerNight * 0.10;
            }
            else if ((month == "july" || month == "august" || month == "december") && nightsCount > 14)
            {
                suitePerNight -= suitePerNight * 0.15;
            }
            var totalPriceStudio = nightsCount * studioPerNight;
            var totalPriceDouble = nightsCount * doublePerNight;
            var totalPriceSuite = nightsCount * suitePerNight;
            if ((month == "september" || month == "october") && nightsCount > 7)
            {
                totalPriceStudio -= studioPerNight;
            }
            Console.WriteLine("Studio: {0:f2} lv.", totalPriceStudio);
            Console.WriteLine("Double: {0:f2} lv.", totalPriceDouble);
            Console.WriteLine("Suite: {0:f2} lv.", totalPriceSuite);
        }
    }
}
