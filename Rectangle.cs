namespace GeometriH2
{
    public class Rectangle : Square
    {
        public double B { get; set; }

        public Rectangle(double a, double b) : base(a)
        {
            B = b;
        }
    }
}