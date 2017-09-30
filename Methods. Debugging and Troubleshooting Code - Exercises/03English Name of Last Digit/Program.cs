using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03English_Name_of_Last_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            string englishName = EnglishNameLastDigit(num);
            Console.WriteLine(englishName);
        }

        static string EnglishNameLastDigit(int num)
        {
            int lastDigit= Math.Abs(num % 10);
            string englishName = String.Empty;
            switch (lastDigit)
            {
                case 0: englishName = "zero";break;
                case 1: englishName = "one"; break;
                case 2: englishName = "two"; break;
                case 3: englishName = "three"; break;
                case 4: englishName = "four"; break;
                case 5: englishName = "five"; break;
                case 6: englishName = "six"; break;
                case 7: englishName = "seven"; break;
                case 8: englishName = "eight"; break;
                case 9: englishName = "nine"; break;
                default:
                    break;
            }
            return englishName;
        }

    }
}
