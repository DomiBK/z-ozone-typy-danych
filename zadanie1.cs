using System;

struct Point
{
    public double X { get; set; }
    public double Y { get; set; }

    public Point(double x, double y)
    {
        X = x;
        Y = y;
    }

    public static double CalculateDistance(Point p1, Point p2)
    {
        return Math.Sqrt(Math.Pow(p2.X - p1.X, 2) + Math.Pow(p2.Y - p1.Y, 2));
    }
}

class Program
{
    static void Main()
    {
        
        Point point1 = new Point(1, 2);

        Point point2 = new Point(4, 6);

        double distance = Point.CalculateDistance(point1, point2);

        Console.WriteLine($"Odległość między punktami ({point1.X}, {point1.Y}) i ({point2.X}, {point2.Y}) wynosi: {distance:F2}");
    }
}
