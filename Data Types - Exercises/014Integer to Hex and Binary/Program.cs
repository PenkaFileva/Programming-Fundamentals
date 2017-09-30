using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _014Integer_to_Hex_and_Binary
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            var hexadecimal = Convert.ToString(num, 16).ToUpper();
            var binary = Convert.ToString(num, 2);
            Console.WriteLine(hexadecimal);
            Console.WriteLine(binary);

        }
    }
}
