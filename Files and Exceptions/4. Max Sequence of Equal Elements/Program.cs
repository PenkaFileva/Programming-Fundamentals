using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Max_Sequence_of_Equal_Elements
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
                var inputArr = lines[i].Split().Select(int.Parse).ToArray();
                var maxSequence = FindMaxSequence(inputArr);

                var output = String.Join(" ", maxSequence) + Environment.NewLine;

                File.AppendAllText(outputFileName, output);
            }
        }

        static int[] FindMaxSequence(int[] arr)
        {
            var longestSequence = new List<int>();
            var currentSequence = new List<int>();
            currentSequence.Add(arr[0]);
            for (int i = 1; i < arr.Length; i++)
            {
                var currentNum = arr[i];
                var serchNum = currentSequence[0];
                if (currentNum == serchNum)
                {
                    currentSequence.Add(currentNum);
                }
                else
                {
                    if (currentSequence.Count > longestSequence.Count)
                    {
                        longestSequence = new List<int>(currentSequence);
                    }
                    currentSequence.Clear();
                    currentSequence.Add(currentNum);
                }
            }
            if (currentSequence.Count > longestSequence.Count)
            {
                longestSequence = new List<int>(currentSequence);
            }
            return longestSequence.ToArray();
        }
    }
}
