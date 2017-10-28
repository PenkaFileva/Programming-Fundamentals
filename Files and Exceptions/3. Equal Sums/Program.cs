using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Equal_Sums
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
                bool isIndexFound = false;
                for (int currentNum = 0; currentNum < arr.Length; currentNum++)
                {
                    int leftSum = 0;
                    int rightSUm = 0;
                    for (int k = 0; k < currentNum; k++)
                    {
                        leftSum += arr[k];
                    }
                    for (int k = currentNum + 1; k < arr.Length; k++)
                    {
                        rightSUm += arr[k];
                    }
                    if (leftSum == rightSUm)
                    {
                        //Console.WriteLine(currentNum);
                        var output = $"{currentNum}" + Environment.NewLine;

                        File.AppendAllText(outputFileName, output);
                        isIndexFound = true;
                        break;
                    }

                }
                if (!isIndexFound)
                {
                    //Console.WriteLine("no");
                    var output = "no" + Environment.NewLine;

                    File.AppendAllText(outputFileName, output);
                }
            }
           
        }
    }
}
