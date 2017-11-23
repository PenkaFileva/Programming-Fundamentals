using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _04.Hornet_Armada
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            Dictionary<string, long> legionActivity = 
                new Dictionary<string, long>();
            Dictionary<string, Dictionary<string, long>> legionSoldierType = 
                new Dictionary<string, Dictionary<string, long>>();
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(new char[] {'=', '-', '>', ':', ' '}, 
                    StringSplitOptions.RemoveEmptyEntries);
                var activity = long.Parse(input[0]);
                var legionName = input[1];
                var soldierType = input[2];
                var soldierCount = long.Parse(input[3]);

                if (!legionActivity.ContainsKey(legionName))
                {
                    legionActivity.Add(legionName, activity);   
                }
                else if (legionActivity.ContainsKey(legionName))
                {
                    if (activity > legionActivity[legionName])
                    {
                        legionActivity[legionName] = activity;
                    }
                }

                if (!legionSoldierType.ContainsKey(legionName))
                {
                    legionSoldierType[legionName] = new Dictionary<string, long>();
                    legionSoldierType[legionName].Add(soldierType, 0);
                }
                else if (!legionSoldierType[legionName].ContainsKey(soldierType))
                {
                    legionSoldierType[legionName][soldierType] = 0;
                }
                legionSoldierType[legionName][soldierType] += soldierCount;
            }

            var line = Console.ReadLine().Split('\\');
            if (line.Length > 1)
            {
                var activitys = long.Parse(line[0]);
                var soldiersType = line[1];
                foreach (var leg in legionSoldierType
                    .Where(leg => leg.Value.ContainsKey(soldiersType))
                    .OrderByDescending(leg => leg.Value[soldiersType]))
                {
                    if (legionActivity[leg.Key] < activitys)
                    {
                        Console.WriteLine("{0} -> {1}", leg.Key, legionSoldierType[leg.Key][soldiersType]);
                    }
                }
            }
            else
            {
                var soldiersType = line[0];
                foreach (var leg in legionActivity
                .OrderByDescending(leg => leg.Value))
                {
                    if (legionSoldierType[leg.Key].ContainsKey(soldiersType))
                    {
                        Console.WriteLine("{0} : {1}", leg.Value, leg.Key);
                    }
                }
            }
            
        }
    }
}
