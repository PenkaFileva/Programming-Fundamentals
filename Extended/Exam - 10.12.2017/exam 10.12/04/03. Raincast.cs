using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Raincast
{
    class Program
    {
        static void Main(string[] args)
        {
            var typePattern = @"^Type: ([A-Za-z]+)$";
            var sourcePattern = @"^Source: ([\w+]+)$";
            var forecastPattern = @"^Forecast: ([^!.,?\r\n]*)$";
            var typeRegex = new Regex(typePattern);
            var sourceRegex = new Regex(sourcePattern);
            var forecastRegex = new Regex(forecastPattern);
            var type = string.Empty;
            var source = string.Empty;
            var forecast = string.Empty;
            var input = Console.ReadLine();
            while (input != "Davai Emo")
            {
                
                if (type == "")
                {
                    if (Regex.IsMatch(input, typePattern))
                    {
                        var line = typeRegex.Match(input).Groups[1].Value;
                        if (line == "Normal" || line == "Warning"
                            || line == "Danger")
                        {
                            type = line;
                        }
                        input = Console.ReadLine();
                        continue;
                    }
                    input = Console.ReadLine();
                    continue; ;
                }
                if (type != "" && source == "") 
                {
                    if (Regex.IsMatch(input, sourcePattern))
                    {
                        source = sourceRegex.Match(input).Groups[1].Value;
                        input = Console.ReadLine();
                        continue;
                    }
                    input = Console.ReadLine();
                    continue;
                }
                else if (type != "" && source != "")
                {
                    if (Regex.IsMatch(input, forecastPattern))
                    {
                        forecast = forecastRegex.Match(input).Groups[1].Value;
                        Console.WriteLine($"({type}) {forecast} ~ {source}");
                        type = string.Empty;
                        source = string.Empty;
                        forecast = string.Empty;
                        input = Console.ReadLine();
                        continue;
                    }
                    input = Console.ReadLine();
                    continue;
                }

                input = Console.ReadLine();
            }
        }
    }
}
