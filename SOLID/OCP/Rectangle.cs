using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.OCP
{
    public class Rectangle : Shape
    {
        private float height;
        private float width;

        public Rectangle(int height, int width)
        {
            this.height = height;
            this.width = width;
        }

        public float GetHeight()
        {
            return height;
        }

        public float GetWidth()
        {
            return width;
        }

        public double Area()
        {
            return GetHeight() * GetWidth();
        }
    }
}
