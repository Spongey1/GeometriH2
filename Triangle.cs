namespace GeometriH2
{
    public class Triangle : Shape
    {
        public double B { get; set; }
        public double Katete { get; set; }
        public Triangle(double a, double b, double katete) : base(a)
        {
            B = b;
            Katete = katete;
        }
    }
}