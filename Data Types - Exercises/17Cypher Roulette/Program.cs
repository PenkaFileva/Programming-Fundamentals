using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17Cypher_Roulette
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool isReversed = false;
            string message = String.Empty;
            string previousString = String.Empty;

            for (int i = 0; i < n; i++)
            {
                string currentString = Console.ReadLine();
                if (currentString == previousString)
                {
                    message = String.Empty;
                    if (currentString == "spin")
                    {
                        n++;
                    }
                    continue;
                }
                else
                {
                    if (currentString == "spin")
                    {
                        isReversed = !isReversed;
                        n++;
                    }
                    else
                    { 
                        if (isReversed)
                        {
                            message = currentString + message;
                        }
                        else
                        {
                            message += currentString;
                        }
                    }
                }
                previousString = currentString;
            }
            Console.WriteLine(message);
        }
    }
}
