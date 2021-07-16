﻿using System;

namespace Radius
{
	class Program
	{
		private static void Main(string[] args)
		{
			const double circleRadius = 1.5;

			var circle = new Circle(circleRadius);

			Console.WriteLine(circle.Calculate(r => 2 * Math.PI * r));
			Console.WriteLine(circle.Calculate(r => Math.PI * r * r));
			Console.WriteLine(circle.Calculate(r => 2 * r));
		}
	}
}
