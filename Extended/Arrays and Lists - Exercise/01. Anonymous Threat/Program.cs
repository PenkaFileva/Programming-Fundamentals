using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Anonymous_Threat
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').ToList();
            // var line = Console.ReadLine();

            while (true)
            {
                var line = Console.ReadLine();
                if (line == "3:1")
                {
                    break;
                }
                var commandLine = line.Split(' ');
                var command = commandLine[0];
                if (command == "merge")
                {
                    var startIndex = int.Parse(commandLine[1]);
                    var endIndex = int.Parse(commandLine[2]);
                    //bool isStartIndexRange = startIndex >= 0 && startIndex < input.Count;
                    //bool isEndIndexRange = endIndex >= 0 && endIndex < input.Count;

                    if (startIndex < 0 || startIndex > input.Count - 1)
                    {
                        startIndex = 0;
                    }
                    if (endIndex > input.Count -1 || endIndex < 0)
                    {
                        endIndex = input.Count - 1;
                    }
                    var result = string.Empty;
                    for (int i = startIndex; i <= endIndex; i++)
                    {
                        result += input[i];
                    }
                    input.RemoveRange(startIndex, endIndex-startIndex+1);
                    input.Insert(startIndex, result);
                }
                if (command == "divide")
                {
                    var index = int.Parse(commandLine[1]);
                    var partitions = int.Parse(commandLine[2]);
                    if (index < 0 || index > input.Count - 1)
                    {
                        line = Console.ReadLine();
                        continue;
                    }

                    var part = input[index].Length / partitions;
                    var element = input[index];
                    var dividet = new string[partitions];

                    input.RemoveAt(index);
                    for (int i = 0; i < partitions - 1; i++)
                    {
                        dividet[i] = element.Substring(0, part);
                        element = element.Substring(part);
                    }
                    dividet[partitions - 1] = element;
                    input.InsertRange(index, dividet);
                }

            }
            Console.WriteLine(string.Join(" ", input));
        }
    }
}

