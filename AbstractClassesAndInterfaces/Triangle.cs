using System;

namespace AbstractClassesAndnterfaces
{
    public class Triangle : IRegularPolygon
    {
        public Triangle(int sideLength)
        {
            SideLength = sideLength;
        }

        public int NumberOfSides { get; set; } = 3;

        public int SideLength { get; set; }

        public double GetPerimeter()
        {
            return NumberOfSides * SideLength;
        }

        public double GetArea()
        {
            return SideLength * SideLength * Math.Sqrt(3) / 4;
        }
    }
}
