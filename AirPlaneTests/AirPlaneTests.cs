using AirPlaneProject;
using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        Airplane plane = new Airplane();
        [SetUp]
        public void Setup()
        {

        }
        [Category("Airplane Tests")]
        [Test]
        public void Land_ShouldReturnLanded_WhenCalled()
        {
            Assert.AreEqual("Landed", plane.land());
        }

        public void PlaneStatus_ShouldBeFlying_WhenCalled()
        {
            var airplane = new Airplane();
            Assert.AreEqual("Flying", airplane.PlaneStatus);
        }

        public void PlaneAirport_ShouldBeBlank_WhenFlying()
        {
            var airplane = new Airplane();
            Assert.AreEqual("", airplane.CurrentAirport);
        }

        [Category("Airport Tests")]

        public void Airport_ShouldAcceptPlaneInHanger_AddPlaneToAirportHanger()
        {
            var airPlane = new Airplane();
            var airport = new Airport("Test");
            airport.AcceptPlane(airPlane);
            airport.AcceptPlane(airPlane);
            Assert.IsInstanceOf(typeof(Airplane), airport.planeHanger[1]);
        }

        public void Airport_ShouldHaveName_WhenInstantiated()
        {
            var airport = new Airport("Test");
            Assert.AreEqual("Test", airport.airportLocation);
        }
    }
}