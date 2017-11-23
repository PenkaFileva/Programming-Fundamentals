using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Hornet_Assault
{
    class Program
    {
        static void Main(string[] args)
        {
            var beehivesBees = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse).ToList();
            var hornetsPower = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse).ToList();
            for (int i = 0; i < beehivesBees.Count; i++)
            {
                if (beehivesBees.Count == 0 || hornetsPower.Count == 0)
                {
                    break;
                }
                var beehive = beehivesBees[i];
                var attackHornets = hornetsPower.Sum();
                if (beehive < attackHornets)
                {
                    beehivesBees.RemoveAt(i);
                    i--;
                    continue;
                }
                else if (beehive > attackHornets)
                {
                    beehivesBees[i] = beehive - attackHornets;
                    hornetsPower.RemoveAt(0);
                    continue;
                }
                else if (beehive == attackHornets)
                {
                    beehivesBees.RemoveAt(i);
                    hornetsPower.RemoveAt(0);
                    i--;
                    continue;
                }
            }
            if (beehivesBees.Count == 0)
            {
                Console.WriteLine(string.Join(" ", hornetsPower));   
            }
            else
            {
                Console.WriteLine(string.Join(" ", beehivesBees));
            }
        }
    }
}
