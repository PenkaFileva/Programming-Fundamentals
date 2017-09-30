using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06Theatre_Promotion
{
    class Program
    {
        static void Main(string[] args)
        {
            string day = Console.ReadLine().ToLower();
            int age = int.Parse(Console.ReadLine());
            var price = 0;
            if (age < 0 || age > 122)
            {
                Console.WriteLine("Error!");
            }
            else
            {
                if (age <= 18)
                {
                    switch (day)
                    {
                        case "weekday": price = 12; break;
                        case "weekend": price = 15; break;
                        case "holiday": price = 5; break;
                    }
                }
                else if (age <= 64)
                {
                    switch (day)
                    {
                        case "weekday": price = 18; break;
                        case "weekend": price = 20; break;
                        case "holiday": price = 12; break;
                    }
                }
                else if (age <= 122)
                {
                    switch (day)
                    {
                        case "weekday": price = 12; break;
                        case "weekend": price = 15; break;
                        case "holiday": price = 10; break;
                    }
                }
                Console.WriteLine($"{price}$");
            }
           
        }
    }
}
