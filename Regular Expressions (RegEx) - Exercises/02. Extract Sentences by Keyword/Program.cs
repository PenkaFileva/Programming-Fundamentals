using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.Extract_Sentences_by_Keyword
{
    class Program
    {
        static void Main(string[] args)
        {
            string key = Console.ReadLine();
            string input = Console.ReadLine();
            string pattern = @"([^.!?]+)([\W])";
            Regex regex = new Regex(pattern);
            string keyWordPattern = string.Format(@"(\b" + key + @"\b)");
            Regex rgxKeyW = new Regex(keyWordPattern);
            MatchCollection matches = regex.Matches(input);
            foreach (Match match in matches)
            {
                if (rgxKeyW.IsMatch(match.Groups[1].Value))
                {
                    Console.WriteLine(match.Groups[1].Value.Trim());
                }

            }
        }
    }
}
