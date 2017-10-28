using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Index_of_Letters
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
                char[] letters = lines[i].ToArray();
                for (int k = 0; k < letters.Length; k++)
                {
                    var output = $"{letters[k]} -> {letters[k] - 'a'}" + Environment.NewLine;
                    File.AppendAllText(outputFileName, output);
                }
                File.AppendAllText(outputFileName, Environment.NewLine);
            }            
        }
    }
}
