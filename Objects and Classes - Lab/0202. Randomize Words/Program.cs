using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0202.Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ');
            Random rnd = new Random();
            for (int pos1 = 0; pos1 < words.Length; pos1++)
            {
                int pos2 = rnd.Next(words.Length);
                if (pos1 != pos2)
                {
                    var old = words[pos1];
                    words[pos1] = words[pos2];
                    words[pos2] = old;
                }
                // TODO: swap words[pos1] with words[pos2]
            }
            Console.WriteLine(string.Join("\r\n", words));

        }
    }
}
