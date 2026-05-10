namespace GeometryApp;

public class Parallelogram
{
    public double A { get; set; }
    public double B { get; set; }
    public double H { get; set; }

    public double Area()
    {
        return A * H;
    }

    public double Perimeter()
    {
        return 2 * (A + B);
    }
}