using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Phonebook_Upgrade
{
    class Program
    {
        static void Main(string[] args)
        {
            var phonebook = new SortedDictionary<string, string>();

            var line = Console.ReadLine();
            while (line != "END")
            {
                if (line == "ListAll")
                {
                    foreach (var namephone in phonebook)
                    {
                        var name = namephone.Key;
                        var phone = namephone.Value;
                        Console.WriteLine("{0} -> {1}", name, phone);
                    }
                }
                else
                {
                    var tokens = line.Split();
                    var command = tokens[0];
                    var name = tokens[1];
                    if (command == "A")
                    {
                        var phone = tokens[2];
                        phonebook[name] = phone;
                    }
                    if (command == "S")
                    {
                        if (phonebook.ContainsKey(name))
                        {
                            Console.WriteLine("{0} -> {1}", name, phonebook[name]);
                        }
                        else
                        {
                            Console.WriteLine($"Contact {name} does not exist.");
                        }
                    }                  
                }
                line = Console.ReadLine();
            }
        }
    }
}
