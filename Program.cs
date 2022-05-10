using System;
using System.Collections.Generic;

namespace GeometriH2
{
    class Program
    {
        static void Main(string[] args)
        {
            GeometryManager gm = new GeometryManager();

            List<Shape> shapes = new List<Shape>();
            shapes.Add(new Rectangle(5, 10));
            shapes.Add(new Trapezoid(10, 9, 8, 9));
            shapes.Add(new Parallelogram(2, 3));

            foreach (var shape in shapes)
            {
                Console.WriteLine("Perimeter: {0}", gm.Perimeter(shape));
                Console.WriteLine("Area: {0}", gm.Area(shape));
                Console.WriteLine("\r\n");
            }
        }
    }
}