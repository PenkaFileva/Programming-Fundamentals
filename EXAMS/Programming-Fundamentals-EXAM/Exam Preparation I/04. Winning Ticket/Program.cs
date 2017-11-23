using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.Winning_Ticket
{
    class Program
    {
        static void Main(string[] args)
        {
            var tickets = Regex.Split(Console.ReadLine(), @"\s*,\s*")
                .Select(t => t.Trim())
                .Where(t => t.Length > 0).ToArray();

            foreach (var t in tickets)
            {
                if (t.Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                }
                else
                {
                    var leftSide = t.Substring(0, 10);
                    var rightSide = t.Substring(10);
                    var leftLongestSeq = FindMaxEqualseq(leftSide);
                    var rightLongestSeq = FindMaxEqualseq(rightSide);
                    if (leftLongestSeq.Length >= 6 && rightLongestSeq.Length >= 6
                        && leftLongestSeq[0] == rightLongestSeq[0]
                        && "@#$^".Contains(leftLongestSeq[0]))
                    {
                        var count = Math.Min(leftLongestSeq.Length, rightLongestSeq.Length);
                        Console.Write($"ticket \"{t}\" - {count}{leftLongestSeq[0]}");
                        if(count == 10)
                            Console.Write(" Jackpot!");
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine($"ticket \"{t}\" - no match");
                    }
                }
            }
        }

        private static string FindMaxEqualseq(string s)
        {
            var beststr = "" + s[0];
            var max = 1;
             
            for (int i = 0; i < s.Length-1; i++)
            {
                var ch = s[i];
                var count = 1;
                while (i + count < s.Length && s[i + count] == s[i])
                {
                    count++;
                    if (count > max)
                    {
                        max = count;
                        beststr = s.Substring(i, count);
                    }
                }
            }
            return beststr;
        }
    }
}
