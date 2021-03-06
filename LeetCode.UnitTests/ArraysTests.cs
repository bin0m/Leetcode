﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

        [TestMethod]
        public void RotateTest1()
        {
            var emptyArr = new  int[0];
            Arrays.Rotate(emptyArr, 2);
            CollectionAssert.AreEqual(new int[0], emptyArr);
        }

        [TestMethod]
        public void RotateTest2()
        {
            var sampleArr = new[] { 1 };
            Arrays.Rotate(sampleArr, 1);
            CollectionAssert.AreEqual(new[] { 1 }, sampleArr);
        }

        [TestMethod]
        public void RotateTest3()
        {
            var sampleArr = new[] { 1 };
            Arrays.Rotate(sampleArr, 4);
            CollectionAssert.AreEqual(new[] { 1 }, sampleArr);
        }

        [TestMethod]
        public void RotateTest4()
        {
            var sampleArr = new[] { 1, 2 };
            Arrays.Rotate(sampleArr, 0);
            CollectionAssert.AreEqual(new[] { 1, 2 }, sampleArr);
        }

        [TestMethod]
        public void RotateTest5()
        {
            var sampleArr = new[] { 1, 2 };
            Arrays.Rotate(sampleArr, 1);
            CollectionAssert.AreEqual(new[] { 2, 1 }, sampleArr);
        }

        [TestMethod]
        public void RotateTest6()
        {
            var sampleArr = new[] { 1, 2 };
            Arrays.Rotate(sampleArr, 4);
            CollectionAssert.AreEqual(new[] { 1, 2 }, sampleArr);
        }

        [TestMethod]
        public void RotateTest7()
        {
            var sampleArr = new[] { 1, 2 };
            Arrays.Rotate(sampleArr, 5);
            CollectionAssert.AreEqual(new[] { 2, 1 }, sampleArr);
        }

        [TestMethod]
        public void RotateTest8()
        {
            var sampleArr = new[] { 1, 2, 3 };
            Arrays.Rotate(sampleArr, 4);
            CollectionAssert.AreEqual(new[] { 3, 1, 2 }, sampleArr);
        }

        [TestMethod]
        public void RotateTest9()
        {
            var sampleArr = new[] { 1, 2, 3 };
            Arrays.Rotate(sampleArr, 5);
            CollectionAssert.AreEqual(new[] { 2, 3, 1 }, sampleArr);
        }

        [TestMethod]
        public void SingleNumberTest1()
        {
            Assert.AreEqual(1, Arrays.SingleNumber(new[] { 1 }));
        }

        [TestMethod]
        public void SingleNumberTest2()
        {
            Assert.AreEqual(0, Arrays.SingleNumber(new[] { 1, 1 }));
        }

        [TestMethod]
        public void SingleNumberTest3()
        {
            Assert.AreEqual(2, Arrays.SingleNumber(new[] { 1, 2, 1 }));
        }

        [TestMethod]
        public void SingleNumberTest4()
        {
            Assert.AreEqual(3, Arrays.SingleNumber(new[] { 1, 2, 1, 3, 2 }));
        }

        [TestMethod]
        public void SingleNumberTest5()
        {
            Assert.AreEqual(4, Arrays.SingleNumber(new[] { 4, 1, 2, 1, 3, 2, 3 }));
        }

        [TestMethod]
        public void TwoSumTest1()
        {
            CollectionAssert.AreEqual(new []{0,1}, Arrays.TwoSum(new []{1,2}, 3));
        }

        [TestMethod]
        public void TwoSumTest2()
        {
            CollectionAssert.AreEqual(new[] { -1, -1 }, Arrays.TwoSum(new[] { 1, 2 }, 2));
        }

        [TestMethod]
        public void TwoSumTest3()
        {
            CollectionAssert.AreEqual(new[] { -1, -1 }, Arrays.TwoSum(new[] { 1, -3 }, 1));
        }

        [TestMethod]
        public void TwoSumTest4()
        {
            CollectionAssert.AreEqual(new[] { 1, 2 }, Arrays.TwoSum(new[] { 1, -3, 2 }, -1));
        }

        [TestMethod]
        public void TwoSumTest5()
        { 
            CollectionAssert.AreEqual(new[] { 0, 4 }, Arrays.TwoSum(new[] { 1, -3, 2, 4, 3}, 4));
        }

        [TestMethod]
        public void FourSumTest1()
        {
            var result = Arrays.FourSum(new[] {0, 1, 2, 3}, 6);
            CollectionAssert.AreEquivalent(new List<int> { 0, 1, 2, 3 }, new Collection<int>(result[0]));
        }

        [TestMethod]
        public void FourSumTest2()
        {
            var result = Arrays.FourSum(new[] { -3, 0, 1, 2, 3, 4 }, 2);
            CollectionAssert.AreEquivalent(new List<int> { -3, 0, 1, 4 }, new Collection<int>(result[0]));
        }
    }
}
