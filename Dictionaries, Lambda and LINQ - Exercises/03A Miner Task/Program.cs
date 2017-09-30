using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            var resourcesQuantities = new Dictionary<string, decimal>();
            var line = Console.ReadLine();
            while (line != "stop")
            {
                var resource = line;
                var quantity = decimal.Parse(Console.ReadLine());
                if (!resourcesQuantities.ContainsKey(resource))
                {
                    resourcesQuantities[resource] = 0;
                }
                resourcesQuantities[resource] += quantity;
                line = Console.ReadLine();
            }
            foreach (var resourceQuantity in resourcesQuantities)
            {
                var resouce = resourceQuantity.Key;
                var quantity = resourceQuantity.Value;
                Console.WriteLine("{0} -> {1}", resouce, quantity);
            }
        }
    }
}
