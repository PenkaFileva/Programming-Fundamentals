using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _08.Use_Your_Chains__Buddy
{
    class Program
    {
        static void Main(string[] args)
        {
            var paragraphRregex = new Regex(@"<p>(?<message>.+?)<\/p>");
            var text = Console.ReadLine();
            var paragraphs = paragraphRregex.Matches(text).Cast<Match>().Select(a => a.Groups["message"].Value)
                .Select(a => Regex.Replace(a, @"[^a-z\d]", " "))
                .Select(a => Regex.Replace(a, @"\s+", " ")).ToArray();
            for (int i = 0; i < paragraphs.Length; i++)
            {
                paragraphs[i] = Rot13String(paragraphs[i]);
            }
            var result = new StringBuilder();
            foreach (var paragraph in paragraphs)
            {
                result.Append(paragraph);
            }
            Console.WriteLine(result.ToString());
        }

        private static string Rot13String(string input)
        {
            var result = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                var letter = Rot13(input[i]);
                result.Append(letter);
            }
            return result.ToString();
        }

        private static char Rot13(char letter)
        {
            if (!char.IsLetter(letter))
            {
                return letter;
            }
            var offset = char.IsUpper(letter) ? 'A' : 'a';
            var rotatedLetter = (char) ((letter - offset + 13) % 26 + offset);
            return rotatedLetter;
        }
    }
}
