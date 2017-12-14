using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.Sequence_of_Commands
{
    class Program
    {
        private const char ArgumentsDelimiter = ' ';

        public static void Main()
        {
            int sizeOfArray = int.Parse(Console.ReadLine());

            long[] array = Console.ReadLine()
                .Split(ArgumentsDelimiter)
                .Select(long.Parse)
                .ToArray();

            string[] line = Console.ReadLine().Split(ArgumentsDelimiter).ToArray();

            while (!line[0].Equals("stop"))
            {
                PerformAction(array, line);
                Console.WriteLine(string.Join(" ", array));
                line = Console.ReadLine().Split(ArgumentsDelimiter).ToArray();
            }
        }

        private static void PerformAction(long[] array, string[] line)
        {
            var command = line[0].ToLower();
           
            switch (command)
            {
                case "multiply":
                    array[long.Parse(line[1]) - 1] *= long.Parse(line[2]);
                    break;
                case "add":
                    array[long.Parse(line[1]) - 1] += long.Parse(line[2]);
                    break;
                case "subtract":
                    array[long.Parse(line[1]) - 1] -= long.Parse(line[2]);
                    break;
                case "lshift":
                    ArrayShiftLeft(array);
                    break;
                case "rshift":
                    ArrayShiftRight(array);
                    break;
            }
        }

        private static void ArrayShiftRight(long[] array)
        {
            long temp = array[array.Length - 1];
            for (int i = array.Length - 1; i >= 1; i--)
            {
                array[i] = array[i - 1];
            }
            array[0] = temp;
        }

        private static void ArrayShiftLeft(long[] array)
        {
            long temp = array[0];
            for (int i = 0; i < array.Length - 1; i++)
            {
                array[i] = array[i + 1];
            }
            array[array.Length - 1] = temp;
        }
    }
}
