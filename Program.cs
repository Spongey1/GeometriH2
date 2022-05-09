using System;

namespace GeometriH2
{
    class Program
    {
        static void Main(string[] args)
        {
            GeometryManager gm = new GeometryManager();

            Console.WriteLine(gm.Perimeter(new Trapezoid(10, 9, 8, 9)));
        }
    }
}