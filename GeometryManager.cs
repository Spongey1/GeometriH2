using System;

namespace GeometriH2
{
    public class GeometryManager // Manager that handles geometry via polymorphism (overload)
    {
        public double Perimeter(Square square)
        {
            return square.A * 4;
        }

        public double Perimeter(Rectangle rectangle)
        {
            return rectangle.A * 4;
        }

        public double Perimeter(Trapezoid trapezoid)
        {
            double s = (trapezoid.A + trapezoid.B - trapezoid.C + trapezoid.D) / 2;
            trapezoid.H = (2 / trapezoid.A - trapezoid.C) * Math.Sqrt(s * (s - trapezoid.A + trapezoid.C) * (s - trapezoid.B) * (s - trapezoid.D));

            return 0.5 * (trapezoid.A * trapezoid.C) * trapezoid.H;
        }

        public double Perimeter(Parallelogram parallelogram)
        {
            return parallelogram.A * parallelogram.B * Math.Sin(20 * Math.PI / 180);
        }
    }
}