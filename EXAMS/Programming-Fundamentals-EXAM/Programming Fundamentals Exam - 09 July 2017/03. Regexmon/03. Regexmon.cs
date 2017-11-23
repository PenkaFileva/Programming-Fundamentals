using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Regexmon
{
    class Program
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine();
            var bojoRegex = new Regex(@"[a-zA-Z]+-[a-zA-Z]+");
            var didiRegex = new Regex(@"[^a-zA-Z\-]+");

            string matchText = "";
            int index = 0;
                
            while (true)
            {
                
                var didiMatch = didiRegex.Match(line, index);
                if (didiMatch.Success)
                {
                    matchText = didiMatch.Value;
                    index = didiMatch.Index + matchText.Length;
                    Console.WriteLine(matchText);
                }
                else
                {
                    break;
                }
                var bojoMatch = bojoRegex.Match(line, index);
                if (bojoMatch.Success)
                {
                    matchText = bojoMatch.Value;
                    index = bojoMatch.Index + matchText.Length;
                    Console.WriteLine(matchText);
                }
                else
                {
                    break;
                }

            }
        }
    }
}
