using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Type_Boundaries
{
    class Program
    {
        static void Main(string[] args)
        {
            
            try
            {
                long num = long.Parse(Console.ReadLine());
                Console.WriteLine("integer");
            }
            catch 
            {
                Console.WriteLine("floating-point");
                
            }
        }
    }
}
