using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14Boat_Simulator
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstBoat = char.Parse(Console.ReadLine());
            char secondBoat = char.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int tilesFirstBoat = 50;
            int tilesSecondBoat = 50;
            int speedFirstBoat = 0;
            int speedSecondBoat = 0;

            for (int i = 1; i <= n; i++)
            {
                string randomString = Console.ReadLine();
                if (randomString == "UPGRADE")
                {
                    firstBoat = (char)(firstBoat + 3);
                    secondBoat = (char)(secondBoat + 3);
                }
                else
                {
                    if (i % 2 == 0)
                    {
                        speedSecondBoat += randomString.Length;
                        if (speedSecondBoat >= tilesSecondBoat)
                        {
                            Console.WriteLine(secondBoat);
                            return;
                        }
                    }
                    else
                    {
                        speedFirstBoat += randomString.Length;
                        if (speedFirstBoat >= tilesFirstBoat)
                        {
                            Console.WriteLine(firstBoat);
                            return;
                        }
                    }
                }
            }            
            if (speedFirstBoat > speedSecondBoat)
            {
                Console.WriteLine(firstBoat);
            }
            else
            {
                Console.WriteLine(secondBoat);
            }
        }
    }
}
