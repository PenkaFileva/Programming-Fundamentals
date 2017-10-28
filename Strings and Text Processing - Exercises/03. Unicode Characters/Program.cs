using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Unicode_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().ToCharArray();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < words.Length; i++)
            {
                sb.AppendFormat("\\u{0:x4}", (int) words[i]);
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
