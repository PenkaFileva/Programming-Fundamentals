using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Count_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().Split().Select(double.Parse).ToList();
            words.Sort();
            var dict = new Dictionary<double, int>();
            foreach (var w in words)
            {
                if (dict.ContainsKey(w))
                {
                    dict[w]++;
                }
                else
                {
                    dict[w] = 1;
                }
            }
            foreach (var p in dict)
            {

                Console.WriteLine(p.Key + " -> " + p.Value);
            }
            
        }
    }
}
