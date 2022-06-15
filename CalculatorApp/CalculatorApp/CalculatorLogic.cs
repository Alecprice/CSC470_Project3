using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorApp
{
	class CalculatorLogic
	{
		public static string Addition(double num1, double num2)
		{
			return (num1 + num2).ToString();
		}

		public static string Subtraction(double num1, double num2)
		{
			return (num1 - num2).ToString();
		}

		public static string Division(double num1, double num2)
		{
			return (num1 / num2).ToString();
		}

		public static string Mutliplication(double num1, double num2)
		{
			return (num1 * num2).ToString();
		}

	}
}
