using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntergalacticTravel.Tests
{
    [TestFixture]
    class ResourcesFactoryTests
    {
        private const uint goldCoins = 20;
        private const uint silverCoins = 30;
        private const uint bronzeCoins = 40;
        private const string expectedInvalidOperationMessage = "Invalid command";

        [TestCase("create resources gold(20) silver(30) bronze(40)")]
        [TestCase("create resources gold(20) bronze(40) silver(30)")]
        [TestCase("create resources silver(30) bronze(40) gold(20)")]
        [TestCase("create resources silver(30) gold(20) bronze(40)")]
        [TestCase("create resources bronze(40) gold(20) silver(30)")]
        [TestCase("create resources bronze(40) silver(30) gold(20)")]
        public void GetResources_ShouldReturnNewlyCreatedResource_NoMatterTheOrderOfTheParams(string input)
        {
            // Arrange 
            var rf = new ResourcesFactory();

            // Act 
            var resource = rf.GetResources(input);

            // Assert
            Assert.AreEqual(resource.GoldCoins, goldCoins);
            Assert.AreEqual(resource.SilverCoins, silverCoins);
            Assert.AreEqual(resource.BronzeCoins, bronzeCoins);
        }

        [TestCase("create resources x y z")]
        [TestCase("tansta resources a b")]
        [TestCase("absolutelyRandomStringThatMustNotBeAValidCommand")]
        public void GetResources_ShouldThrowsInvalidOperationException_WhenInvalidCommandStringPassed(string input)
        {
            // Arrange 
            var rf = new ResourcesFactory();

            // Act and Assert
            var exc = Assert.Throws<InvalidOperationException>(()=> rf.GetResources(input));
            StringAssert.Contains(expectedInvalidOperationMessage, exc.Message);
        }

        [TestCase("create resources silver(10) gold(97853252356623523532) bronze(20)")]
        [TestCase("create resources silver(555555555555555555555555555555555) gold(97853252356623523532999999999) bronze(20)")]
        [TestCase("create resources silver(10) gold(20) bronze(4444444444444444444444444444444444444)")]
        public void GetResources_ShouldThrowOverflowException_WhenSomeOfTheValuesOverflowsUnitMaxValue(string command)
        {
            // Arrange 
            var rf = new ResourcesFactory();

            // Act and Assert
            Assert.Throws<OverflowException>(() => rf.GetResources(command));
        }
    }
}
