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

        [Test]
        public void Land_ShouldReturnLanded_WhenCalled()
        {
            Assert.AreEqual("Landed", plane.land());
        }
    }
}