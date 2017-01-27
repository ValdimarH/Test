using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectLibrary;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestMethod()
        {
            int sum = Class1.multiplyNumbers(10, 100);
            Assert.AreEqual(sum, 1000);
        }
    }
}
