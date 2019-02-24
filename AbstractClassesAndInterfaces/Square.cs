using System;

namespace AbstractClassesAndnterfaces
{
    public class Square : AbstractRegularPolygon
    {
        public Square(int sideLength) : base(4, sideLength)
        {

        }

        public override double GetArea()
        {
            return SideLength * SideLength;
        }
    }
}
