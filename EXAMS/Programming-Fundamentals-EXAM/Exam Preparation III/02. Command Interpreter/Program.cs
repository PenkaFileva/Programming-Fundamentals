﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _02.Command_Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<string> items = Console.ReadLine().Split(' ')
                .Where(i => i.Length > 0).ToList();
            while (true)
            {
                var commandLine = Console.ReadLine();

                if (commandLine == "end") break;
                var cmdTokens = commandLine.Split(' ');
                var cmdName = cmdTokens[0];
                //var cmdParams = cmdTokens.Skip(1).ToArray();
                switch (cmdName)
                {
                    case "reverse":
                        ReverseList(items, cmdTokens);
                        break;
                    case "sort":
                        SortList(items, cmdTokens);
                        break;
                    case "rollLeft":
                        RollLeftList(items, cmdTokens);
                        break;
                    case "rollRight":
                        RollRightList(items, cmdTokens);
                        break;
                    
                }
            }
            Console.WriteLine("[{0}]", string.Join(", ", items));
        }

        static void RollRightList(List<string> items, string[] cmdTokens)
        {
            var count = int.Parse(cmdTokens[1]);
            if (count >= 0)
                RollListList(items, count);
            else
                Console.WriteLine("Invalid input parameters.");
        }

        static void RollLeftList(List<string> items, string[] cmdTokens)
        {
            
            var count = int.Parse(cmdTokens[1]);
            if (count >= 0)
                RollListList(items, -count);

            else
                Console.WriteLine("Invalid input parameters.");
        }

        static void RollListList(List<string> items, int count)
        {
            count = count % items.Count;
            var result = new string[items.Count];

            for (int i = 0; i < items.Count; i++)
            {
                var newPos = (i + count) % items.Count;
                if (newPos < 0)
                    newPos += items.Count;
                result[newPos] = items[i];
            }
            var index = 0;
            foreach (var item in result.ToList())
            {
                items[index] = item;
                index++;
            }
        }

        static void SortList(List<string> items, string[] cmdTokens)
        {
            var startIndex = int.Parse(cmdTokens[2]);
            var count = int.Parse(cmdTokens[4]);
            if (IsValidRange(items, startIndex, count))
            {
                SortList(items, startIndex, count);
            }
            else
            {
                Console.WriteLine("Invalid input parameters.");
            }
        }
        static void SortList(List<string> items, int startIndex, int count)
        {
            var leftList = items.Take(startIndex);
            var middleList = items.Skip(startIndex).Take(count).OrderBy(x => x);
            var rightList = items.Skip(startIndex + count);
            var allItems = leftList.Concat(middleList).Concat(rightList);

            var index = 0;
            foreach (var item in allItems.ToList())
            {
                items[index] = item;
                index++;
            }
        }

        static void ReverseList(List<string> items, string[] cmdTokens)
        {
            var startIndex = int.Parse(cmdTokens[2]);
            var count = int.Parse(cmdTokens[4]);
            if (IsValidRange(items, startIndex, count))
                ReverseList(items, startIndex, count);   

            else
                Console.WriteLine("Invalid input parameters.");
        }

        static void ReverseList(List<string> items, int startIndex, int count)
        {
            var endIndex = startIndex + count - 1;
            while (startIndex < endIndex)
            {
                var oldValue = items[startIndex];
                items[startIndex] = items[endIndex];
                items[endIndex] = oldValue;
                endIndex--;
                startIndex++;
            }  
        }

        private static bool IsValidRange(List<string> items, int startIndex, int count)
        {
            if (startIndex < 0)
                return false;
            if (startIndex >= items.Count)
                return false;
            if (count < 0)
                return false;
            if (startIndex + count - 1 >= items.Count)
                return false;
            return true;
        }

    }
    
}
