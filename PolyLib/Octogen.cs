using System;
using System.Collections.Generic;
using System.Text;

namespace PolyLib
{
   public class Octogen : object,IRegular
   {
        public int NumberOfSides { get; set; }
        public int SideLength { get; set; }

        public Octogen(int length)
        {
            NumberOfSides = 8;
            SideLength = length;
        }

        public double GetPerimeter()
        {
            return NumberOfSides * SideLength;

        }
        public virtual double GetArea()
        {
            return SideLength * SideLength * (2 + 2 * Math.Sqrt(2));
        }
    }
}
