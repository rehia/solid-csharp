using System;

namespace SOLID.ISP
{
    class Cat : Animal
    {
        public void Fly()
        {
            throw new InvalidOperationException("cats can't fly ! some tries...");
        }

        public void Run()
        {
        }

        public void Bark()
        {
            throw new InvalidOperationException("cats can't bark !");
        }
    }
}