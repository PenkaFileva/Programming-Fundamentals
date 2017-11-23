﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Softuni_Coffee_Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());


            decimal totalPrice = 0;
            for (int i = 0; i < n; i++)
            {
                decimal price = ReadOrderAndCalculatePrice();
                totalPrice += price;
            }
            Console.WriteLine($"Total: ${totalPrice:f2}");
        }

        private static decimal ReadOrderAndCalculatePrice()
        {

            decimal pricePerCapsule = decimal.Parse(Console.ReadLine());
            string dateStr = Console.ReadLine();
            DateTime date = DateTime.ParseExact(dateStr, "d/M/yyyy", null);
            decimal capsulesCount = decimal.Parse(Console.ReadLine());

            decimal daysInMonth = DateTime.DaysInMonth(date.Year, date.Month);
            decimal price = (daysInMonth * capsulesCount) * pricePerCapsule;
            Console.WriteLine($"The price for the coffee is: ${price:f2}");
            return price;
        }
    }
}
