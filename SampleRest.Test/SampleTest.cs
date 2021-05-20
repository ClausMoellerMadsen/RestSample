using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace SampleRest.Test
{
    [TestClass]
    public class SampleTest
    {
        [TestMethod]

        public void FailingTest()
        {
            Assert.IsTrue(false);
        }
        [TestMethod]

        public void WorkingTest()
        {
            Assert.IsTrue(true);
        }
    }
}
