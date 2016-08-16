using IntergalacticTravel.Exceptions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntergalacticTravel.Tests
{
    [TestFixture]
    class UnitsfFactoryTests
    {
        [TestCase("create unit Procyon Gosho 1", typeof(Procyon))]
        [TestCase("create unit Luyten Pesho 2", typeof(Luyten))]
        [TestCase("create unit Lacaille Tosho 3", typeof(Lacaille))]
        public void UnitsFactoryGetUnit_ShouldInstantiateCorrectInstance_WhenValuePassedIsCorrect(string command, Type type)
        {
            // Arrange 
            var uf = new UnitsFactory();

            // Act 
            var unit = uf.GetUnit(command);

            // Assert
            Assert.IsInstanceOf(type, unit);
        }

        [Test]
        public void UnitsFactoryGetUnit_ShouldThrowInvalidUnitCreationCommandException_WhenStringDoesNotContainsValidType()
        {
            // Arrange
            var uf = new UnitsFactory();
            
            // Act and Assert
            Assert.Throws<InvalidUnitCreationCommandException>(()=> uf.GetUnit("create unit INVALID_TYPE Pesho 2"));
        }

        [Test]
        public void UnitsFactoryGetUnit_ShouldThrowInvalidUnitCreationCommandException_WhenInvalidIdPassed()
        {
            // Arrange
            var uf = new UnitsFactory();

            // Act and Assert
            Assert.Throws<InvalidUnitCreationCommandException>(() => uf.GetUnit("create unit Lacaille Pesho ID"));
        }
    }
}
