using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace SimpleCalc
{
	[TestFixture]
	public class CalculatorTests
    {
        private Calculator calc;

        [SetUp]
        public void SetNewCalc()
        {
            calc = new Calculator();
        }

        
        [TestCase(0,0, 0)]
        [TestCase(1.5,1.5,3.0)]
        public void AddTwoDoubles_GetDouble(double number1, double number2, double expectedResult)
        {
            calc.Number1 = number1;
            calc.Number2 = number2;

            var result = calc.Add();

            Assert.AreEqual(expectedResult,result);
        }

        [TestCase(double.NaN, double.NaN)]
        [TestCase(double.NaN, 1.0)]
        [TestCase(1.0, double.NaN)]
        public void AddNotANumber_GetArgumentException(double number1, double number2)
        {
            calc.Number1 = number1;
            calc.Number2 = number2;

            Assert.Throws<ArgumentException>(() => calc.Add());
        }


        [TestCase(0, 0, 0)]
        [TestCase(1.5, 1.5, 0)]
        public void SubtractTwoDoubles_GetDouble(double number1, double number2, double expectedResult)
        {
            calc.Number1 = number1;
            calc.Number2 = number2;

            var result = calc.Subtract();

            Assert.AreEqual(expectedResult, result);
        }

        [TestCase(double.NaN, double.NaN)]
        [TestCase(double.NaN, 1.0)]
        [TestCase(1.0, double.NaN)]
        public void SubtractNotANumber_GetArgumentException(double number1, double number2)
        {
            calc.Number1 = number1;
            calc.Number2 = number2;

            Assert.Throws<ArgumentException>(() => calc.Subtract());
        }


        [TestCase(0, 0, 0)]
        [TestCase(1.5, 1.5, 2.25)]
        public void MultiplyTwoDoubles_GetDouble(double number1, double number2, double expectedResult)
        {
            calc.Number1 = number1;
            calc.Number2 = number2;

            var result = calc.Multiply();

            Assert.AreEqual(expectedResult, result);
        }

        [TestCase(double.NaN, double.NaN)]
        [TestCase(double.NaN, 1.0)]
        [TestCase(1.0, double.NaN)]
        public void MultiplyNotANumber_GetArgumentException(double number1, double number2)
        {
            calc.Number1 = number1;
            calc.Number2 = number2;

            Assert.Throws<ArgumentException>(() => calc.Multiply());
        }


        [TestCase(0, 1, 0)]
        [TestCase(1.5, 1.5, 1)]
        public void DivideTwoDoubles_GetDouble(double number1, double number2, double expectedResult)
        {
            calc.Number1 = number1;
            calc.Number2 = number2;

            var result = calc.Divide();

            Assert.AreEqual(expectedResult, result);
        }

        [TestCase(double.NaN, double.NaN)]
        [TestCase(double.NaN, 1.0)]
        [TestCase(1.0, double.NaN)]
        public void DivideNotANumber_GetArgumentException(double number1, double number2)
        {
            calc.Number1 = number1;
            calc.Number2 = number2;

            Assert.Throws<ArgumentException>(() => calc.Divide());
        }


        [TestCase(0, 0)]
        [TestCase(1.5, 0)]
        public void Divide_GetDivideByZeroException(double number1, double number2)
        {
            calc.Number1 = number1;
            calc.Number2 = number2;
            
            Assert.Throws<DivideByZeroException>(()=>calc.Divide());
        }
    }
}
