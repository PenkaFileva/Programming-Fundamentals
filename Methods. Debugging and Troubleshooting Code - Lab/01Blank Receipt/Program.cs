using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Blank_Receipt
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintHeader();
            PrintBody();
            PrintFooter();
        }

        private static void PrintFooter()
        {
            Console.WriteLine(new string('-', 30));
            Console.WriteLine("\u00A9 SoftUni");
        }

        private static void PrintBody()
        {
            Console.Write("Charged to");
            Console.WriteLine(new string ('_', 30-10));
            Console.Write("Received by");
            Console.WriteLine(new string('_', 30-11));
        }

        private static void PrintHeader()
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine(new string('-', 30));          
        }
    }
}
