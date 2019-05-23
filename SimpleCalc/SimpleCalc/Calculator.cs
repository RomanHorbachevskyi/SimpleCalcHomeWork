using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalc
{
	public class Calculator
	{

		//Declare a private backing field for the first number
		private double _number1;

		//Create a public property for the first number
		public double Number1
		{
			get { return _number1; }
			set { _number1 = value; }
		}

		//Declare a private backing field for the second number
		private double _number2;

		//Create a public property for the second number
		public double Number2
		{
			get { return _number2; }
			set { _number2 = value; }
		}

		//Create a method to add the two numbers
		public double Add()
		{
            if (double.IsNaN(Number1) || double.IsNaN(Number2))
            {
                throw new ArgumentException("One of the numbers is not a number.");
            }

            return Number1 + Number2;
		}

		//Create a method to subtract the two numbers
		public double Subtract()
		{
            if (double.IsNaN(Number1) || double.IsNaN(Number2))
            {
                throw new ArgumentException("One of the numbers is not a number.");
            }


            return Number1 - Number2;
        }

		//Create a method to multiply the two numbers
		public double Multiply()
		{
            if (double.IsNaN(Number1) || double.IsNaN(Number2))
            {
                throw new ArgumentException("One of the numbers is not a number.");
            }
            
            return Number1 * Number2;
        }

		//Create a method to divide the two numbers
		public double Divide()
		{
            if (double.IsNaN(Number1) || double.IsNaN(Number2))
            {
                throw new ArgumentException("One of the numbers is not a number.");
            }

            if (Number2==0)
            {
                throw new DivideByZeroException();
            }
            return Number1 / Number2;
        }
	}
}
