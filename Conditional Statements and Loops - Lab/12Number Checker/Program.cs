using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace _12Number_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
                try
                {
                    num = int.Parse(Console.ReadLine());
                    Console.WriteLine("It is a number.");                  
                }
                catch
                {
                    Console.WriteLine("Invalid input!");

                }          
        }
    }
}
