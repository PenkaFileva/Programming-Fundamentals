using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10Data_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal num1 = decimal.Parse(Console.ReadLine());
            decimal num2 = decimal.Parse(Console.ReadLine());
            decimal minNum = Math.Min(num1, num2);
            decimal maxNum = Math.Max(num1, num2);
            decimal overflowValue = 0;
            string smallType = String.Empty;

            if (minNum <= byte.MaxValue)
            {
                overflowValue = byte.MaxValue;
                smallType = "byte";
            }
            else if (minNum <= ushort.MaxValue)
            {
                overflowValue = ushort.MaxValue;
                smallType = "ushort";
            }
            else if (minNum <= uint.MaxValue)
            {
                overflowValue = uint.MaxValue;
                smallType = "uint";
            }
            else if (minNum <= ulong.MaxValue)
            {
                overflowValue = ulong.MaxValue;
                smallType = "ulong";
            }

            string bigType = String.Empty;
            if (maxNum <= byte.MaxValue)
            {
                bigType = "byte";
            }
            else if (maxNum <= ushort.MaxValue)
            {
                bigType = "ushort";
            }
            else if (maxNum <= uint.MaxValue)
            {
                bigType = "uint";
            }
            else if (maxNum <= ulong.MaxValue)
            {
                bigType = "ulong";
            }
            decimal overflowCount =maxNum / overflowValue;
            Console.WriteLine("bigger type: {0}", bigType);
            Console.WriteLine("smaller type: {0}", smallType);
            Console.WriteLine("{0} can overflow {1} {2} times", maxNum, smallType, Math.Round(overflowCount));
        }
    }
}
