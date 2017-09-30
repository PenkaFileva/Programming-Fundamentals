using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03Restaurant_Discount
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupSize = int.Parse(Console.ReadLine());
            string typePackage = Console.ReadLine().ToLower().Trim();
            var priceHall = 0.0;
            var pricePackage = 0.0;
            var discount = 0.0;
            string hallName = String.Empty;
            if (groupSize <= 120)
            {
                if (groupSize <= 50)
                {
                    priceHall = 2500;
                    hallName = "Small Hall";
                    switch (typePackage)
                    {
                        case "normal": pricePackage = 500; discount = 0.05; break;
                        case "gold": pricePackage = 750; discount = 0.10; break;
                        case "platinum": pricePackage = 1000; discount = 0.15; break;
                    }
                }
                else if (groupSize <= 100)
                {
                    priceHall = 5000;
                    hallName = "Terrace";
                    switch (typePackage)
                    {
                        case "normal": pricePackage = 500; discount = 0.05; break;
                        case "gold": pricePackage = 750; discount = 0.10; break;
                        case "platinum": pricePackage = 1000; discount = 0.15; break;
                    }
                }
                else if (groupSize <= 120)
                {
                    priceHall = 7500;
                    hallName = "Great Hall";
                    switch (typePackage)
                    {
                        case "normal": pricePackage = 500; discount = 0.05; break;
                        case "gold": pricePackage = 750; discount = 0.10; break;
                        case "platinum": pricePackage = 1000; discount = 0.15; break;
                    }
                }
                var totalPrice = priceHall + pricePackage;
                var priceAfterDiscount = totalPrice - (totalPrice * discount);
                var pricePerPerson = priceAfterDiscount / groupSize;
                Console.WriteLine($"We can offer you the {hallName}");
                Console.WriteLine($"The price per person is {pricePerPerson:f2}$");
            }           
            else
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }           
        }
    }
}
