﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08SMS_Typing
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string massage = String.Empty;
            for (int i = 0; i < n; i++)
            {
                string digits = Console.ReadLine();
                int mainDigit = int.Parse(digits[0].ToString());
                int offset = (mainDigit - 2) * 3;
                if (mainDigit == 8 || mainDigit == 9)
                {
                    offset += 1;
                }
                int letterIndex = offset + digits.Length - 1;
                if (mainDigit == 0)
                {
                    massage += " ";
                }
                else
                {
                    massage += (char)(97 + letterIndex);
                }
            }
            Console.WriteLine(massage);
        }
    }
}
