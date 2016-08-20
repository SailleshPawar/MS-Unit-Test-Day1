using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Arithmetic;

namespace ArithmeticTest
{
    [TestClass]
    public class ArithmeticTests
    {
        [TestMethod]
        public void Test_Addition()
        {
            //Arrange- Arrange the requirement
            int expectedSum = 20;
            ArithmeticOperations arithmetic = new ArithmeticOperations();
            arithmetic.FirstNumber = 10;
            arithmetic.SecondNumber = 20;
            //Act--Invoke the code that is needed to be tested
            int actualSum =arithmetic.Addition(arithmetic.FirstNumber, arithmetic.SecondNumber);
            //Assert- Expectation compared with actual result
           Assert.AreEqual(expectedSum, actualSum);
        }
    }
}
