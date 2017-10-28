using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _0201.Extract_Sentences_by_Keyword
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string text = Console.ReadLine();
            string[] sentences = text.Split(new char[] {'?', '!', '.'}, StringSplitOptions.RemoveEmptyEntries);
            Regex regex = new Regex(@"\b" +word+ @"\b");
            foreach (var sentence in sentences)
            {
                if (regex.IsMatch(sentence))
                {
                    Console.WriteLine(sentence.Trim());
                }   
            }
        }
    }
}
