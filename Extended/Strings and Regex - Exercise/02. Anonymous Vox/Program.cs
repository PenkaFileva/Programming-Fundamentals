using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace _02.Anonymous_Vox
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string[] values = Console.ReadLine()
                .Split("{}".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            var pattern = @"([a-zA-Z]+)(.*)(\1)";

            MatchCollection matchText = Regex.Matches(text, pattern);
            var count = 0;
            foreach (Match m in matchText)
            {
                string line = m.Groups[1] + values[count++] + m.Groups[3];
                text = text.Replace(m.Value, line);

            }
            Console.WriteLine(text);
        }
    }
}
