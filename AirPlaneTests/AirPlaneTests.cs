using AirPlaneProject;
using NUnit.Framework;
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
            airport = new Airport("Test");
        }


        [Test] public void Land_ShouldReturnLanded_WhenCalled()
        {
            Assert.AreEqual("Landed", airplane.land());
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
        [Test] public void Airport_ShouldHaveName_WhenInstantiated()
        {
            Assert.AreEqual("Test", airport.airportLocation);
        }
    }
}