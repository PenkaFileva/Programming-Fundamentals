using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03Exchange_Variable_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int temp = a;
            var a1 = b;
            var b1 = temp;
            //Console.WriteLine(a);
            //Console.WriteLine(b);

            Console.WriteLine("Before:");
            Console.WriteLine($"a = {a}");
            Console.WriteLine($"b = {b}");
            Console.WriteLine("After:");
            Console.WriteLine($"a = {a1}");
            Console.WriteLine($"b = {b1}");
        }
    }
}
