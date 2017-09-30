using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07Sentence_the_Thief
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            long maxValue = 0;
            switch (type)
            {
                case "sbyte": maxValue = sbyte.MaxValue; break;
                case "int": maxValue = int.MaxValue; break;
                case "long": maxValue = long.MaxValue; break;
            }
            int n = int.Parse(Console.ReadLine());
            double thiefsID = long.MinValue;
            for (int i = 0; i < n; i++)
            {
                double tempID = double.Parse(Console.ReadLine());
                if (tempID >= thiefsID && tempID <= maxValue)
                {
                    thiefsID = tempID;
                }
            }
            double years = 0.0;
            if (thiefsID < 0)
            {
                years = Math.Ceiling(thiefsID / sbyte.MinValue);
            }
            else
            {
                years = Math.Ceiling(thiefsID / sbyte.MaxValue);
            }
            Console.WriteLine("Prisoner with id {0} is sentenced to {1} {2}",
                thiefsID,
                years,
                years > 1 ? "years" : "year");
        }
    }
}
