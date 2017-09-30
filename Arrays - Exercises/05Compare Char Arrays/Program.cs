using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05Compare_Char_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] arr1 = Console.ReadLine().Split().Select(char.Parse).ToArray();
            char[] arr2 = Console.ReadLine().Split().Select(char.Parse).ToArray();

            int smallerArrayLength = Math.Min(arr1.Length, arr2.Length);
            bool areEgual = false;
            
            for (int i = 0; i < smallerArrayLength; i++)
            {
                if (arr1[i] == arr2[i])
                {
                    continue;
                }
                else
                {
                    if (arr1[i] < arr2[i])
                    {
                        Console.WriteLine(arr1);
                        Console.WriteLine(arr2);
                    }
                    else
                    {
                        Console.WriteLine(arr2);
                        Console.WriteLine(arr1);
                    }
                    areEgual = true;
                    break;
                }
            }
            if (!areEgual) //bool e ostanal na False
            {
                if (arr1.Length < arr2.Length)
                {
                    Console.WriteLine(arr1);
                    Console.WriteLine(arr2);
                }
                else
                {
                    Console.WriteLine(arr2);
                    Console.WriteLine(arr1);
                }
            }
        }
    }
}
