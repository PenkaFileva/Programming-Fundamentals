using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Advertisement_Message
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

            var phrases = lines[0].Split(',').ToArray();
            var events = lines[1].Split(',').ToArray();
            var authors = lines[2].Split(',').ToArray();
            var cities = lines[3].Split(',').ToArray();
            var count = int.Parse(Console.ReadLine());
            Random rand = new Random();
            for (int i = 0; i < count; i++)
            {
                string phrase = phrases[rand.Next(0, phrases.Length)];
                string even = events[rand.Next(0, events.Length)];
                string author = authors[rand.Next(0, authors.Length)];
                string city = cities[rand.Next(0, cities.Length)];

                var output = $"{phrase} {even} {author} – {city}." + Environment.NewLine;

                File.AppendAllText(outputFileName, output);                
            }

        }
    }
}
