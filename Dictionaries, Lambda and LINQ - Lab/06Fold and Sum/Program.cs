using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int k = arr.Length / 4;
            int[] row1left = arr.Take(k).Reverse().ToArray();
            int[] row1right = arr.Reverse().Take(k).ToArray();
            int[] row1 = row1left.Concat(row1right).ToArray();
            int[] row2 = arr.Skip(k).Take(2 * k).ToArray();
            var list = new List<int>();
            for (int i = 0; i < k*2; i++)
            {
                var result = row1[i] + row2[i];
                list.Add(result);
            }
            Console.WriteLine(String.Join(" ", list));
        }
    }
}
