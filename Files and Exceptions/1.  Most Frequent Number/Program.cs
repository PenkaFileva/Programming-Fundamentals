using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Most_Frequent_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = File.ReadAllLines("input.txt");
            var number = Directory.GetFiles(".")
                .Where(f => f.StartsWith(".\\output"))
                .Select(f => f.Split('_').Skip(1).FirstOrDefault())
                .Where(f => f != null)
                .Select(f => f.Replace(".txt", ""))
                .Select(int.Parse)
                .ToList();
           
            int nextNumber = 0;
            if (number.Any())
            {
                nextNumber = number.Max() + 1;
            }
            var outputFileName = "output_" + nextNumber + ".txt";

            for (int i = 0; i < lines.Length; i++)
            {
                int[] arr = lines[i].Split().Select(int.Parse).ToArray();
                int resultNumber = 0;
                int counter = 0;
                for (int k = 0; k < arr.Length; k++)
                {
                    int tempCounter = 0;
                    foreach (var item in arr)
                    {
                        if (arr[k] == item)
                        {
                            tempCounter++;
                        }
                    }
                    if (tempCounter > counter)
                    {
                        counter = tempCounter;
                        resultNumber = arr[k];
                    }
                }
                //Console.WriteLine(resultNumber);
                var output = $"{resultNumber}" + Environment.NewLine;
                File.AppendAllText(outputFileName, output);
            }
           
        }  
    }
}
