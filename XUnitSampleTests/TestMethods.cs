using System;
using Xunit;

namespace XUnitSampleTests
{
    public class TestMethods
    {
        [Fact]
        public void TestMethod1()
        {
            Assert.True(true);
        }

        [Fact(Skip = "Inconclusive")]
        public void TestMethod2()
        {}

        [Fact]
        public void TestMethod3()
        {
            Assert.True(false);
        }

        [Fact]
        public void TestMethod4()
        {
            Assert.True(true);
        }
    }
}
