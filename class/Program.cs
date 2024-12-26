using ClassLibrary;

class Program
{
    static void Main()
    {
        Console.Write("Введите координату x: ");
        double x = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите координату y: ");
        double y = Convert.ToDouble(Console.ReadLine());

        Point point = new Point(x, y);
        double distance = CalculateDistance(point);

        Console.WriteLine($"Расстояние от точки до начала координат: {distance:F2}");
    }

    static double CalculateDistance(Point point)
    {
        return Math.Sqrt(point.X * point.X + point.Y * point.Y);
    }
}