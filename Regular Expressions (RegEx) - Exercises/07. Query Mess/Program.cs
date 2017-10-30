using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _07.Query_Mess
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input!="END")
            {
                Regex pattern = new Regex(@"([^&=?]*)=([^&=]*)");
                Regex regex = new Regex(@"((%20|\+)+)");

                MatchCollection matches = pattern.Matches(input);
                Dictionary<string, List<string>> results = new Dictionary<string, List<string>>();
                for (int i = 0; i < matches.Count; i++)
                {
                    string field = matches[i].Groups[1].Value;
                    field = regex.Replace(field, word => " ").Trim();
                    string value = matches[i].Groups[2].Value;
                    value = regex.Replace(value, word => " ").Trim();
                    if (!results.ContainsKey(field))
                    {
                        List<string> values = new List<string>();
                        values.Add(value);
                        results[field] = values;
                    }
                    else if (results.ContainsKey(field))
                    {
                        results[field].Add(value);
                    }
                    
                }
                foreach (var item in results)
                {
                    Console.Write("{0}=[{1}]", item.Key, string.Join(", ", item.Value));
                }
                Console.WriteLine();
                input = Console.ReadLine();
            }
            
        }
    }
}
