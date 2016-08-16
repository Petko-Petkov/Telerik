using IntergalacticTravel.Contracts;
using IntergalacticTravel.Exceptions;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntergalacticTravel.Tests
{
    [TestFixture]
    class TeleportStationsTests
    {
        [Test]
        public void ConstructorShouldSetupAllOfTheProvidedFields_WhenNewTeleportStationIsCreatedWithValidParameters()
        {
            // Arrange
            var teleportStation = GenerateMockedTeleportStation();

            // Act 

            // Assert 
            Assert.IsNotNull(teleportStation.Owner);
            Assert.IsNotNull(teleportStation.Location);
            Assert.IsNotNull(teleportStation.GalacticMap);
        }

        [Test]
        public void TeleportUnitShouldThrowArgumentNullExceptionWithMessageThatContainsUnitToTeleport_WhenIUnitUnitToTeleportIsNull()
        {
            // Arrange
            var teleportStation = GenerateMockedTeleportStation();
            var mockedLocation = new Mock<ILocation>();

            // Act and Assert 
            var exc = Assert.Throws<ArgumentNullException>(() => teleportStation.TeleportUnit(null, mockedLocation.Object));
            StringAssert.Contains(TestConstants.unitToTeleportUnitException, exc.Message);
        }

        [Test]
        public void TeleportUnitShouldThrowTeleportOutOfRangeException_WhenUnitLocationDiffersFromCurrentLocation()
        {
            // Arrange
            var teleportStation = GenerateMockedTeleportStation();
            var mockedUnit = new Mock<IUnit>();
            var mockedLocation = new Mock<ILocation>();
            mockedUnit.Setup(x => x.CurrentLocation.Planet.Galaxy.Name).Returns("Earth");

            // Act and Assert 
            var exc = Assert.Throws<TeleportOutOfRangeException>(
                () => teleportStation.TeleportUnit(mockedUnit.Object, mockedLocation.Object));
            StringAssert.Contains(TestConstants.unitToTeleportCurrentLocationException, exc.Message);
        }

        [Test]
        public void TeleportUnitShouldThrowInvalidTeleportationLocationException_WhenUnitDdestinationIsAlreadyTaken()
        {
            // Arrange
            var teleportStation = GenerateMockedTeleportStation();
            var mockedUnit = new Mock<IUnit>();
            mockedUnit.Setup(x => x.CurrentLocation.Planet.Name).Returns(TestConstants.planetMars);
            mockedUnit.Setup(x => x.CurrentLocation.Planet.Galaxy.Name).Returns(TestConstants.galaxyMilkyWayName);
            
            var mockedLocation = new Mock<ILocation>();
            mockedLocation.Setup(x => x.Planet.Galaxy.Name).Returns(TestConstants.galaxyMilkyWayName);
            mockedLocation.Setup(x => x.Planet.Name).Returns(TestConstants.planetMars);
            mockedLocation.Setup(x => x.Coordinates.Longtitude).Returns(1);
            mockedLocation.Setup(x => x.Coordinates.Latitude).Returns(1);

            // Act and Assert 
            var exc = Assert.Throws<InvalidTeleportationLocationException>(
                () => teleportStation.TeleportUnit(mockedUnit.Object, mockedLocation.Object));
            StringAssert.Contains(TestConstants.unitToTeleportOccupiedLocation, exc.Message);
        }

        [Test]
        public void TeleportUnitShouldThrowLocationNotFoundExceptionWithMesageGalaxy_WhenTeleportUnitToGaNotFoundInLocationsList()
        {
            var teleportStation = GenerateMockedTeleportStation();
            var mockedUnit = new Mock<IUnit>();
            mockedUnit.Setup(x => x.CurrentLocation.Planet.Name).Returns(TestConstants.planetMars);
            mockedUnit.Setup(x => x.CurrentLocation.Planet.Galaxy.Name).Returns(TestConstants.galaxyMilkyWayName);

            var mockedLocation = new Mock<ILocation>();
            mockedLocation.Setup(x => x.Planet.Galaxy.Name).Returns(TestConstants.invalidGalaxyName);
            mockedLocation.Setup(x => x.Planet.Name).Returns(TestConstants.planetEarth);
            mockedLocation.Setup(x => x.Coordinates.Longtitude).Returns(1);
            mockedLocation.Setup(x => x.Coordinates.Latitude).Returns(1);

            // Act and Assert 
            var exc = Assert.Throws<LocationNotFoundException>(
                () => teleportStation.TeleportUnit(mockedUnit.Object, mockedLocation.Object));
            StringAssert.Contains(TestConstants.locationNotFoundGalaxyExeption, exc.Message);
        }

        [Test]
        public void TeleportUnitShouldThrowLocationNotFoundExceptionWithMesagePlanet_WhenTeleportUnitToGaNotFoundInLocationsList()
        {
            var teleportStation = GenerateMockedTeleportStation();
            var mockedUnit = new Mock<IUnit>();
            mockedUnit.Setup(x => x.CurrentLocation.Planet.Name).Returns(TestConstants.planetMars);
            mockedUnit.Setup(x => x.CurrentLocation.Planet.Galaxy.Name).Returns(TestConstants.galaxyMilkyWayName);

            var mockedLocation = new Mock<ILocation>();
            mockedLocation.Setup(x => x.Planet.Galaxy.Name).Returns(TestConstants.galaxyMilkyWayName);
            mockedLocation.Setup(x => x.Planet.Name).Returns(TestConstants.invalidPlanetName);
            mockedLocation.Setup(x => x.Coordinates.Longtitude).Returns(1);
            mockedLocation.Setup(x => x.Coordinates.Latitude).Returns(1);

            // Act and Assert 
            var exc = Assert.Throws<LocationNotFoundException>(
                () => teleportStation.TeleportUnit(mockedUnit.Object, mockedLocation.Object));
            StringAssert.Contains(TestConstants.locationNotFoundPlanetExeption, exc.Message);
        }

        [Test]
        public void TeleportUnitShouldThrowInsufficientResourcesExceptionWithMesage_WhenTeleportUnitCannotPayRequiredFee()
        {
            var teleportStation = GenerateMockedTeleportStation();
            var mockedUnit = new Mock<IUnit>();
            mockedUnit.Setup(x => x.CurrentLocation.Planet.Name).Returns(TestConstants.planetMars);
            mockedUnit.Setup(x => x.CurrentLocation.Planet.Galaxy.Name).Returns(TestConstants.galaxyMilkyWayName);
            mockedUnit.Setup(x => x.Resources.SilverCoins).Returns(10);
            mockedUnit.Setup(x => x.Resources.BronzeCoins).Returns(10);
            mockedUnit.Setup(x => x.Resources.GoldCoins).Returns(10);

            var mockedLocation = new Mock<ILocation>();
            mockedLocation.Setup(x => x.Planet.Galaxy.Name).Returns(TestConstants.galaxyMilkyWayName);
            mockedLocation.Setup(x => x.Planet.Name).Returns(TestConstants.planetMars);
            mockedLocation.Setup(x => x.Coordinates.Longtitude).Returns(2);
            mockedLocation.Setup(x => x.Coordinates.Latitude).Returns(2);

            // Act and Assert 
            var exc = Assert.Throws<InsufficientResourcesException>(
                () => teleportStation.TeleportUnit(mockedUnit.Object, mockedLocation.Object));
            StringAssert.Contains(TestConstants.EXCEPTION_MESSAGE_INSUFFICIENT_RECOURSES, exc.Message);
        }

        [Test]
        public void TeleportUnitShouldCallGetPayment_WhenEverythingIsValid()
        {
            var teleportStation = GenerateMockedTeleportStation();
            
            var resource = new Mock<IResources>();
            resource.Setup(x => x.SilverCoins).Returns(500);
            resource.Setup(x => x.BronzeCoins).Returns(500);
            resource.Setup(x => x.GoldCoins).Returns(500);

            var mockedUnit = new Mock<IUnit>();
            mockedUnit.Setup(x => x.CurrentLocation.Planet.Name).Returns(TestConstants.planetMars);
            mockedUnit.Setup(x => x.CurrentLocation.Planet.Galaxy.Name).Returns(TestConstants.galaxyMilkyWayName);
            mockedUnit.Setup(x => x.CanPay(It.IsAny<IResources>())).Returns(true);
            mockedUnit.Setup(x => x.Pay(It.IsAny<IResources>())).Returns(resource.Object);
            mockedUnit.Setup(x => x.Resources).Returns(resource.Object);
            mockedUnit.Setup(x => x.CurrentLocation.Planet.Units).Returns(new List<IUnit>());


            var mockedLocation = new Mock<ILocation>();
            mockedLocation.Setup(x => x.Planet.Galaxy.Name).Returns(TestConstants.galaxyMilkyWayName);
            mockedLocation.Setup(x => x.Planet.Name).Returns(TestConstants.planetMars);
            mockedLocation.Setup(x => x.Coordinates.Longtitude).Returns(2);
            mockedLocation.Setup(x => x.Coordinates.Latitude).Returns(2);
            
            // Act and Assert 
            teleportStation.TeleportUnit(mockedUnit.Object, mockedLocation.Object);
            mockedUnit.Verify(x => x.Pay(It.IsAny<IResources>()), Times.Once);
        }

        public MockedTeleportStation GenerateMockedTeleportStation()
        {
            var mockedOwner = new Mock<IBusinessOwner>();
            Mock<IPath> mockedDdestination = GetDestination();
            Mock<IUnit> unit = GetUnit();
            mockedDdestination
                .Setup(x => x.TargetLocation.Planet.Units)
                .Returns(new List<IUnit>() { unit.Object });

            var mockedMap = new Mock<IEnumerable<IPath>>();
            var list = new List<IPath>() { mockedDdestination.Object };
            mockedMap.Setup(x => x.GetEnumerator()).Returns(list.GetEnumerator());
            Mock<ILocation> mockedLocation = GetLocation();
             mockedOwner.Setup(x => x.NickName).Returns("Pesho");
            var resources = new Mock<IResources>();
            resources.Setup(x => x.BronzeCoins).Returns(0);
            resources.Setup(x => x.SilverCoins).Returns(0);
            resources.Setup(x => x.GoldCoins).Returns(0);

            return new MockedTeleportStation(mockedOwner.Object, mockedMap.Object, mockedLocation.Object);
        }

        private static Mock<ILocation> GetLocation()
        {
            var mockedLocation = new Mock<ILocation>();
            mockedLocation.Setup(x => x.Planet.Galaxy.Name).Returns(TestConstants.galaxyMilkyWayName);
            mockedLocation.Setup(x => x.Planet.Name).Returns(TestConstants.planetMars);
            return mockedLocation;
        }

        private static Mock<IUnit> GetUnit()
        {
            var unit = new Mock<IUnit>();
            unit.Setup(x => x.CurrentLocation.Coordinates.Longtitude).Returns(1);
            unit.Setup(x => x.CurrentLocation.Coordinates.Latitude).Returns(1);
            unit.Setup(x => x.CurrentLocation.Planet.Name).Returns(TestConstants.planetMars);
            unit.Setup(x => x.CurrentLocation.Planet.Galaxy.Name).Returns(TestConstants.galaxyMilkyWayName);
            return unit;
        }

        private static Mock<IPath> GetDestination()
        {
            var mockedDdestination = new Mock<IPath>();
            mockedDdestination.Setup(x => x.TargetLocation.Planet.Name).Returns(TestConstants.planetMars);
            mockedDdestination.Setup(x => x.TargetLocation.Planet.Galaxy.Name).Returns(TestConstants.galaxyMilkyWayName);
            mockedDdestination.Setup(x => x.Cost.BronzeCoins).Returns(20);
            mockedDdestination.Setup(x => x.Cost.GoldCoins).Returns(20);
            mockedDdestination.Setup(x => x.Cost.SilverCoins).Returns(20);
            return mockedDdestination;
        }
    }
}
