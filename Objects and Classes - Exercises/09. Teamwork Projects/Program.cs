using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Teamwork_Projects
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            Dictionary<string, string> teamCreator = new Dictionary<string, string>();
            Dictionary<string, List<string>> teamMembers = new Dictionary<string, List<string>>();
            for (int i = 0; i < count; i++)
            {
                string[] newTeam = Console.ReadLine().Split('-').ToArray();
                var nameTeam = newTeam[1];
                var leaderTeam = newTeam[0];
                if (teamCreator.ContainsKey(nameTeam))
                {
                    Console.WriteLine("Team {0} was already created!", nameTeam);
                    continue;
                }
                if(teamCreator.ContainsValue(leaderTeam))
                {
                    Console.WriteLine("{0} cannot create another team!", leaderTeam);
                    continue;
                }
                teamCreator[nameTeam] = leaderTeam;
                teamMembers[nameTeam] = new List<string>();
                Console.WriteLine("Team {0} has been created by {1}!", nameTeam, leaderTeam);
                
            }
            string userRegistration = Console.ReadLine();
            while (userRegistration != "end of assignment")
            {
                var tokens = userRegistration.Split('-', '>').ToArray();
                var user = tokens[0];
                var teamName = tokens[2];
                if (!teamMembers.ContainsKey(teamName))
                {
                    Console.WriteLine("Team {0} does not exist!", teamName);
                    userRegistration = Console.ReadLine();
                    continue;
                }
                if (teamMembers.Any(x => x.Value.Contains(user)) || teamCreator.Any(x => x.Value == user))
                {
                    Console.WriteLine("Member {0} cannot join team {1}!", user, teamName);
                    userRegistration = Console.ReadLine();
                    continue;
                }
                teamMembers[teamName].Add(user);
                userRegistration = Console.ReadLine();
            }
            List<string> listDisband = new List<string>();
            foreach (var item in teamMembers.OrderByDescending(a => a.Value.Count).ThenBy(a => a.Key))
            {
                if (item.Value.Count== 0)
                {
                    listDisband.Add(item.Key);
                    teamMembers.Remove(item.Key);
                    continue;                   
                }
                Console.WriteLine("{0}", item.Key);
                Console.WriteLine("- {0}", teamCreator[item.Key]);
                foreach (var user in item.Value)
                {
                    Console.WriteLine("-- {0}", user);
                }
            }
            Console.WriteLine("Teams to disband:");
            foreach (var item in listDisband)
            {
                Console.WriteLine(item);
            }
        }
    }
}
