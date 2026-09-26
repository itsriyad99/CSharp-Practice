class Rectangle
{
    public double length;
    public double width;
}

class Program
{
    static void Main(string[] args)
    {
        Rectangle rect = new Rectangle();
        rect.length = 5.0;
        rect.width = 3.0;
        double area = rect.length * rect.width;
        double perimeter = 2 * (rect.length + rect.width);
        Console.WriteLine($"Area of rectangle: {area}");
        Console.WriteLine($"Perimeter of rectangle: {perimeter}");
    }
}