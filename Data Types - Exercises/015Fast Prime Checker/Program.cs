using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _015Fast_Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            for (int currentNum = 2; currentNum <= num; currentNum++)
            {
                bool result = true;
                for (int delio = 2; delio <= Math.Sqrt(currentNum); delio++)
                {
                    if (currentNum % delio == 0)
                    {
                        result = false;
                        break;
                    }
                }
                Console.WriteLine($"{currentNum} -> {result}");
            }

        }
    }
}
