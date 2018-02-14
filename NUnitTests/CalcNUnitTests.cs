using Calculator;
using NUnit.Framework;
using System;

namespace NUnitTests
{
    [TestFixture]
    class CalcNUnitTests
    {
        Calc calc;

        [SetUp]
        protected void SetUp()
        {
            calc = new Calc();
        }

        [Test]
        public void Adding_Two_Numbers_Returns_Correct_Result()
        {
            double a = 1.2, b = 2.3, correctResult = 3.5;
            double result = calc.Add(a, b);
            Assert.AreEqual(result, correctResult);
        }

        [Test]
        public void Subtracting_Two_Numbers_Returns_Correct_Result()
        {
            double a = 9.2, b = 3.1, correctResult = 6.1;
            double result = calc.Subtract(a, b);
            Assert.AreEqual(result, correctResult);
        }

        [Test]
        public void Multiplying_Two_Numbers_Returns_Correct_Result()
        {
            double a = 4.7, b = 7.1, correctResult = 33.37;
            double result = calc.Multiply(a, b);
            Assert.AreEqual(result, correctResult);
        }

        [Test]
        public void Dividing_Two_Numbers_Returns_Correct_Result()
        {
            double a = 6.6, b = 2, correctResult = 3.3;
            double result = calc.Divide(a, b);
            Assert.AreEqual(result, correctResult);
        }

        [Test]
        public void Dividing_By_Zero_Throw_Divide_By_Zero_Exception()
        {
            double a = 5.4, b = 0;
            var ex = Assert.Throws<DivideByZeroException>(() => calc.Divide(a, b));
            StringAssert.Contains("Nie można dzielić przez zero!!!", ex.Message);
        }
    }
}
