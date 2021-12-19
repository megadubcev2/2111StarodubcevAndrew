using System;




namespace sem2._1
{
    public class Polygon
    {
        public int N { get; set; }
        public double Radius { get; set; }
        public double Storona { get; }
        public double Perimetr { get; }
        public double Square { get; }
        public Polygon(int n = 4, double radius = 1)
        {
            N = n;
            Radius = radius;
            Storona = 2 * Radius * Math.Tan(Math.PI/N) ;
        }

        
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
