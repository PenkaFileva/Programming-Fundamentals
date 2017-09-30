using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06Heists
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] price = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int priceJewels = price[0];
            int priceGold = price[1];
            long sumLootOfJewels = 0;
            long sumLootOfGold = 0;
            long totalSum = 0;
            long totalExpenses = 0;

            while (true)
            {
                string loot = Console.ReadLine();
                if (loot == "Jail Time")
                {
                    break;
                }
                else
                {
                    var currentLoot = loot.Split().ToArray();
                    long expenses = long.Parse(currentLoot[currentLoot.Length - 1]);
                    int countJewels = currentLoot[0].Where(ch => ch == '%').Count();
                    int countGold = currentLoot[0].Where(ch => ch == '$').Count();

                    sumLootOfJewels = countJewels * priceJewels;
                    sumLootOfGold = countGold * priceGold;
                    totalSum = totalSum + sumLootOfJewels + sumLootOfGold;
                    totalExpenses += expenses;
                }
                
            }
            if (totalSum >= totalExpenses)
            {
                Console.WriteLine("Heists will continue. Total earnings: {0}.", totalSum-totalExpenses);
            }
            else
            {
                Console.WriteLine("Have to find another job. Lost: {0}.", totalExpenses-totalSum);
            }
        }
    }
}
