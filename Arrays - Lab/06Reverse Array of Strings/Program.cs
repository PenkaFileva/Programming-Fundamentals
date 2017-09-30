using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06Reverse_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string[] word = text.Split(' ').Reverse().ToArray();
            Console.WriteLine(String.Join(" ", word));

        }
    }
}
