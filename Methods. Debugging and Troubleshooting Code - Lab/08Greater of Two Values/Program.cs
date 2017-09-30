using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToLower().Trim();
            if (text == "int")
            {
                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());
                Console.WriteLine(GetMax(num1, num2));
            }
            else if (text == "char")
            {
                char letter1 = char.Parse(Console.ReadLine());
                char letter2 = char.Parse(Console.ReadLine());
                Console.WriteLine(GetMax(letter1, letter2));
            }
            else if (text == "string")
            {
                string word1 = Console.ReadLine();
                string word2 = Console.ReadLine();
                Console.WriteLine(GetMax(word1, word2));
            }
        }

        static string GetMax(string word1, string word2)
        {
            if (word1.CompareTo(word2) >= 0)
            {
                return word1;
            }
            else
            {
                return word2;
            }
        }

        static int GetMax(int num1, int num2)
        {
            if (num1 >= num2)
            {
                return num1;
            }
            else
            {
                return num2;
            }
        }

        static char GetMax(char letter1, char letter2)
        {
            if (letter1 >= letter2)
            {
                return letter1;
            }
            else
            {
                return letter2;
            }
        }
    }
}
