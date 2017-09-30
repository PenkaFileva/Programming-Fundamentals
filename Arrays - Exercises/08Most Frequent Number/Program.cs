using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08Most_Frequent_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int resultNumber = 0;
            int counter = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                int tempCounter = 0;
                foreach (var item in arr)
                {
                    if (arr[i] == item)
                    {
                        tempCounter++;
                    }
                }
                if (tempCounter > counter)
                {
                    counter = tempCounter;
                    resultNumber = arr[i];
                }
            }
            Console.WriteLine(resultNumber);
        }
    }
}
