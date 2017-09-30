using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04Transport
{
    class Program
    {
        static void Main(string[] args)
        {
            var persons = int.Parse(Console.ReadLine());
            var capacity = 4 + 8 + 12;
            var courses = (int)Math.Ceiling((double)persons / capacity);
            Console.WriteLine(courses);
        }
    }
}
