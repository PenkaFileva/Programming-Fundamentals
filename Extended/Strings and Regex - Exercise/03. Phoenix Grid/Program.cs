using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Phoenix_Grid
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            var pattern = @"^([^\s_]{3})(\.[^\s_]{3})*$";
            var regex = new Regex(pattern);

            while (text != "ReadMe")
            {
                if (regex.IsMatch(text))
                {
                    if (IsPalindrom(text))
                    {
                        Console.WriteLine("YES");
                    }
                    else
                    {
                        Console.WriteLine("NO");
                    }
                }
                else
                {
                    Console.WriteLine("NO");
                }

                text = Console.ReadLine();
            }
        }

        static bool IsPalindrom(string word)
        {
            for (int i = 0; i < word.Length/2; i++)
            {
                if (word[i] != word[word.Length - 1 - i])
                {
                    return false;
                }
                
            }
            return true;
        }
    }
}
