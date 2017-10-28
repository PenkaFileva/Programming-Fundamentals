using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = File.ReadAllLines("input.txt");
            var number = Directory.GetFiles(".")
                .Where(f => f.StartsWith(".\\output"))
                .Select(f => f.Split('_').Skip(1).FirstOrDefault())
                .Where(f => f != null)
                .Select(f => f.Replace(".txt", ""))
                .Select(int.Parse)
                .ToList();
           
            int nextNumber = 0;
            if (number.Any())
            {
                nextNumber = number.Max() + 1;
            }
            var outputFileName = "output_" + nextNumber + ".txt";

            var resourcesQuantities = new Dictionary<string, decimal>();
            for (int i = 0; i < lines.Length; i+=2)
            {
                if (lines[i] == "stop" || lines[i + 1] == "stop")
                {
                    break;
                }
                var resource = lines[i];
                var quantity = decimal.Parse(lines[i+1]);
                if (!resourcesQuantities.ContainsKey(resource))
                {
                    resourcesQuantities[resource] = 0;
                }
                resourcesQuantities[resource] += quantity;                
            }

            foreach (var resourceQuantity in resourcesQuantities)
            {
                var resouce = resourceQuantity.Key;
                var quantity = resourceQuantity.Value;
                var output = $"{resouce} -> {quantity}" + Environment.NewLine;
                File.AppendAllText(outputFileName, output);
            }

        }
    }
}
