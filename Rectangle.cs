namespace GeometriH2
{
    public class Rectangle : Shape
    {
        public double B { get; set; }

        public Rectangle(double a, double b) : base(a)
        {
            B = b;
        }
    }
}