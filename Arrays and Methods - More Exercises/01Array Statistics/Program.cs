using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Array_Statistics
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] num = Console.ReadLine().Split().Select(double.Parse).ToArray();

            double min = double.MaxValue;
            double max = double.MinValue;
            double sum = 0;
            double count = 0;
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] < min)
                {
                    min = num[i];
                }
                if (num[i] > max)
                {
                    max = num[i];
                }
                sum += num[i];
                count++;
            }
            double average = sum / count; ;
            Console.WriteLine("Min = {0}", min);
            Console.WriteLine("Max = {0}", max);
            Console.WriteLine("Sum = {0}", sum);
            Console.WriteLine("Average = {0}", average);
        }
    }
}
