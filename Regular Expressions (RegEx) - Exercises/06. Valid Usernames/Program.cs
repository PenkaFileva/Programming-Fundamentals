using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _06.Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] {' ',',','/','\\','(',')'}, StringSplitOptions.RemoveEmptyEntries);
            Regex regex = new Regex(@"\b[a-zA-Z][a-zA-Z0-9_]{2,25}\b");
            
            List<string> words = new List<string>();
            foreach (var word in input)
            {
                if (regex.IsMatch(word))
                {
                    words.Add(word);
                }   
            }
            int sumMax = 0;
            string first = String.Empty;
            string second = String.Empty;
            for (int i = 1; i < words.Count; i++)
            {
                int currentSum = words[i - 1].Length + words[i].Length;
                if (currentSum > sumMax)
                {
                    sumMax = currentSum;
                    first = words[i - 1];
                    second = words[i];
                }
            }
            Console.WriteLine(first);
            Console.WriteLine(second);
        }
    }
}
