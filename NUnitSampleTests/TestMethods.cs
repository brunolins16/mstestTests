using NUnit.Framework;

namespace NUnitSampleTests
{
    public class TestMethods
    {
        [SetUp]
        public void Setup()
        {}

        [Test]
        public void TestMethod1()
        {
            Assert.Pass();
        }

        [Test]
        public void TestMethod2()
        {
            Assert.Inconclusive();
        }

        [Test]
        public void TestMethod3()
        {
            Assert.Fail();
        }

        [Test]
        public void TestMethod4()
        {
            Assert.Pass();
        }
    }
}