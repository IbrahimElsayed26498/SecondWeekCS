// In the name of Allah, the Gracious, the Merciful
using System;
using System.Collections.Generic;
using System.Text;

namespace ShapesTest
{
    class SharpTriangle : Triangle
    {
        int angle1;
        int angle2;
        int angle3;

        //Setter methods
        public void setAngle1(int angle1)
        {
            this.angle1 = angle1;
        }
        public void setAngle2(int angle2)
        {
            this.angle2 = angle2;
        }
        public void setAngle3(int angle3)
        {
            this.angle3 = angle3;
        }

        // Getter methods
        public int getAngle1()
        {
            return this.angle1;
        }
        public int getAngle2()
        {
            return this.angle2;
        }
        public int getAngle3()
        {
            return this.angle3;
        }

        public void printAngles()
        {
            Console.WriteLine("Angle 1 : {0}\nAngle 2 : {1}\nAngle 3 : {2}",
                getAngle1(), getAngle2(), getAngle3());
        }
    }
}
