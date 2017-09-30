using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06Triples_of_Latin_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char letter = (char)('a' + n - 1);
            for (char i = 'a'; i <= letter; i++)
            {
                for (char j = 'a'; j <= letter; j++)
                {
                    for (char k = 'a'; k <= letter; k++)
                    {
                        Console.WriteLine(""+(char)i + (char)j + (char)k);
                    }
                }
            }

        }
    }
}
