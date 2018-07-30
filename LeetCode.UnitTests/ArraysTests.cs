using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.UnitTests
{
    [TestClass]
    public class ArraysTests
    {
        [TestMethod]
        public void MaxProfitTest1()
        {
            Assert.AreEqual(Arrays.MaxProfit(new[] { 4 }), 0);
        }

        [TestMethod]
        public void MaxProfitTest2()
        {
            Assert.AreEqual(Arrays.MaxProfit(new[] { 1, 2, 3, 4, 5 }), 4);
        }

        [TestMethod]
        public void MaxProfitTest3()
        {
            Assert.AreEqual(Arrays.MaxProfit(new[] { 7, 1, 5, 3, 6, 4 }), 7);
        }

        [TestMethod]
        public void MaxProfitTest4()
        {
            Assert.AreEqual(Arrays.MaxProfit(new[] { 7, 6, 4, 3, 1 }), 0);
        }
    }
}
