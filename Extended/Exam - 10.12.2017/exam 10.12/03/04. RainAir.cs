using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.RainAir
{
    class Program
    {
        static void Main(string[] args)
        {
            var customerNameFlights = new Dictionary<string, List<long>>();
            var input = Console.ReadLine();

            while (input != "I believe I can fly!")
            {
                if (input.Contains('='))
                {
                    var tokens = input.Split("= ".ToCharArray(),
                        StringSplitOptions.RemoveEmptyEntries);
                    var customerName = tokens[0];
                    var customer2Name = tokens[1];
                    if (customerNameFlights.ContainsKey(customerName))
                    {
                        customerNameFlights.Remove(customerName);
                    }
                    customerNameFlights.Add(customerName, new List<long>());
                    foreach (var cust in customerNameFlights[customer2Name])
                    {
                        customerNameFlights[customerName].Add(cust);
                    }

                }
                else
                {
                    var tokens = input.Split(' ');
                    var customerName = tokens[0];
                    var customerFlight = tokens.Skip(1).Select(long.Parse);
                    if (!customerNameFlights.ContainsKey(customerName))
                    {
                        customerNameFlights[customerName]=new List<long>();
                    }
                    customerNameFlights[customerName].AddRange(customerFlight);
                }
                input = Console.ReadLine();
            }
            var resultcustomerNameFlights = customerNameFlights
                .OrderByDescending(a => a.Value.Count).ThenBy(s => s.Key);
            foreach (var cust in resultcustomerNameFlights)
            {
                Console.WriteLine($"#{cust.Key} ::: {string.Join(", ", cust.Value.OrderBy(z => z))}");
            }
        }
    }
}
