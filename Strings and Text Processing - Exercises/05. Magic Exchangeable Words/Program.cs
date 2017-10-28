using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Magic_Exchangeable_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().Split();

            Dictionary<char, char> letters = new Dictionary<char, char>();
            var shorterLength = Math.Min(words[0].Length, words[1].Length);
            var firstWord = words[0];
            var secondWord = words[1];
            bool isExchangeable = true;

            for (int i = 0; i < shorterLength; i++)
            {
                if (!letters.ContainsKey(firstWord[i]))
                {
                    if (!letters.ContainsValue(secondWord[i]))
                    {
                     letters.Add(firstWord[i], secondWord[i]);   
                    }
                    else
                    {
                        isExchangeable = false;
                        break;
                    }
                }
                else
                {
                    if (letters[firstWord[i]] != secondWord[i])
                    {
                        isExchangeable = false;
                        break;
                    }
                }
            }
            string rest = "";
            if (firstWord.Length > secondWord.Length)
            {
                rest = firstWord.Substring(shorterLength);
            }
            else
            {
                rest = secondWord.Substring(shorterLength);
            }

            foreach (char chara in rest)
            {
                if (!letters.ContainsValue(chara) && !letters.ContainsKey(chara))
                {
                    isExchangeable = false;
                }
            }
            Console.WriteLine(isExchangeable.ToString().ToLower());
        }
    }
}
