using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Count_Working_Days
{ 
    class Program
    {
        static void Main(string[] args)
        {
            DateTime startDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
            DateTime endtDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
            var holidays =
                new []
                {
                    "01 01", "03 03", "01 05", "06 05", "24 05", "06 09", "22 09", "01 11", "24 12", "25 12", "26 12"
                }.Select(a => DateTime.ParseExact(a, "dd MM", CultureInfo.InvariantCulture)).ToArray();

            int workingDaysCount = 0;
            for (DateTime i = startDate; i <= endtDate; i = i.AddDays(1))
            {
                var isSaturdayOdSunday = i.DayOfWeek == DayOfWeek.Saturday || i.DayOfWeek == DayOfWeek.Sunday;
                var isHolyday = holidays.Any(d => d.Day == i.Day && d.Month == i.Month);
                var isWorkingDay = !(isSaturdayOdSunday || isHolyday);
                if (isWorkingDay)
                {
                    workingDaysCount++;
                }
            }
            Console.WriteLine(workingDaysCount);
        }
    }
}