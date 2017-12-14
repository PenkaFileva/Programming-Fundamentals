using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Rainer
{
    class Program
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var firstIndex = line[line.Count - 1];
            line.RemoveAt(line.Count - 1);
            var sequence = new List<int>();
            for (int i = 0; i < line.Count; i++)
            {
                sequence.Add(line[i] -1);
            }

            var donaldIndex = firstIndex;
            var steps = 0;
            var index = int.Parse(Console.ReadLine());
            while (true)
            {
               
                //index = int.Parse(Console.ReadLine());
                donaldIndex = index;
                for (int i = 0; i < sequence.Count; i++)
                {
                    sequence[i] -= 1;  
                }
                steps++;
                if (sequence[donaldIndex] == 0 )
                {
                    break;
                }
                else
                {
                    for (int i = 0; i < sequence.Count; i++)
                    {
                        if (sequence[i] == 0)
                        {
                             sequence[i] = line[i];
                        }
                    }

                    index = int.Parse(Console.ReadLine());
                }
                
            }
            Console.WriteLine(string.Join(" ", sequence));
            Console.WriteLine(steps);
        }
    }
}
