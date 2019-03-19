using NUnit.Framework;
using Services;

namespace UnitTests.Services
{
    [TestFixture]
    public class Service_CanMultiply
    {
        [Test]
        public void CanMultiplyNumbers()
        {
            Assert.AreEqual(6, new Service().Multiply(2,3));
        }

        [Test]
        public void CanMultiplyNumbers1()
        {
            Assert.AreEqual(9, new Service().Multiply(3,3));
        }

        [Test]
        public void Add()
        {
            Assert.AreEqual(6, new Service().Add(3,3));
        }
    }
}