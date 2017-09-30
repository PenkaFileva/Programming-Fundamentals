using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04Fix_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            var namesEmails = new Dictionary<string, string>();
            var line = Console.ReadLine();
            while (line != "stop")
            {
                var name = line;
                var email = Console.ReadLine();
                namesEmails[name] = email;
                line = Console.ReadLine();
            }
            var fixedEmail = namesEmails.Where(kvp => !(kvp.Value.EndsWith("us") || kvp.Value.EndsWith("uk"))).ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
            foreach (var nameEmail in fixedEmail)
            {
                var name = nameEmail.Key;
                var email = nameEmail.Value;
                Console.WriteLine("{0} -> {1}", name, email);
            }
        }
    }
}
