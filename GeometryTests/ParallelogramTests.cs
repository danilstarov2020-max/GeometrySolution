using NUnit.Framework;
using GeometryApp;

namespace GeometryTests
{
    public class ParallelogramTests
    {
        [Test]
        public void Area_Test()
        {
            Parallelogram p = new Parallelogram();

            p.A = 5;
            p.H = 3;

            double result = p.Area();

            Assert.AreEqual(15, result);
        }

        [Test]
        public void Perimeter_Test()
        {
            Parallelogram p = new Parallelogram();

            p.A = 5;
            p.B = 4;

            double result = p.Perimeter();

            Assert.AreEqual(18, result);
        }

        [Test]
        public void Area_Second_Test()
        {
            Parallelogram p = new Parallelogram();

            p.A = 10;
            p.H = 2;

            double result = p.Area();

            Assert.AreEqual(20, result);
        }
    }
}
