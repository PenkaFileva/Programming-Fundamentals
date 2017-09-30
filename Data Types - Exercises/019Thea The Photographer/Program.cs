using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _019Thea_The_Photographer
{
    class Program
    {
        static void Main(string[] args)
        {
            var pictureCount = long.Parse(Console.ReadLine());
            var singlePictureFilterTimeSeconds = long.Parse(Console.ReadLine());
            var filterPercentage = long.Parse(Console.ReadLine());
            var singlePictureUploadTimeSeconds = long.Parse(Console.ReadLine());

            var filterTimeSeconds = (long)(pictureCount * singlePictureFilterTimeSeconds);
            var pictureToUploadCount = (long)Math.Ceiling((pictureCount * filterPercentage) / 100d);
            var uploadTimeSeconds = pictureToUploadCount * singlePictureUploadTimeSeconds;
            var totalTimeNeededSeconds = filterTimeSeconds + uploadTimeSeconds;
            var totalTimeNeededTimeSpan = TimeSpan.FromSeconds(totalTimeNeededSeconds);
            Console.WriteLine(totalTimeNeededTimeSpan.ToString(@"d\:hh\:mm\:ss"));
        }
    }
}
