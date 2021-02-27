using Application.Ships.GenerateShips;
using Domian.Entities;
using NUnit.Framework;
using System.Linq;

namespace Application.UnitTests.Ships.GenerateShips
{
    [Category("Unit")]
    public class ShipsGeneratorTests
    {
        private ShipsGenerator generator;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            this.generator = new ShipsGenerator();
        }

        [Test]
        public void It_has_correct_number_of_ships()
        {
            var ships = this.generator
                .GenerateShips()
                .ToArray();

            Assert.That(ships, Has.Exactly(3).Items);

            Assert.That(ships[0], Is.InstanceOf<Battleship>());
            Assert.That(ships[1], Is.InstanceOf<Destroyer>());
            Assert.That(ships[2], Is.InstanceOf<Destroyer>());
        }
    }
}
