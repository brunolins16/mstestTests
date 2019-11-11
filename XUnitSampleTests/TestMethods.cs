using System;
using Xunit;

namespace XUnitSampleTests
{
    public class TestMethods
    {
        [Fact]
        [Trait("Priority",0)]
        public void TestMethod1()
        {
            Assert.True(true);
        }

        [Fact(Skip = "Inconclusive")]
        [Trait("Priority","0")]
        public void TestMethod2()
        {}

        [Fact]
        [Trait("Priority","0")]
        public void TestMethod3()
        {
            Assert.True(false);
        }

        [Fact]
        [Trait("Priority","0")]
        public void TestMethod4()
        {
            Assert.True(true);
        }
    }
}
