using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Icarus
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var startingPosition = int.Parse(Console.ReadLine());
            int damages = 1;

            while (true)
            {
                var input = Console.ReadLine();
                if (input == "Supernova")
                {
                    break;
                }
                var commandLine = input.Split();
                var command = commandLine[0];
                var steps = int.Parse(commandLine[1]);
                if (command == "left")
                {
                    while (steps-- > 0)
                    {
                        if (startingPosition == 0)
                        {
                            startingPosition = numbers.Length - 1;                            
                            damages++;
                            numbers[startingPosition] -= damages;
                            continue;
                        }
                        startingPosition--;
                        numbers[startingPosition] -= damages;
                    }
                }
                if (command == "right")
                {
                    while (steps-- > 0)
                    {
                        if (startingPosition == numbers.Length-1)
                        {
                            startingPosition = 0;
                            damages++;
                            numbers[startingPosition] -= damages;
                            continue;
                        }
                        startingPosition++;
                        numbers[startingPosition] -= damages;
                    }
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
