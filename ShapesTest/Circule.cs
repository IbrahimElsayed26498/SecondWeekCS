using System;
using System.Collections.Generic;
using System.Text;

namespace ShapesTest
{
    class Circule : Shape
    {
        public override double getPerimeter()
        {
            return 2.0 * Math.PI * (double)length;
        }

        public override double getArea()
        {
            return Math.PI * Math.Pow(length, 2);
        }
    }
}
