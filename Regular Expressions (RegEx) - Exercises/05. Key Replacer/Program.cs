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
            var input = Console.ReadLine().Split(new char[]{'|', '<'}, StringSplitOptions.RemoveEmptyEntries);
            var startKey = input[0];
            var endKey = input[2];
            var line = Console.ReadLine();
            Regex regex = new Regex($@"{startKey}(?<word>.*?){endKey}");
            var matches = regex.Matches(line).Cast<Match>().Select(a => a.Groups["word"].Value).ToArray();
            string output = String.Empty;
            foreach (var match in matches)
            {
                output += match;
            }
            if (output == "")
            {
                Console.WriteLine("Empty result");
            }
            else
            {
                Console.WriteLine(output);
            }
            
        }
    }
}
