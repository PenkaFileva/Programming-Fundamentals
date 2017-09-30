using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15Neighbour_Wars
{
    class Program
    {
        static void Main(string[] args)
        {
            var peshoDamage = int.Parse(Console.ReadLine()); //30
            var goshoDamage = int.Parse(Console.ReadLine()); //40
            var peshoHealth = 100;
            var goshoHealth = 100;
            var round = 0;
            while (peshoHealth > 0 && goshoHealth > 0)
            {
                round += 1;
                if (round % 2 == 0)
                {
                    peshoHealth -= goshoDamage;
                    if (peshoHealth <= 0)
                    {
                        break;
                    }
                    Console.WriteLine("Gosho used Thunderous fist and reduced Pesho to {0} health.", peshoHealth);                 
                }
                else
                {
                    goshoHealth -= peshoDamage;
                    if (goshoHealth <= 0)
                    {
                        break;
                    }
                    Console.WriteLine("Pesho used Roundhouse kick and reduced Gosho to {0} health.", goshoHealth);                                       
                }
                if (round % 3 == 0)
                {
                    peshoHealth += 10;
                    goshoHealth += 10;
                }
            }
            if (peshoHealth > 0)
            {
                Console.WriteLine("Pesho won in {0}th round.", round);
            }
            else if (goshoHealth > 0)
            {
                Console.WriteLine("Gosho won in {0}th round.", round);
            }
        }
    }
}
