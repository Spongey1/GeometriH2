namespace GeometriH2
{
    public class Parallelogram : Square
    {
        public double B { get; set; }

        public Parallelogram(double a, double b) : base(a)
        {
            B = b;
        }
    }
}