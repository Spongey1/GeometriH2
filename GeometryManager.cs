using System;

namespace GeometriH2
{
    public class GeometryManager // Manager that handles geometry via polymorphism (overload)
    {
        public double Perimeter(Shape square)
        {
            return square.A * 4;
        }

        public double Perimeter(Rectangle rectangle)
        {
            return rectangle.A * 4;
        }

        public double Perimeter(Trapezoid trapezoid)
        {
            return 0.5 * trapezoid.H * ((trapezoid.A * trapezoid.A) * (trapezoid.B * trapezoid.B));
        }

        public double Perimeter(Parallelogram parallelogram)
        {
            return parallelogram.A * parallelogram.B;
        }

        public double Perimeter(Triangle triangle)
        {
            return triangle.A + triangle.B + triangle.Katete;
        }

        public double Area(Shape square)
        {
            return square.A * 2;
        }

        public double Area(Rectangle rectangle)
        {
            return rectangle.A * rectangle.B;
        }

        public double Area(Trapezoid trapezoid)
        {
            double s = (trapezoid.A + trapezoid.B - trapezoid.C + trapezoid.D) / 2;
            trapezoid.H = (2 / trapezoid.A - trapezoid.C) * Math.Sqrt(s * (s - trapezoid.A + trapezoid.C) * (s - trapezoid.B) * (s - trapezoid.D));

            return trapezoid.H;
        }

        public double Area(Parallelogram parallelogram)
        {
            return parallelogram.A * parallelogram.B * Math.Sin(20 * Math.PI / 180);
        }

        public double Area(Triangle triangle)
        {
            return 0.5 * triangle.A * triangle.B;
        }
    }
}