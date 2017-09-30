using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03Min__Max__Sum__Average
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());


            var list = new List<int>(n);


            for (int i = 0; i < n; i++)
            {
                list.Add(int.Parse(Console.ReadLine()));
            }


                //list[i] = int.Parse(Console.ReadLine());
           // var list = Console.ReadLine().Split().Select(int.Parse).ToList();

            Console.WriteLine("Sum = {0}", list.Sum());
            Console.WriteLine("Min = {0}", list.Min());
            Console.WriteLine("Max = {0}", list.Max());
            Console.WriteLine("Average = {0}", list.Average());
        }
    }
}
