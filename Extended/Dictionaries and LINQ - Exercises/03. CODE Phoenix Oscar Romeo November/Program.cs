using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CODE_Phoenix_Oscar_Romeo_November
{
    class Program
    {
        static void Main(string[] args)
        {
            var creatureSquadMate = new Dictionary<string, HashSet<string>>();
            var check = new List<string>();

            string input = Console.ReadLine();
            while (input != "Blaze it!")
            {
                var tokens = input.Split("-> ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                var creature = tokens[0];
                var squadMate = tokens[1];
                check.Add(squadMate + "" + creature);
                if (!creatureSquadMate.ContainsKey(creature))
                {
                    creatureSquadMate[creature] = new HashSet<string>();
                }
                if (creature == squadMate)
                {
                    input = Console.ReadLine();
                    continue;
                }
                if (check.Contains(creature + "" + squadMate))
                {
                    creatureSquadMate[squadMate].Remove(creature);
                    input = Console.ReadLine();
                    continue;
                }
                
                creatureSquadMate[creature].Add(squadMate);    
                input = Console.ReadLine();
            }
            foreach (var item in creatureSquadMate.OrderByDescending(a => a.Value.Count))
            {
                Console.WriteLine($"{item.Key} : {item.Value.Count}");
            }
            
        }
    }
}
