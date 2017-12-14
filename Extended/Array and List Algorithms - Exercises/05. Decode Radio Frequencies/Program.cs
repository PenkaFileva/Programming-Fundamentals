using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Decode_Radio_Frequencies
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').ToArray();
            var leftPart = new List<char>();
            var rightPart = new List<char>();
            for (int i = 0; i < numbers.Length; i++)
            {
                var currentNum = numbers[i].Split('.');
                var leftChar = (int.Parse(currentNum[0]));
                if (leftChar == 0)
                {
                    continue;
                }
                leftPart.Add((char)leftChar);
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                var currentNum = numbers[i].Split('.');
                var rightChar = (int.Parse(currentNum[1]));
                if (rightChar == 0)
                {
                    continue;
                }
                rightPart.Insert(0, (char)rightChar);
            }
            var result = leftPart.Concat(rightPart);
            Console.WriteLine(string.Join("", result));
        }
    }
}
