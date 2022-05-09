using System;
namespace GeometriH2
{
    public class Trapezoid : Square
    {
        public double B { get; set; }
        public double C { get; set; }
        public double D { get; set; }
        public double H { get; set; }

        public Trapezoid(double a, double b, double c, double d) : base(a)
        {
            B = b;
            C = c;
            D = d;
        }
    }
}