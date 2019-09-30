using System;
using System.Collections.Generic;
using System.Text;

namespace ShapesTest
{
    abstract class Shape
    {
        protected int length;
        /*public Shape(int length)
        {
            this.length = length;
        }
        
        public Shape()
        {
            this.length = 0;
        }*/

        public void setLength(int length)
        {
            this.length = length;
        }

        public int getLength()
        {
            return this.length;
        }

        abstract public double getArea();
        abstract public double getPerimeter();
    }
}
