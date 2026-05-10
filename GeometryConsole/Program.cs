using System;
using GeometryApp;

class Program
{
    static void Main()
    {
        Parallelogram p = new Parallelogram
        {
            A = 5,
            B = 4,
            H = 3
        };

        Console.WriteLine("Площа = " + p.Area());
        Console.WriteLine("Периметр = " + p.Perimeter());
    }
}