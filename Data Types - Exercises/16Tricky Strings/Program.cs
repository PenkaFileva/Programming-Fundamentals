using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16Tricky_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string delimiter = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            string message = String.Empty;
            for (int i = 1; i <= n; i++)
            {
                string inputString = Console.ReadLine();
                if ( i == n)
                {
                    message += inputString;
                }
                else
                {
                    if (inputString == " ")
                    {
                        message += delimiter;
                    }
                    else
                    {
                        message += (inputString + delimiter);
                    }
                }
            }
            Console.WriteLine(message);
        }
    }
}
