using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_User_Logs
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, Dictionary<string, int>> users = new SortedDictionary<string, Dictionary<string, int>>();
            string input = Console.ReadLine();

            while (input != "end")
            {
                var command = input.Split(' ');
                var ip = command[0].Substring(3);
                //Console.WriteLine(ip);
                var user = command[2].Substring(5);
                // Console.WriteLine(user);
                if (! users.ContainsKey(user))
                {
                    users[user] = new Dictionary<string, int>();

                }
                if (! users[user].ContainsKey(ip))
                {
                    users[user][ip] = 0;
                }
                users[user][ip]++;

                input = Console.ReadLine();
            }
            foreach (var us in users)
            {
                var user = us.Key;
                Console.WriteLine($"{us.Key}:");
                var ipCount = us.Value;
                var counter = 0;
                foreach (var item in us.Value)
                {
                    Console.Write($"{item.Key} => {item.Value}");
                    if (counter < us.Value.Count - 1)
                    {
                        Console.Write(", ");
                        counter++;
                    }
                    else
                    {
                        Console.WriteLine(".");
                    }
                }
            }
            
        }
    }
}
