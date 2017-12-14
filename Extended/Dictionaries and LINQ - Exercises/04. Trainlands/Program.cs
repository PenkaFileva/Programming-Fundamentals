using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Trainlands
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var trains = new Dictionary<string, Dictionary<string, long>>();
            
            while (input != "It's Training Men!")
            {
                var tokens = input.Split("=->: ".ToCharArray(), 
                    StringSplitOptions.RemoveEmptyEntries);
                if (tokens.Length > 2)
                {
                    var trainName = tokens[0];
                    var wagonName = tokens[1];
                    long wagonPower = long.Parse(tokens[2]);
                    if (!trains.ContainsKey(trainName))
                    {
                        trains[trainName] = new Dictionary<string, long>();
                    }
                    trains[trainName].Add(wagonName, wagonPower);
                }
                else
                {
                    var trainName = tokens[0];
                    var otherTrainName = tokens[1];
                    if (input.Contains('='))
                    {
                        //var trainName = tokens[0];
                        //var otherTrainName = tokens[1];
                        if (trains.ContainsKey(trainName))
                        {
                            trains.Remove(trainName);
                        }
                        if (!trains.ContainsKey(trainName))
                        {
                            trains[trainName] = new Dictionary<string, long>();
                        }
                        foreach (var wagon in trains[otherTrainName])
                        {
                            trains[trainName].Add(wagon.Key, wagon.Value);
                        }
                    }
                    else
                    {
                        //var trainName = tokens[0];
                        //var otherTrainName = tokens[1];

                        if (!trains.ContainsKey(trainName))
                        {
                            trains[trainName] = new Dictionary<string, long>();
                        }
                        foreach (var wagon in trains[otherTrainName])
                        {
                            trains[trainName].Add(wagon.Key, wagon.Value);
                        }
                        trains.Remove(otherTrainName);
                    }
                }

                input = Console.ReadLine();
            }
            var resultTrains = trains.OrderByDescending(a => a.Value.Sum(c => c.Value));
            foreach (var train in resultTrains)
            {
                Console.WriteLine($"Train: {train.Key}");
                foreach (var wagon in train.Value.OrderByDescending(m => m.Value))
                {
                    Console.WriteLine($"###{wagon.Key} - {wagon.Value}");
                }
            }
        }
    }
}
