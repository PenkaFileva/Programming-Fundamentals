using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Vapor_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string game = Console.ReadLine();
            var initialBudget = budget;
            var currentPrice = 0.0;
            while (game != "Game Time")
            {
                switch (game)
                {
                    case "OutFall 4": currentPrice = 39.99; break;
                    case "CS: OG": currentPrice = 15.99; break;
                    case "Zplinter Zell": currentPrice = 19.99; break;
                    case "Honored 2": currentPrice = 59.99; break;
                    case "RoverWatch": currentPrice = 29.99; break;
                    case "RoverWatch Origins Edition": currentPrice = 39.99; break;
                    default:
                        Console.WriteLine("Not Found");
                        game = Console.ReadLine();
                        continue;
                }
                if (currentPrice > budget)
                {
                    Console.WriteLine("Too Expensive");
                }
                else
                {
                    budget -= currentPrice;
                    Console.WriteLine($"Bought {game}");
                }
                if (budget <= 0)
                {
                    Console.WriteLine("Out of money!");
                    return;                                        
                }
                game = Console.ReadLine();
            }
            if (budget > 0)
            {
                Console.WriteLine("Total spent: ${0:f2}. Remaining: ${1:f2}", (initialBudget-budget), budget);
            }
        }
    }
}
