using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {
            var keyMaterials = new Dictionary<string, int>();
            {
                keyMaterials["shards"] = 0;
                keyMaterials["fragments"] = 0;
                keyMaterials["motes"] = 0;
            }
            var junkMaterials = new Dictionary<string, int>();
            bool getMaterial = true;
            string win = String.Empty;
            while (getMaterial)
            {
                var input = Console.ReadLine().ToLower();
                var quantityMaterials = input.Split().ToList();
                for (int i = 0; i < quantityMaterials.Count - 1; i += 2)
                {
                    var quantity = int.Parse(quantityMaterials[i]);
                    var material = quantityMaterials[i + 1];
                    if (material == "shards" || material == "fragments" || material == "motes")
                    {
                        if (!keyMaterials.ContainsKey(material))
                        {
                            keyMaterials[material] = 0;
                        }
                        keyMaterials[material] += quantity;
                        if (keyMaterials.Values.Max() >= 250)
                        {
                            win = material;
                            keyMaterials[material] -= 250;
                            getMaterial = false;
                            break;
                        }
                    }
                    else
                    {
                        if (!junkMaterials.ContainsKey(material))
                        {
                            junkMaterials[material] = 0;
                        }
                        junkMaterials[material] += quantity;
                    }
                }            
            }
            string first = WindMethod(win);
            Console.WriteLine(first + " obtained!");
            keyMaterials = keyMaterials.OrderBy(x => x.Key)
                .OrderByDescending(x => x.Value)
                .ToDictionary(x => x.Key, x => x.Value);

            junkMaterials = junkMaterials.OrderBy(x => x.Key)
                .ToDictionary(x => x.Key, y => y.Value);
            foreach (var material in keyMaterials)
            {
                Console.WriteLine("{0}: {1}", material.Key, material.Value);
            }
            foreach (var material in junkMaterials)
            {
                Console.WriteLine("{0}: {1}", material.Key, material.Value);
            }
        }

        static string WindMethod(string win)
        {
            string result = String.Empty;
            if(win == "shards")
            {
                 result = "Shadowmourne";               
            }
            else if (win == "fragments")
            {
                result = "Valanyr";
            }
            else if (win == "motes")
            {
                result = "Dragonwrath";
            }
            return result;
        }
    }
}
