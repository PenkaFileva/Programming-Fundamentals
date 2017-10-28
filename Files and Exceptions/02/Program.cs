using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            File.WriteAllText("hello.txt", "Zdrasti kak si?");
        }
    }
}
