using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Population_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, long>> cityCountryPopulation = new Dictionary<string, Dictionary<string, long>>();
            string input = Console.ReadLine();

            while (input != "report")
            {
                var information = input.Split('|');
                var city = information[0];
                var country = information[1];
                var population = int.Parse(information[2]);
                if (!cityCountryPopulation.ContainsKey(country))
                {
                    cityCountryPopulation[country] = new Dictionary<string, long>();

                }
                if (!cityCountryPopulation[country].ContainsKey(city))
                {
                    cityCountryPopulation[country][city] = population;
                }
                input = Console.ReadLine();
            }
            var orderedCountries = cityCountryPopulation.OrderByDescending(c => c.Value.Values.Sum());
            foreach (var kvp in orderedCountries)
            {
                var country = kvp.Key;
                
                var cityPopulation = kvp.Value.OrderByDescending(c => c.Value);
              
                Console.WriteLine("{0} (total population: {1})", country, cityPopulation.Sum(a => a.Value));
                foreach (var city in cityPopulation)
                {
                    Console.WriteLine("=>" + city.Key + ": " + city.Value);
                }               
            }
        }
    }
}
