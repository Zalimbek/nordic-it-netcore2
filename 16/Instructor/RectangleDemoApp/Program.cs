using System;
using RectangleUtility;

namespace RectangleDemoApp
{
	class Program
	{
		static void Main(string[] args)
		{
			var rect1 = new Rectangle<short>(2000, 1000);
			short square = rect1.Calculate(
				(x, y) => checked((short)(x * y)));

			Console.WriteLine(square);
		}
	}
}
