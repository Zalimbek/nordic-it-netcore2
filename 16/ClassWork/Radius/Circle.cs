using System;
using System.Collections.Generic;
using System.Text;

namespace Radius
{
	public sealed class Circle
	{
		private double _radius;
		public Circle(double radius)
		{
			_radius = radius;
		}
		public double Calculate (Func<double, double> operation)
		{ 
			return operation(_radius);
		}

		public double GetSquare(double radius)
		{
			return Math.PI * radius*radius;
		}

		public double GetPerimetr(double radius)
		{
			return 2*Math.PI * radius;
		}
	}
}
