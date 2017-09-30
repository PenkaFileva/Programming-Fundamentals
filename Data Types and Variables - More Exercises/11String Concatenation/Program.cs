using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11String_Concatenation
{
    class Program
    {
        static void Main(string[] args)
        {
            char delimiter = char.Parse(Console.ReadLine());
            string element = Console.ReadLine().ToLower().Trim();
            int n = int.Parse(Console.ReadLine());
            int temp = 1;
            string message = String.Empty;
            if (element == "even")
            {
                temp = 0;
            }
            for (int i = 1; i <= n; i++)
            {
                string word = Console.ReadLine();
                if (i % 2 == temp)
                {
                    message += word + delimiter;
                }
            }
            Console.WriteLine(message.Remove(message.Length-1));
        }
    }
}
