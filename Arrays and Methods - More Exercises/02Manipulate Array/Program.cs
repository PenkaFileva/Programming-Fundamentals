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
            string[] word = Console.ReadLine().Split();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split();
                string command = tokens[0];
                switch (command)
                {
                    case "Distinct": word = word.Distinct().ToArray();break;
                    case "Reverse": Array.Reverse(word);break;
                    case "Replace":
                        int index = int.Parse(tokens[1]);
                        string letter = tokens[2];
                        word[index] = letter;break;
                    default:                            
                        break;
                }               
            }
            Console.WriteLine(String.Join(", ", word));
        }
    }
}
