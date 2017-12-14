using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10Сръбско_Unleashed
{
    class Program
    {
        static void Main(string[] args)
        {
            var concertSingerTicketsSum = new Dictionary<string, Dictionary<string, int>>();
            var input = Console.ReadLine();
            while (input != "End")
            {
                var information = input.Split('@');
                var name = information[0];
                if (name.Substring(name.Length - 1) != " ")
                {
                    input = Console.ReadLine();
                    continue;
                }
                var consert = information[1].Split(' ');
                if (consert.Length < 3)
                {
                    input = Console.ReadLine();
                    continue;
                }
                var ticketCount = 0;
                var ticketPrice = 0;
                try
                {
                    ticketCount = int.Parse(consert[consert.Length - 1]);
                    ticketPrice = int.Parse(consert[consert.Length - 2]);
                }
                catch (Exception)
                {
                    input = Console.ReadLine();
                    continue;                    
                }
                var nameConcert = String.Empty;
                for (int i = 0; i < consert.Length - 2; i++)
                {
                    nameConcert += consert[i] + " ";
                }
                nameConcert = nameConcert.Trim();
                if (!concertSingerTicketsSum.ContainsKey(nameConcert))
                {
                    concertSingerTicketsSum[nameConcert] = new Dictionary<string, int>();
                }
                if (!concertSingerTicketsSum[nameConcert].ContainsKey(name))
                {
                    concertSingerTicketsSum[nameConcert][name] = 0;
                }
                int ticketSum = ticketCount * ticketPrice;
                concertSingerTicketsSum[nameConcert][name] += ticketSum;

                input = Console.ReadLine();
            }
            foreach (var venues in concertSingerTicketsSum)
            {
                Console.WriteLine($"{venues.Key}");
                foreach (var singer in venues.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {singer.Key}-> {singer.Value}");
                }
            }
        }
    }
}
