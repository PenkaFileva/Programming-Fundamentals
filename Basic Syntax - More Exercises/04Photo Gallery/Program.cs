using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04Photo_Gallery
{
    class Program
    {
        static void Main(string[] args)
        {
            int photoNum = int.Parse(Console.ReadLine());
            int day = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            var bytes = double.Parse(Console.ReadLine());
            int widht = int.Parse(Console.ReadLine());
            int heigth = int.Parse(Console.ReadLine());
            Console.WriteLine("Name: DSC_{0:D4}.jpg", photoNum);
            Console.WriteLine("Date Taken: {0:D2}/{1:D2}/{2} {3:D2}:{4:D2}", day, month, year, hours, minutes);
            var size = 0.0;
            if (bytes < 1000)
            {
                size = bytes;
                Console.WriteLine("Size: {0}B", size);
            }
            else if (bytes < 1000000)
            {
                size = bytes / 1000;
                Console.WriteLine("Size: {0}KB", size);
            }
            else if (bytes < 1000000000)
            {
                size = bytes / 1000000;
                Console.WriteLine("Size: {0}MB", size);
            }
            if (widht == heigth)
            {
                Console.WriteLine("Resolution: {0}x{1} (square)", widht, heigth);
            }
            else if (widht > heigth)
            {
                Console.WriteLine("Resolution: {0}x{1} (landscape)", widht, heigth);
            }
            else if (widht < heigth)
            {
                Console.WriteLine("Resolution: {0}x{1} (portrait)", widht, heigth);
            }
        }
    }
}
