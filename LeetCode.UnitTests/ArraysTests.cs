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
            Assert.AreEqual(0, Arrays.MaxProfit(new[] { 4 }));
        }

        [TestMethod]
        public void MaxProfitTest2()
        {
            Assert.AreEqual(4, Arrays.MaxProfit(new[] { 1, 2, 3, 4, 5 }));
        }

        [TestMethod]
        public void MaxProfitTest3()
        {
            Assert.AreEqual(7, Arrays.MaxProfit(new[] { 7, 1, 5, 3, 6, 4 }));
        }

        [TestMethod]
        public void MaxProfitTest4()
        {
            Assert.AreEqual(0, Arrays.MaxProfit(new[] { 7, 6, 4, 3, 1 }));
        }

        [TestMethod]
        public void ContainsDuplicateTest1()
        {
            Assert.AreEqual(false, Arrays.ContainsDuplicate(new int[0]));
        }

        [TestMethod]
        public void ContainsDuplicateTest2()
        {
            Assert.AreEqual(false, Arrays.ContainsDuplicate(new[] { 1 }));
        }

        [TestMethod]
        public void ContainsDuplicateTest3()
        {
            Assert.AreEqual(true, Arrays.ContainsDuplicate(new[] { 1, 2, 1 }));
        }

        [TestMethod]
        public void ContainsDuplicateTest4()
        {
            Assert.AreEqual(false, Arrays.ContainsDuplicate(new[] { 7, 6, 4, 3, 1 }));
        }
    }
}
