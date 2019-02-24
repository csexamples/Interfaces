using System;

namespace AbstractClassesAndnterfaces
{
    public abstract class AbstractRegularPolygon
    {
        protected AbstractRegularPolygon(int numberOfSides, int sideLength)
        {
            NumberOfSides = numberOfSides;
            SideLength = sideLength;
        }

        public int NumberOfSides { get; set; }

        public int SideLength { get; set; }

        public double GetPerimeter()
        {
            return NumberOfSides * SideLength;
        }

        public abstract double GetArea();
    }
}
