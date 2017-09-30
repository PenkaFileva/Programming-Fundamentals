using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04Draw_a_Filled_Square
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            PrintHeader(n);
            PrintBody(n);
            PrintFooter(n);
        }

        static void PrintFooter(int n)
        {
            Console.WriteLine(new string('-', n * 2));
        }

        static void PrintBody(int n)
        {
            for (int i = 0; i < n-2; i++)
            {
                Console.Write('-');
                for (int j = 0; j < n-1; j++)
                {
                    Console.Write('\\');
                    Console.Write('/');
                }
                Console.WriteLine('-');
            }
        }

        static void PrintHeader(int n)
        {
            Console.WriteLine(new string ('-', n*2));
        }
    }
}
