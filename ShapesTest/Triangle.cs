using System;
using System.Collections.Generic;
using System.Text;

namespace ShapesTest
{
    class Triangle : Shape
    {
        int angle;
        int length1;
        int length2;


        // Setter methods
        public void setAngle(int angle)
        {
            this.angle = angle;
        }
        public void setLength1(int length1)
        {
            this.length1 = length1;
        }
        public void setLength2(int length2)
        {
            this.length2 = length2;
        }



        // Getter methods
        public int getAngle()
        {
            return this.angle;
        }

        public int getLength1()
        {
            return this.length1;
        }
        public int getLength2()
        {
            return this.length2;
        }

        // calculate the perimeter of the triangle
        public override double getPerimeter()
        {
            return length + length1 + length2;
        }

        // calculate the area of the triangle
        public override double getArea()
        {
            return 0.5 * (double)length1 * (double)length2 * Math.Sin(angle);
        }

    }
}
