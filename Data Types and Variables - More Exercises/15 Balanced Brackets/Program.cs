using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Balanced_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string lastBracket = String.Empty;
            string balance = "BALANCED";

            for (int i = 1; i <= n; i++)
            {
                string currentBracket = Console.ReadLine().Trim();
                if (currentBracket == ")")
                {
                    if (lastBracket == "(")
                    {
                        balance = "BALANCED";
                    }
                    else if (lastBracket == ")")
                    {
                        balance = "UNBALANCED";
                        break;                        
                    }
                    else
                    {
                        balance = "UNBALANCED";
                        break;
                    }
                    lastBracket = ")";
                }
                if (currentBracket == "(")
                {
                    lastBracket = "(";
                    balance = "UNBALANCED";
                }
            }
            Console.WriteLine(balance);
        }
    }
}
