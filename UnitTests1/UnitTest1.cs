using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Factorial.UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void FactorialReturns1ForArgument0()
        {   
            var result = Math.Factorial(0);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void FactorialReturns1ForArgument1()
        {
            var result = Math.Factorial(1);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void FactorialReturns2ForArgument2()
        {
            var result = Math.Factorial(2);
            Assert.AreEqual(2, result);
        }
    }
}
