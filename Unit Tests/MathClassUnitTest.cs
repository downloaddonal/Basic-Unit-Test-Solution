using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Basic_Calculator;

namespace Unit_Tests
{
    [TestClass]
    public class MathClassUnitTest
    {
        private const int num_A = 10;
        private const int num_B = 3;

        [TestMethod]
        public void TestAdd()
        {
            int expectedResult = num_A + num_B;
            int actualResult = MathClass.AddTwoNumbers(num_A, num_B);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestSubtract()
        {
            int expectedResult = num_A - num_B;
            int actualResult = MathClass.SubtractTwoNumbers(num_A, num_B);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMultiply()
        {
            int expectedResult = num_A * num_B;
            int actualResult = MathClass.MultiplyTwoNumbers(num_A, num_B);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestDivide()
        {
            int expectedResult = num_A / num_B;
            int actualResult = MathClass.DivideTwoNumbers(num_A, num_B);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
