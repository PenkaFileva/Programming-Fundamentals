﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008Employee_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            byte age = byte.Parse(Console.ReadLine());
            char gender = char.Parse(Console.ReadLine());
            long idNumber = long.Parse(Console.ReadLine());
            int employeeNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("First name: {0}", firstName);
            Console.WriteLine("Last name: {0}", lastName);
            Console.WriteLine("Age: {0}", age);
            Console.WriteLine("Gender: {0}", gender);
            Console.WriteLine("Personal ID: {0}", idNumber);
            Console.WriteLine("Unique Employee number: {0}", employeeNumber);
        }
    }
}
