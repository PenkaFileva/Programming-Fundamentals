using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_5_Different_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            if ((b-a)<4)
            {
                Console.WriteLine("No");
            }
            else
            {
                for (int firstDigit = a; firstDigit <= b-4; firstDigit++)
                {
                    for (int secondDigit = firstDigit+1; secondDigit <= b-3; secondDigit++)
                    {
                        for (int thirdDigit = secondDigit+1; thirdDigit <= b-2; thirdDigit++)
                        {
                            for (int  fourthDigit = thirdDigit +1;  fourthDigit <= b-1; fourthDigit++)
                            {
                                for (int fifthDigit = fourthDigit +1; fifthDigit <= b; fifthDigit++)
                                {
                                    Console.WriteLine("{0} {1} {2} {3} {4}", firstDigit, secondDigit, thirdDigit, fourthDigit, fifthDigit);
                                }   
                            }
                        }
                    }
                }
            }
        }
    }
}
