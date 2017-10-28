using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Camera_View
{
    class Program
    {
        static void Main(string[] args)
        {
            var count = Console.ReadLine().Split();
            var skip = int.Parse(count[0]);
            var take = int.Parse(count[1]);


            var input = Console.ReadLine();
            Regex rgx = new Regex(@"(?<=\|<)(?<text>\w+)");
            var matches = rgx.Matches(input).Cast<Match>()
                .Select(a => a.Groups["text"].Value).ToArray();

            var output = new List<string>();
            foreach (var match in matches)
            {
                if (match.Length >= skip+take)
                {
                    output.Add(match.Substring(skip, take));
                }
                else if (match.Length < skip + take)
                {
                    output.Add(match.Remove(0, skip));
                }
                else if (match.Length <= skip)
                {
                    continue;
                }
            }
            Console.WriteLine(string.Join(", ", output));
        }
    }
}
