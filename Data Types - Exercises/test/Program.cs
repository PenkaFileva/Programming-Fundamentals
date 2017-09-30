using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {

                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                int c = int.Parse(Console.ReadLine());

                int valid = 0;

                if ((a + b) > c)
                {
                    if ((b + c) > a)
                    {
                        if ((a + c) > b) //If a+b>c and a+c>b and b+c>a then it is valid  
                        {
                            valid = 1;
                        }
                    }
                }
                if (valid == 1)
                {
                    Console.WriteLine("Triangle is valid.");
                }
                else
                {
                    Console.WriteLine("Invalid Triangle.");
                    return;
                }

                if (a * a + b * b == c * c)
                {
                    Console.WriteLine("Triangle has a right angle between sides a and b");
                }
                else if (b * b + c * c == a * a)
                {
                    Console.WriteLine("Triangle has a right angle between sides b and c");
                }
                else if (c * c + a * a == b * b)
                {
                    Console.WriteLine("Triangle has a right angle between sides a and c");
                }
                else
                {
                    Console.WriteLine("Triangle has no right angles");
                }
            }
        }
    }


    

