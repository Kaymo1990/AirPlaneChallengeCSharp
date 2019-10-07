using AirPlaneProject;
using NUnit.Framework;
using System;
using System.Linq;

namespace Tests
{
    [TestFixture]
    public class Tests
    {
        Airplane airplane;
        Airport airport;
        Weather weather;

        [SetUp] public void Init()
        {
            airplane = new Airplane();
            airport = new Airport("Test", 10);
            weather = new Weather(1.1);
        }


        [Test] public void Land_ShouldReturnLanded_WhenCalled()
        {
            Assert.AreEqual("Landed", airplane.Land(airport, weather));
        }

        [Test] public void TakeOff_ShouldRemovePlaneFromAirport_AirportHangerCount0()
        {
            airplane.Land(airport, weather);
            airplane.TakeOff(airport, weather);
            Assert.AreEqual(0, airport.PlaneHanger.Count);
        }

        [Test]
        public void TakeOff_ShouldUpdatePlaneLocation_ToBlank()
        {
            airplane.Land(airport, weather);
            airplane.TakeOff(airport, weather);
            Assert.AreEqual("", airplane.CurrentAirport);
        }

        [Test]
        public void TakeOff_ShouldUpdatePlaneStatus_ToFlying()
        {
            airplane.Land(airport, weather);
            airplane.TakeOff(airport, weather);
            Assert.AreEqual("Flying", airplane.PlaneStatus);
        }

        [Test] public void TakeOff_ThrowsErrorWhenPlaneNotAtAirport_ThrowError()
        {
            Assert.Throws<Exception>(() => airplane.TakeOff(airport, weather));
        }

        [Test] public void Land_ShouldUpdatePlaneLocation_ToTestWhenCalled()
        {
            airplane.Land(airport, weather);
            Assert.AreEqual("Test", airplane.CurrentAirport);
        }

        [Test]
        public void Land_ShouldUpdateAirportHanger_ToHave1Plane()
        {
            airplane.Land(airport, weather);
            Assert.IsInstanceOf(typeof(Airplane), airport.PlaneHanger.ElementAt(0));
        }

        [Test] public void PlaneStatus_ShouldBeFlying_WhenCalled()
        {
            Assert.AreEqual("Flying", airplane.PlaneStatus);
        }

        [Test] public void PlaneAirport_ShouldBeBlank_WhenFlying()
        {
            Assert.AreEqual("", airplane.CurrentAirport);
        }

        [Test] public void Airport_ShouldAcceptPlaneInHanger_AddPlaneToAirportHanger()
        {
            airport.AcceptPlane(airplane, weather);
            airport.AcceptPlane(airplane, weather);
            Assert.IsInstanceOf(typeof(Airplane), airport.PlaneHanger.ElementAt(1));
        }

        [Test] public void EjectPlane_ShouldRemovePlane_HangerCountShouldReturn0()
        {
            airport.AcceptPlane(airplane, weather);
            airport.EjectPlane(airplane, weather);
            Assert.AreEqual(0, airport.PlaneHanger.Count);
        }
        [Test] public void Airport_ShouldHaveName_WhenInstantiated()
        {
            Assert.AreEqual("Test", airport.airportLocation);
        }

        [Test] public void IsStormy_ShouldBeTrue_WhenStormy()
        {
            Weather weather = new Weather(0.0);
            Assert.IsTrue(weather.IsStormy());
        }

        [Test] public void IsStormy_ShouldBeFalse_WhenNotStormy()
        {
            Assert.IsFalse(weather.IsStormy());
        }

        [Test] public void LandPlane_WontLandWhenStormy_StormyIsTrue()
        {
            Weather weather = new Weather(0.0);
            Assert.Throws<Exception>(()=> airplane.Land(airport, weather));
        }

        [Test] public void LandPlane_WontLandWhenAirportFull_AirportCapacityAt10()
        {
            for (int i = 0; i < 10; i++)
            {
                airplane.Land(airport, weather);
            }

            Assert.Throws<Exception>(() => airplane.Land(airport, weather));
        }

        [Test] public void AirportCapacity_CanBe20_HangerCountShouldBe20()
        {
            var airport = new Airport("Test", 20);
            for (int i = 0; i < 20; i++)
            {
                airplane.Land(airport, weather);
            }
            Assert.AreEqual(20, airport.PlaneHanger.Count);
        }
    }
}