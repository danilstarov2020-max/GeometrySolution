using NUnit.Framework;
using GeometryApp;

namespace GeometryTests;

public class ParallelogramTests
{
    [Test]
    public void Area_Test()
    {
        var p = new Parallelogram { A = 5, H = 3 };
        Assert.AreEqual(15, p.Area());
    }

    [Test]
    public void Perimeter_Test()
    {
        var p = new Parallelogram { A = 5, B = 4 };
        Assert.AreEqual(18, p.Perimeter());
    }
}