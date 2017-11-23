using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.Hornet_Comm
{
    class Program
    {
        static void Main(string[] args)
        {

            var broadcasts = new List<string>();
            var messages = new List<string>();
            var messagePattern = @"^(\d+) \<\-\> ([a-zA-Z0-9]+)$"; //@"^([0-9]+)\s*<->\s*([a-zA-Z0-9]*)$";
            var broadcastPattern = @"^(\D+) \<\-\> ([a-zA-Z0-9]+)$"; //@"^([\D+])\s*<->\s*([a-zA-Z0-9]*)$";
            var messageRegex = new Regex(messagePattern);
            var broadcastRegex = new Regex(broadcastPattern);
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "Hornet is Green") break;
                if (messageRegex.IsMatch(input))
                {
                    var message = messageRegex.Match(input);
                    var message1Part = new string(message.Groups[1].Value.Reverse().ToArray());
                    var message2Part = message.Groups[2].Value;
                    messages.Add(message1Part + " -> " + message2Part);
                }
                if (broadcastRegex.IsMatch(input))
                {
                    var broadcast = broadcastRegex.Match(input);
                    var broadcast1Part = broadcast.Groups[1].Value;
                    var broadcast2Part = new string(broadcast.Groups[2].Value.ToCharArray());

                    StringBuilder sb = new StringBuilder();
                    foreach (var br in broadcast2Part)
                    {
                        if (char.IsUpper(br))
                        {
                            sb.Append(Char.ToLower(br));
                            continue;
                        }
                        if (char.IsLower(br))
                        {
                            sb.Append(Char.ToUpper(br));
                            continue;
                        }
                        else
                        {
                            sb.Append(br);
                            continue;
                        }
                    }
                    broadcasts.Add(sb + " -> " + broadcast1Part);
                }
            }
            Console.WriteLine("Broadcasts:");
            if (broadcasts.Count > 0)
            {
                Console.WriteLine(string.Join("\r\n", broadcasts));
            }
            else
            {
                Console.WriteLine("None");
            }

            Console.WriteLine("Messages:");
            if (messages.Count > 0)
            {
                Console.WriteLine(string.Join("\r\n", messages));
            }
            else
            {
                Console.WriteLine("None");
            }
            // foreach (char currentChar in encryptedFrequency)
            // {
            //     //IF ITS AN UPPERCASE LETTER, MAKE IT A LOWERCASE
            //     //IF ITS A LOWERCASE LETTER, MAKE IT AN UPPERCASE
            //     //ELSE, JUST APPEND IT
            //     if (currentChar >= 65 && currentChar <= 90)
            //     {
            //         decryptedFrequency += (char)(currentChar + 32);
            //     }
            //     else if (currentChar >= 97 && currentChar <= 122)
            //     {
            //         decryptedFrequency += (char)(currentChar - 32);
            //     }
            //     else
            //     {
            //         decryptedFrequency += currentChar;
            //     }
            // }
        }
    }
}
