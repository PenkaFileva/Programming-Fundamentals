using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06Square_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToList();
            var squareNumrer = new List<long>();
            for (int i = 0; i < input.Count; i++)
            {
                if (Math.Sqrt(input[i]) == Math.Floor(Math.Sqrt(input[i])))
                {
                    squareNumrer.Add(input[i]);
                }
            }
            squareNumrer.Sort((a, b) => b.CompareTo(a));
            Console.WriteLine(String.Join(" ", squareNumrer));
        }
    }
}
