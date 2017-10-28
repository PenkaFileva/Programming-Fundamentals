using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Circles_Intersection
{
    class Circle
    {
        public double Radius { get; set; }
        public Point Center { get; set; }
    }

    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Circle c1 = GetCircle();
            Circle c2 = GetCircle();
            var distance = GetDistance(c1.Center, c2.Center);
            if (distance <= c1.Radius + c2.Radius)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }

        private static double GetDistance(Point c1Center, Point c2Center)
        {
            double distance = Math.Sqrt(Math.Pow(c2Center.X - c1Center.X, 2) + Math.Pow(c2Center.Y - c1Center.Y, 2));
            return distance;
        }

        private static Circle GetCircle()
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Point center = new Point()
            {
                X = input[0],
                Y = input[1]
            };
            Circle circle = new Circle()
            {
                Radius = input[2],
                Center = center
            };
            return circle;
        }
    }
}
