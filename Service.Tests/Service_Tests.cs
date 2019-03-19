using NUnit.Framework;
using Services;

namespace UnitTests.Services
{
    [TestFixture]
    public class Service_CanMultiply
    {
        [TestCase(2, 3, 6)]
        public void CanMultiplyNumbers(int a, int b, int expected)
        {
            Assert.AreEqual(expected, new Service().Multiply(a, b));
        }

        [Test]
        public void CanMultiplyNumbers1()
        {
            Assert.AreEqual(9, new Service().Multiply(3,3));
        }

        [TestCase(1, 2, 3)]
        [TestCase(4, 2, 6)]
        [TestCase(4, 8, 12)]
        public void Add(int a, int b, int expected)
        {
            Assert.AreEqual(expected, new Service().Add(a, b));
        }
        // Oh no!
        
    }
}