using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            var strings = Console.ReadLine().Split();
            var firstString = strings[0];
            var secondStrings = strings[1];
            var sum = 0;
            var shorterLength = Math.Min(firstString.Length, secondStrings.Length);
            for (int i = 0; i < shorterLength; i++)
            {
                var firstLetter =(int) firstString[i];
                var secondLetter =(int) secondStrings[i];
                sum += firstLetter * secondLetter;
            }
            var longerString = firstString.Length > secondStrings.Length ? firstString : secondStrings;
            for (int i = shorterLength; i < longerString.Length; i++)
            {
                sum += longerString[i];
            }
            Console.WriteLine(sum);
        }
    }
}
