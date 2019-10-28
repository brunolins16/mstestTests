using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SampleTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [Priority(0)]
        public void TestMethod1()
        {
            Assert.IsTrue(true);
        }

        [TestMethod]
        [Priority(0)]
        public void TestMethod2()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        [Priority(0)]
        public void TestMethod3()
        {
            Assert.Fail();
        }

        [TestMethod]
        [Priority(0)]
        public void TestMethod4()
        {
            Assert.IsTrue(true);
        }
    }
}
