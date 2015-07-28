using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.OCP
{
    public class AreaCalculator
    {
        public double Area(IList<Rectangle> rectangles)
        {
            double area = 0;

            foreach (var rectangle in rectangles)
            {
                area += rectangle.GetHeight() * rectangle.GetWidth();
            }

            return area;
        }
    }
}