using System;

namespace SOLID.OCP
{
    public class Circle : Shape
    {
        public Circle(float radius)
        {
            this.Radius = radius;
        }

        public float Radius { get; private set; }

        public double Area()
        {
            return Radius*Radius*Math.PI;
        }
    }
}