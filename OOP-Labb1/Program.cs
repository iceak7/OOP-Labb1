using System;

namespace OOP_Labb1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cirkel:");

            Circle circle = new Circle(5);
            Console.WriteLine("Area när radien är {0} = {1} ", circle._radius,circle.getArea());

            circle._radius = 6;
            Console.WriteLine("Area när radien är {0} = {1} ", circle._radius,circle.getArea());

            Console.WriteLine("Omkrets när radien är {0} = {1} ", circle._radius, circle.getCircumference());
            Console.WriteLine("Volym när radien är {0} = {1} ", circle._radius, circle.getVolumeSphere());


            Triangle triangle = new Triangle(4, 2, 5);
            Console.WriteLine("\nTriangel:");
            Console.WriteLine("Area när sidorna är {0}, {1}, {2} = {3} ", triangle._side1, triangle._side2, triangle._side3,triangle.getArea());
            Console.WriteLine("Omkrets när sidorna är {0}, {1}, {2} = {3} ", triangle._side1, triangle._side2, triangle._side3, triangle.getPerimeter());


            Console.ReadLine();
        }
    }

    class Circle
    {
        static readonly float _pi= 3.14f;
        public int _radius;

        public Circle(int Radius)
        {
            _radius = Radius;
        }

        public float getArea()
        {
            return _radius * _radius * _pi;
        }

        public float getCircumference()
        {
            return _radius * 2 * _pi;
        }

        public float getVolumeSphere()
        {
            return (float)(4 * _pi * Math.Pow(_radius, 3)) / 3;
        }
    }

    class Triangle
    {
        public double _side1;
        public double _side2;
        public double _side3;

        public Triangle(int Side1, int Side2, int Side3)
        {
            _side1 = Side1;
            _side2 = Side2;
            _side3 = Side3;
        }

        public float getArea()
        {
            double s = (_side1 + _side2 + _side3) / 2;
            return (float)Math.Sqrt(s * (s - _side1) * (s - _side2) * (s - _side3));
        }
        public float getPerimeter()
        {
            return (float)(_side1 + _side2 + _side3);
        }

    }
}
