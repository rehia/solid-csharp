using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using SOLID.LSP;

namespace SOLID.Tests.LSP
{
    [TestFixture]
    public class DuckBehavior
    {
        [Test]
        public void ColvertShouldSwim()
        {
            Duck duck = new Colvert();

            duck.Swim();

            Assert.That(duck.HasMoved());
        }

        [Test]
        public void ElectricDuckShouldSwim()
        {
            Duck duck = new ElectricDuck();

            // pour faire fonctionner un canard électrique
            // duck.TurnOn();
            duck.Swim();

            Assert.That(duck.HasMoved());
        }
    }
}