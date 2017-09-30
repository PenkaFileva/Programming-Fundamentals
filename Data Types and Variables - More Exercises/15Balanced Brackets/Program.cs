using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15Balanced_Brackets
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
                        lastBracket = ")";
                    }
                    else
                    {
                        Console.WriteLine("UNBALANCED");
                        break;
                    }
                }
                if (currentBracket == "(")
                {
                    if (lastBracket == ")")
                    {
                        lastBracket = "(";
                    }
                    else
                    {
                        Console.WriteLine("UNBALANCED");
                        break;
                    }


                    {
                            }
                            if (lastBracket == "(")
                            {
                                Console.WriteLine("UNBALANCED");
                            }
                            else
                            {
                                Console.WriteLine("BALANCED");
                            }




                            //  int count1 = 0;
                            //  int count2 = 0;
                            //  for (int i = 1; i <= n; i++)
                            //  {
                            //      string randomString = Console.ReadLine().Trim();
                            //      if (randomString == "(" )
                            //      { 
                            //          count1 += 1;
                            //      }
                            //      if (randomString == ")")
                            //      {
                            //          count2 += 1;
                            //      }
                            //  }
                            //  if (count1 % 2 == 0 && count2 % 2 == 0)
                            //  {
                            //      Console.WriteLine("BALANCED");
                            //  }
                            //  else
                            //  {
                            //      Console.WriteLine("UNBALANCED");
                            //  }
                        }
    }
}
