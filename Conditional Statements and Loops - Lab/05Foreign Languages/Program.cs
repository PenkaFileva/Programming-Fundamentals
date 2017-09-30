using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05Foreign_Languages
{
    class Program
    {
        static void Main(string[] args)
        {
            string country = Console.ReadLine().ToLower();
            switch (country)
            {
                case "england":
                case "usa": Console.WriteLine("English");break;
                case "argentina":
                case "mexico":
                case "spain": Console.WriteLine("Spanish");break;
                default:
                    Console.WriteLine("unknown");
                    break;
            }
        }
    }
}
