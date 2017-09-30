using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11Geometry_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string figureType = Console.ReadLine().ToLower();
            var area = 0.0;
            if (figureType == "triangle")
            {
                double side = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                area = GetAreaTriangje(side, height);
            }
            else if (figureType == "square")
            {
                double side = double.Parse(Console.ReadLine());
                area = GetAreaSquare(side);
            }
            else if (figureType == "rectangle")
            {
                double width = double.Parse(Console.ReadLine());
                double lenght = double.Parse(Console.ReadLine());
                area = GetAreaRectangle(width, lenght);
            }
            else if (figureType == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                area = GetAreacircle(radius);
            }
            Console.WriteLine($"{area:f2}");
        }

        private static double GetAreaTriangje(double side, double height)
        {
            double area = (side * height)/2;
            return area;
        }

        private static double GetAreaSquare(double side)
        {
            double area = side * side;
            return area;
        }

        private static double GetAreaRectangle(double width, double lenght)
        {
            double area = width * lenght;
            return area;
        }

        private static double GetAreacircle(double radius)
        {
            double area = Math.PI * Math.Pow(radius, 2);
            return area;
        }
    }
}
