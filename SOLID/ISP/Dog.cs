using System;

namespace SOLID.ISP
{
    class Dog : Animal
    {
        public void Fly()
        {
            throw new InvalidOperationException("dogs can't fly !");
        }

        public void Run()
        {
        }

        public void Bark()
        {
        }
    }
}