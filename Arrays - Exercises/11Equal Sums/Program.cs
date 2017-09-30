using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11Equal_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            bool isIndexFound = false;
            for (int currentNum = 0; currentNum < arr.Length; currentNum++)
            {
                int leftSum = 0;
                int rightSUm = 0;
                for (int i = 0; i < currentNum; i++)
                {
                    leftSum += arr[i];
                }
                for (int i = currentNum + 1; i < arr.Length; i++)
                {
                    rightSUm += arr[i];
                }
                if (leftSum == rightSUm)
                {
                    Console.WriteLine(currentNum);
                    isIndexFound = true;
                    break;
                }

            }
            if (!isIndexFound)
            {
                Console.WriteLine("no");
            }
        }
    }
}
