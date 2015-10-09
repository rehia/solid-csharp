using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using SOLID.OCP;

namespace SOLID.Tests.OCP
{
    [TestFixture]
    public class AreaCalculatorBehavior
    {
        private AreaCalculator calculator = new AreaCalculator();

        [Test]
        public void ShouldCalculateARectangleArea()
        {
            var rectangles = new List<Shape> {new Rectangle(10, 3)};

            var area = calculator.Area(rectangles);

            Assert.AreEqual(30.0, area, 0.01);
        }

        [Test]
        public void ShouldCalculateTotalAreaForTwoRectangles()
        {
            var rectangles = new List<Shape> {new Rectangle(10, 3), new Rectangle(4, 5)};

            var area = calculator.Area(rectangles);

            Assert.AreEqual(50.0, area, 0.01);
        }


        [Test]
        public void ShouldCalculateACircleArea()
        {
            var circles = new List<Shape> { new Circle(5) };

            var area = calculator.Area(circles);

            Assert.AreEqual(78.5, area, 0.1);
        }
    }
}