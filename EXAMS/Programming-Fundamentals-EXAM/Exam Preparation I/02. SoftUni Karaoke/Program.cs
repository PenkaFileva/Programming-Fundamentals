using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.SoftUni_Karaoke
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] allPlayers = Regex.Split(Console.ReadLine(), @"\s*,\s*");
            string[] allSongs = Console.ReadLine().Split(',')
                .Select(a => a.Trim()).ToArray();

            Dictionary<string, List<string>> awardsByPlayer = 
                new Dictionary<string, List<string>>();
            foreach (var p in allPlayers)
            {
                awardsByPlayer[p] = new List<string>();
            }
            while (true)
            {
                var command = Console.ReadLine();
                if (command == "dawn") break;
                var tokens = Regex.Split(command, @"\s*,\s*");
                var player = tokens[0];
                var song = tokens[1];
                var award = tokens[2];
                if (allPlayers.Contains(player) && allSongs.Contains(song))
                { 
                  awardsByPlayer[player].Add(award);  
                }
            }
            var result = awardsByPlayer.Select(item => new
                {
                    playerName = item.Key,
                    awards = item.Value.Distinct().OrderBy(a => a),
                    awardsCount = item.Value.Distinct().Count()
                })
                .OrderByDescending(p => p.awardsCount)
                .ThenBy(p => p.playerName)
                .Where(p => p.awardsCount > 0)
                .ToArray();

            foreach (var p in result)
            {
                Console.WriteLine("{0}: {1} awards", p.playerName, p.awardsCount);
                foreach (var w in p.awards)
                {
                    Console.WriteLine("--{0}", w);
                }
            }
            if (result.Length == 0)
            {
                Console.WriteLine("No awards");
            }
        }
    }
}
