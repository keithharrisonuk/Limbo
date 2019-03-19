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

        [TestCase(1, 2, 3)]
        public void Add(int a, int b, int expected)
        {
            Assert.AreEqual(expected, new Service().Add(a, b));
        }
    }
}