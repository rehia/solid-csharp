using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.OCP
{
    public class AreaCalculator
    {
        public double Area(IList<Shape> shapes)
        {
            double area = 0;

            foreach (var shape in shapes)
            {
                area += shape.Area();
            }

            return area;
        }
    }
}