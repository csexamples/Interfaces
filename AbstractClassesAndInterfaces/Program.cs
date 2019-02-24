using System;
using AbstractClassesAndnterfaces;

namespace AbstractClassesAndInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            var square = new Square(5);

            DisplayPolygon(square);

            var triangle = new Triangle(5);

            DisplayPolygon(triangle);
        }

        public static void DisplayPolygon(AbstractRegularPolygon polygon)
        {
            Console.WriteLine($"Number of sides: {polygon.NumberOfSides}");
            Console.WriteLine($"Side length: {polygon.SideLength}");
            Console.WriteLine($"Area: {polygon.GetArea()}");
        }

        public static void DisplayPolygon(IRegularPolygon polygon)
        {
            Console.WriteLine($"Number of sides: {polygon.NumberOfSides}");
            Console.WriteLine($"Side length: {polygon.SideLength}");
            Console.WriteLine($"Area: {polygon.GetArea():F2}");
        }
    }
}
