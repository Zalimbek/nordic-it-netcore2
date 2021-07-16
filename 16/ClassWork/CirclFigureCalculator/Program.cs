using System;

namespace FigureCalculator
{

	class Program
	{

		static void Main(string[] args)
		{
			double radius = 1.5;
			var circle1 = new Circle.Core.Circle(radius);
			//Console.WriteLine($"For the circle with radius {radius}");
			//Console.WriteLine("Perimetr: " + circle1.GetPerimetr(radius));
			//Console.WriteLine("Square: " + circle1.GetSquare(radius));

			//Console.WriteLine(circle1.Calculate(circle1.GetPerimetr));
			//Console.WriteLine(circle1.Calculate(circle1.GetSquare));

			Console.WriteLine(circle1.Calculate(x => 2 * Math.PI * x));
			Console.WriteLine(circle1.Calculate(x => 2 * Math.PI * x));
			Console.WriteLine(circle1.Calculate(x => 2 * radius));

		}
	}
}
