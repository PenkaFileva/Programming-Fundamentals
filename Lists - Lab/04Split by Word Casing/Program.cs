using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04Split_by_Word_Casing
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] separators = ",;:.!()\"'/\\[] ".ToCharArray();
            string[] words = Console.ReadLine()
                .Split(separators, StringSplitOptions.RemoveEmptyEntries);

            List<string> lowerCaseWords = new List<string>();
            List<string> upperCaseWords = new List<string>();
            List<string> mixedCaseWords = new List<string>();
            foreach (var word in words)
            {
                bool isAllLowerCase = true;
                bool isAllUpperrCase = true;
                for (int i = 0; i < word.Length; i++)
                {
                    if (char.IsLower(word[i]))
                    {
                        isAllUpperrCase = false;
                    }
                    else if (char.IsUpper(word[i]))
                    {
                        isAllLowerCase = false;
                    }
                    else
                    {
                        isAllLowerCase = false;
                        isAllUpperrCase = false;
                    }
                }
                if (isAllLowerCase)
                {
                    lowerCaseWords.Add(word);
                }
                else if (isAllUpperrCase)
                {
                    upperCaseWords.Add(word);
                }
                else
                {
                    mixedCaseWords.Add(word);
                }
                //for (int i = 0; i < input.Count; i++)  drugo reshenie
                //{
                //    if (input[i].All(char.IsLower))
                //    {
                //        lowerCase.Add(input[i]);
                //    }
                //    else if (input[i].All(char.IsUpper))
                //    {
                //        upperCase.Add(input[i]);
                //    }
                //    else
                //    {
                //        mixedCase.Add(input[i]);
                //    }
                //}
            Console.WriteLine("Lower-case: "+String.Join(", ", lowerCaseWords));
            Console.WriteLine("Mixed-case: "+String.Join(", ", mixedCaseWords));
            Console.WriteLine("Upper-case: "+String.Join(", ", upperCaseWords));
        }
    }
}