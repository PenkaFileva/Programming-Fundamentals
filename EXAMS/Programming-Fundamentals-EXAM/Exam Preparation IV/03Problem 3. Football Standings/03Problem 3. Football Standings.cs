using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03Problem_3.Football_Standings
{
    class Program
    {
        static void Main(string[] args)
        {
            var key = Console.ReadLine();
            key = Regex.Escape(key);
            var regex = $@"{key}(?<teamOne>.*?){key}.+?{key}(?<teamTwo>.*?){key}.+?(?<teamOneGoals>\d+):(?<teamTwoGoals>\d+)";
            Dictionary<string, long> teamsPoints = new Dictionary<string, long>();
            Dictionary<string, long> teamsGoals = new Dictionary<string, long>();

            while (true)
            {
                var input = Console.ReadLine();
                if (input == "final") break;

                MatchCollection matchInfo = Regex.Matches(input, regex);

                foreach (Match match in matchInfo)
                {
                    var teamOne = new string(match.Groups["teamOne"].Value.Reverse().ToArray()).ToUpper();
                    var teamTwo = new string(match.Groups["teamTwo"].Value.Reverse().ToArray()).ToUpper();
                    var teamOneGoals = long.Parse(match.Groups["teamOneGoals"].Value);
                    var teamTwoGoals = long.Parse(match.Groups["teamTwoGoals"].Value);
                    var teamOnePoints = 0;
                    var teamTwoPoints = 0;
                    if (teamOneGoals > teamTwoGoals)
                    {
                        teamOnePoints = 3;
                    }
                    else if (teamOneGoals < teamTwoGoals)
                    {
                        teamTwoPoints = 3;
                    }
                    else if (teamOneGoals == teamTwoGoals)
                    {
                        teamOnePoints = 1;
                        teamTwoPoints = 1;
                    }
                    if (!teamsPoints.ContainsKey(teamOne))
                    {
                        teamsPoints[teamOne] = 0;
                    }
                    if (!teamsPoints.ContainsKey(teamTwo))
                    {
                        teamsPoints[teamTwo] = 0;
                    }
                    teamsPoints[teamOne] += teamOnePoints;
                    teamsPoints[teamTwo] += teamTwoPoints;

                    if (!teamsGoals.ContainsKey(teamOne))
                    {
                        teamsGoals[teamOne] = 0;
                    }
                    if (!teamsGoals.ContainsKey(teamTwo))
                    {
                        teamsGoals[teamTwo] = 0;
                    }
                    teamsGoals[teamOne] += teamOneGoals;
                    teamsGoals[teamTwo] += teamTwoGoals;
                }
            }
            var line = 1;
            Console.WriteLine("League standings:");
            foreach (var teamPoint in teamsPoints.OrderByDescending(a => a.Value).ThenBy(a => a.Key))
            {
                Console.WriteLine($"{line++}. {teamPoint.Key} {teamPoint.Value}");
            }
            Console.WriteLine("Top 3 scored goals:");
            foreach (var teamsGoal in teamsGoals.OrderByDescending(a => a.Value).ThenBy(a => a.Key).Take(3))
            {
                Console.WriteLine($"- {teamsGoal.Key} -> {teamsGoal.Value}");
            }
        }
    }
}
