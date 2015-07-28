using System;

namespace SOLID.ISP
{
    class Bird : Animal
    {
        public void Fly()
        {
        }

        public void Run()
        {
        }

        public void Bark()
        {
            throw new InvalidOperationException("birds can't bark !");
        }
    }
}