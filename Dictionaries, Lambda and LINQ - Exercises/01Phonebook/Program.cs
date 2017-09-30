using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            var phonebook = new Dictionary<string, string>();

            var line = Console.ReadLine();
            while (line != "END")
            {
                var tokens = line.Split(' ');
                var command = tokens[0];
                if (command == "A")
                {
                    var name = tokens[1];
                    var phone = tokens[2];
                    phonebook[name] = phone;
                }
                if (command == "S")
                {
                    var name = tokens[1];
                    if (phonebook.ContainsKey(name))
                    {
                        Console.WriteLine("{0} -> {1}", name, phonebook[name]);
                    }                 
                    else
                    {
                        Console.WriteLine($"Contact {name} does not exist.");
                    }
                }
                line = Console.ReadLine();
            }
        }
    }
}
