﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12Variable_in_Hexadecimal_Format
{
    class Program
    {
        static void Main(string[] args)
        {
            string format = Console.ReadLine();
            Console.WriteLine(Convert.ToInt32(format, 16));
        }
    }
}
