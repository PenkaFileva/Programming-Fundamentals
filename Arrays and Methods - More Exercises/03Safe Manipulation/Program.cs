using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Manipulate_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] word = Console.ReadLine().Split(' ');


            while (true)
            {
                string[] tokens = Console.ReadLine().Split(' ');
                string command = tokens[0];
                if (command == "END")
                {
                    break;
                }
                switch (command)
                {
                    case "Distinct": word = word.Distinct().ToArray(); break;
                    case "Reverse": Array.Reverse(word); break;
                    case "Replace":
                        int index = int.Parse(tokens[1]);
                        string letter = tokens[2];
                        if (index < 0 || index >= word.Length)
                        {
                            Console.WriteLine("Invalid input!");
                        }
                        else
                        {
                            word[index] = letter;
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid input!");
                        break;
                }
            }
            Console.WriteLine(String.Join(", ", word));
        }
    }
}
