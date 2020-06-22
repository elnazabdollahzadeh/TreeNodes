using System;
using CSharpTree;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CalculateSumOfNodesReturn598()
        {

            int expectedResult = 598; // some of all node data

            int Result = SampleIterating.GetSum();

            Assert.AreEqual(expectedResult, Result);
        }
    }
}
