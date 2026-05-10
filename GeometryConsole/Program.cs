
using GeometryLibrary;
using System;

class Program
{
    static void Main()
    {
        Parallelogram p = new Parallelogram();

        p.A = 5;
        p.B =4;
        p.H = 3;

        Console.WriteLine("Площа = " + p.Area());
        Console.WriteLine("Периметр = " + p.Perimeter());
    }
}