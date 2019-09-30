using System;

namespace ShapesTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Square square = new Square();
            Circule circule = new Circule();
            Triangle triangle = new Triangle();
            SharpTriangle sharpTriangle = new SharpTriangle();

            // setting the data of the square
            Console.WriteLine("Square :");
            Console.Write("Enter length of Square : ");
            square.setLength(Convert.ToInt32(Console.ReadLine()));

            Console.Write("Enter corner (x, y) : ");
            square.move(Convert.ToInt32(Console.ReadLine()),
                Convert.ToInt32(Console.ReadLine()));

            // setting the data of the circule
            Console.WriteLine("Circule :");
            Console.Write("Enter radius of the circule : ");
            circule.setLength(Convert.ToInt32(Console.ReadLine()));

            // setting the data of the triangle
            Console.Write("Triangle :");
            Console.Write("Length 1 : ");
            triangle.setLength(Convert.ToInt32(Console.ReadLine()));
            Console.Write("Length 2 : ");
            triangle.setLength1(Convert.ToInt32(Console.ReadLine()));
            Console.Write("Length 3 : ");
            triangle.setLength2(Convert.ToInt32(Console.ReadLine()));
            Console.Write("Enter angle between length 2 and length 3 : ");
            triangle.setAngle(Convert.ToInt32(Console.ReadLine()));

            // setting data of sharp triangle
            Console.WriteLine("Sharp triangle :");
            Console.Write("Angle 1 :");
            sharpTriangle.setAngle1(Convert.ToInt32(Console.ReadLine()));
            Console.Write("Angle 2 :");
            sharpTriangle.setAngle2(Convert.ToInt32(Console.ReadLine()));
            Console.Write("Angle 3 :");
            sharpTriangle.setAngle3(Convert.ToInt32(Console.ReadLine()));

            // printing data
            Console.WriteLine("\n---------------------------\n");

            // Square
            Console.WriteLine("Square :");
            Console.WriteLine(square.details());
            Console.WriteLine("Perimeter : {0}\nArea : {1}",
                square.getPerimeter(), square.getArea());

            // Circule
            Console.WriteLine("Circule :");
            Console.WriteLine("Perimeter : {0}\nArea : {1}",
                circule.getPerimeter(), circule.getArea());

            // Triangle
            Console.WriteLine("Triangle :");
            Console.WriteLine("Perimeter : {0}\nArea : {1}",
                triangle.getPerimeter(), triangle.getArea());

            // Sharp triangle
            Console.WriteLine("Sharp triangle : ");
            sharpTriangle.printAngles();


        }
    }
}
