using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Time_Since_Birthday
{
    class Program
    {
        static void Main(string[] args)
        {
            byte year = byte.Parse(Console.ReadLine());
            int days = year * 365;
            int hours = days * 24;
            int minutes = hours * 60;
             
            Console.WriteLine("{0} years = {1} days = {2} hours = {3} minutes.", year, days, hours,minutes);
        }
    }
}
