using System;
using Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTests
{
    [TestClass]
    public class CalcMSTests
    {
        Calc calc;

        [TestInitialize()]
        public void Initialize()
        {
            calc = new Calc();
        }

        [TestMethod]
        public void Adding_Two_Numbers_Returns_Correct_Result()
        {
            double a = 1.2, b = 2.3, correctResult = 3.5;
            double result = calc.Add(a, b);
            Assert.AreEqual(result, correctResult);
        }

        [TestMethod]
        public void Subtracting_Two_Numbers_Returns_Correct_Result()
        {
            double a = 9.2, b = 3.1, correctResult = 6.1;
            double result = calc.Subtract(a, b);
            Assert.AreEqual(result, correctResult);
        }

        [TestMethod]
        public void Multiplying_Two_Numbers_Returns_Correct_Result()
        {
            double a = 4.7, b = 7.1, correctResult = 33.37;
            double result = calc.Multiply(a, b);
            Assert.AreEqual(result, correctResult);
        }

        [TestMethod]
        public void Dividing_Two_Numbers_Returns_Correct_Result()
        {
            double a = 6.6, b = 2, correctResult = 3.3;
            double result = calc.Divide(a, b);
            Assert.AreEqual(result, correctResult);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void Dividing_By_Zero_Throw_Divide_By_Zero_Exception()
        {
            double a = 5.4, b = 0;
            double result = calc.Divide(a, b);
        }
    }
}
