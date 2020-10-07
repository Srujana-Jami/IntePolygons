using System;
using System.Collections.Generic;
using System.Text;

namespace PolyLib
{
    public interface IRegular
    {
        int NumberOfSides { get; set; }
        int SideLength { get; set; }

        double GetPerimeter();
        double GetArea();
    }
}
