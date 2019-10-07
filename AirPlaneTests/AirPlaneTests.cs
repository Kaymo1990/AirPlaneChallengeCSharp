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

        [SetUp] public void Init()
        {
            airplane = new Airplane();
            airport = new Airport("Test", 10);
        }


        [Test] public void Land_ShouldReturnLanded_WhenCalled()
        {
            Assert.AreEqual("Landed", airplane.Land(airport));
        }

        [Test] public void TakeOff_ShouldRemovePlaneFromAirport_AirportHangerCount0()
        {
            airplane.Land(airport);
            airplane.TakeOff(airport);
            Assert.AreEqual(0, airport.PlaneHanger.Count);
        }

        [Test]
        public void TakeOff_ShouldUpdatePlaneLocation_ToBlank()
        {
            airplane.Land(airport);
            airplane.TakeOff(airport);
            Assert.AreEqual("", airplane.CurrentAirport);
        }

        [Test]
        public void TakeOff_ShouldUpdatePlaneStatus_ToFlying()
        {
            airplane.Land(airport);
            airplane.TakeOff(airport);
            Assert.AreEqual("Flying", airplane.PlaneStatus);
        }

        [Test] public void TakeOff_ThrowsErrorWhenPlaneNotAtAirport_ThrowError()
        {
            Assert.Throws<Exception>(() => airplane.TakeOff(airport));
        }

        [Test] public void Land_ShouldUpdatePlaneLocation_ToTestWhenCalled()
        {
            airplane.Land(airport);
            Assert.AreEqual("Test", airplane.CurrentAirport);
        }

        [Test]
        public void Land_ShouldUpdateAirportHanger_ToHave1Plane()
        {
            airplane.Land(airport);
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
            airport.AcceptPlane(airplane);
            airport.AcceptPlane(airplane);
            Assert.IsInstanceOf(typeof(Airplane), airport.PlaneHanger.ElementAt(1));
        }

        [Test] public void EjectPlane_ShouldRemovePlane_HangerCountShouldReturn0()
        {
            airport.AcceptPlane(airplane);
            airport.EjectPlane(airplane);
            Assert.AreEqual(0, airport.PlaneHanger.Count);
        }
        [Test] public void Airport_ShouldHaveName_WhenInstantiated()
        {
            Assert.AreEqual("Test", airport.airportLocation);
        }

        [Test] public void IsStormy_ShouldBeTrue_WhenStormy()
        {
            Assert.IsTrue(Weather.IsStormy(0.0));
        }

        [Test] public void IsStormy_ShouldBeFalse_WhenNotStormy()
        {
            Assert.IsFalse(Weather.IsStormy(1.1));
        }
    }
}