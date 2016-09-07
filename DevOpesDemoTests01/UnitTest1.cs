using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DevOpsDemoPrj01;

namespace DevOpsDemoPrj01.Tests
{
    [TestClass()]
    public class UnitTest1
    {
        [TestMethod()]
        public void ShowSumTest()
        {
            Assert.IsFalse(2 == 3);
        }


        [TestMethod]
        public void FailureTest()
        {
            Assert.IsTrue(2 != 3);
        }
    }
}


