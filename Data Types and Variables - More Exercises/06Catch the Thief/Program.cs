using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06Catch_the_Thief
{
    class Program
    {
        static void Main(string[] args)
        {
            string numeralTypeOfThiefID = Console.ReadLine();
            long countOfID = long.Parse(Console.ReadLine());
            if (numeralTypeOfThiefID == "sbyte")
            {
                long max = sbyte.MaxValue;
                long tempID = sbyte.MinValue;
                for (int i = 0; i < countOfID; i++)
                {
                    var id = long.Parse(Console.ReadLine());
                    if (id <= max && id >= tempID)
                    {
                        tempID = id;
                    }
                }
                Console.WriteLine(tempID);
            }
            else if (numeralTypeOfThiefID == "int")
            {
                long max = int.MaxValue;
                long tempID = int.MinValue;
                for (int i = 0; i < countOfID; i++)
                {
                    var id = long.Parse(Console.ReadLine());
                    if (id <= max && id >= tempID)
                    {
                        tempID = id;
                    }
                }
                Console.WriteLine(tempID);
            }
            else if (numeralTypeOfThiefID == "long")
            {
                long max = long.MaxValue;
                long tempID = long.MinValue;
                for (int i = 0; i < countOfID; i++)
                {
                    var id = long.Parse(Console.ReadLine());
                    if (id <= max && id >= tempID)
                    {
                        tempID = id;
                    }
                }
                Console.WriteLine(tempID);
            }
        }
    }
}
