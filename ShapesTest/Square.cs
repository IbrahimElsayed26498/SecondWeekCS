using System;
using System.Collections.Generic;
using System.Text;

namespace ShapesTest
{
    class Square : Shape
    {
        int x;
        int y;
        /*public Square(int length, int x, int y) : base(length)
        {
            this.length = length;
            this.x = x;
            this.y = y;
        }

        public Square() : base()
        {
            this.x = 0;
            this.y = 0;
        }*/
        public void setX(int x)
        {
            this.x = x;
        }

        public void setY(int y)
        {
            this.y = y;
        }

        public int getX()
        {
            return this.x;
        }

        public int getY()
        {
            return this.y;
        }

        public override double getArea()
        {
            return length * length;
        }

        public override double getPerimeter()
        {
            return length * 4;
        }
        public void move(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void scale(int s)
        {
            length = length * s;
        }

        public string details()
        {
            return string.Format("corner({0}, {1}), side {2}", x, y, length);
        }


    }
}
