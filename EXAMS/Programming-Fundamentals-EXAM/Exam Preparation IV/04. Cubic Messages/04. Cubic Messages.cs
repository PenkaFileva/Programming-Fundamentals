using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.Cubic_Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            var pattern = @"^(?<leftPart>\d+)(?<message>[a-zA-Z]+)(?<rightPart>[^a-zA-Z]*)$";
            var messageRegex = new Regex(pattern);

            while (true)
            {
                var input = Console.ReadLine();
                if (input == "Over!") break;
                var messageMatch = messageRegex.Match(input);

                if(!messageMatch.Success)
                    continue;

                var leftPart = messageMatch.Groups["leftPart"].Value;
                var rightPart = messageMatch.Groups["rightPart"].Value;
                var message = messageMatch.Groups["message"].Value;

                var messageLength = int.Parse(Console.ReadLine());

                if(message.Length != messageLength)
                    continue;

                var verificationCode = new string((leftPart + rightPart)
                    .Where(char.IsDigit)
                    .Select(a => int.Parse(a.ToString()))
                    .Select(index => index >= 0 && index < message.Length ? message[index] : ' ')
                    .ToArray());

                Console.WriteLine($"{message} == {verificationCode}");

            }
        }
    }
}
