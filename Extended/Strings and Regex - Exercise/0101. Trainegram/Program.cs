using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _0101.Trainegram
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var pattern = @"^(<\[[^a-zA-Z0-9\n]*]\.)(\.\[[a-zA-Z0-9]*]\.)*$";

            while (input != "Traincode!")
            {
                if (Regex.IsMatch(input, pattern))
                {
                    Console.WriteLine(input);
                }
                input = Console.ReadLine();
            }

        }
    }
}
