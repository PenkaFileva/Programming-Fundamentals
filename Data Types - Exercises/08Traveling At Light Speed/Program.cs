using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08Traveling_At_Light_Speed
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal kmForOneLightYear = 9450000000000;
            decimal kmForSecond = 300000;
            decimal lightYears = decimal.Parse(Console.ReadLine());
            decimal secondTotal = (lightYears * kmForOneLightYear) / kmForSecond;
            int minutes = (int)(secondTotal / 60);
            secondTotal %= 60;
            int hours = minutes / 60;
            minutes %= 60;
            int days = hours / 24;
            hours %= 24;
            int weeks = days / 7;
            days %= 7;
            Console.WriteLine("{0} weeks", weeks);
            Console.WriteLine("{0} days", days);
            Console.WriteLine("{0} hours", hours);
            Console.WriteLine("{0} minutes", minutes);
            Console.WriteLine("{0} seconds", (int)secondTotal);
        }
    }
}
