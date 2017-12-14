using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Spyfer
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(long.Parse).ToList();

            for (int i = 0; i < input.Count; i++)
            {
                if (input.Count == 1)
                {
                    break;                   
                }
                if (i == 0)
                {
                    if (input[i]  == input[i+1])
                    {
                        input.RemoveAt(i+1);
                        i--;
                        continue;
                    }
                    else
                    {
                        continue;
                    }                   
                }  
                else if (i == input.Count-1)
                {
                    if (input[i] == input[i-1])
                    {
                        input.RemoveAt(i-1);
                        i = -1;
                        continue;                       
                    }
                    else
                    {
                         continue;   
                    }
                }
                else 
                {
                    if (input[i] == input[i-1] + input[i+1])
                    {
                        input.RemoveAt(i-1);
                        input.RemoveAt(i);
                        i = -1;
                        continue;
                    }
                }
            }
            Console.WriteLine(String.Join(" ", input));
        }
    }
}
