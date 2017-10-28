using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _01.Extract_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            var pattern = @"(?<=\s)[a-zA-Z0-9]+([.-]\w*)*@[a-z]+([.-]\w*)*(\.[a-z]+)";
            string input = Console.ReadLine();
            Regex regex = new Regex(pattern);
            foreach (Match m in Regex.Matches(input, pattern))
            {
                Console.WriteLine(m);
            }
            //Console.WriteLine(Regex.Match(input, pattern));
        }
    }
}
