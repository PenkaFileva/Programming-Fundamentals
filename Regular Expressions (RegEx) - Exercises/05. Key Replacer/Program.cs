using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _05.Key_Replacer
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new char[]{'|', '<', '\\'}, StringSplitOptions.RemoveEmptyEntries);
            var startKey = input[0];
            var endKey = input[2];
            var line = Console.ReadLine();
            Regex regex = new Regex($@"{startKey}(?<word>.*?){endKey}");
            MatchCollection matches = regex.Matches(line);
            var result = new StringBuilder();

            foreach (Match match in matches)
            {
                result.Append(match.Groups["word"].Value);
            }

            Console.WriteLine(result.ToString().Length == 0 ? "Empty result" : result.ToString());

        }
    }
}
