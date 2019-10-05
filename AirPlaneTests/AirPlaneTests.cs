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

        [Category("Airport Tests")]

        public void Airport_ShouldAcceptPlaneInHanger_AddPlaneToAirportHanger()
        {

        }
    }
}