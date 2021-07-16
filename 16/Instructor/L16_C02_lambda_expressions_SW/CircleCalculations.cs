using System;
using System.Collections.Generic;
using System.Text;

namespace L16_C02_lambda_expressions_SW
{
	static class CircleCalculations
	{
		public static double Perimeter(double radius)
		{
			return 2 * Math.PI * radius;
		}

		public static double Square(double radius)
		{
			return Math.PI * radius * radius;
		}
	}
}
