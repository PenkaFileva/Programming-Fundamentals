using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _060Catch_the_Thief
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            long maxValue = 0;
            switch (type)
            {
                case "sbyte":maxValue = sbyte.MaxValue;break;
                case "int": maxValue = int.MaxValue; break;
                case "long": maxValue = long.MaxValue; break;                
            }
            int n = int.Parse(Console.ReadLine());
            long thiefsID = long.MinValue;
            for (int i = 0; i < n; i++)
            {
                long tempID = long.Parse(Console.ReadLine());
                if (tempID >= thiefsID && tempID <= maxValue)
                {
                    thiefsID = tempID;
                }
            }
            Console.WriteLine(thiefsID);
        }
    }
}
