using System;
using System.Collections.Generic;
using System.Text;

namespace PolyLib
{
    public class Square : Concrete
    {
        public Square(int length) :
            base(4, length)
        { }
        public override double GetArea()
        {
            return SideLength * SideLength;
        }
    }
}
