using System;

namespace _01_arithmetic_operators
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("01_arithmetic_operators!");

			Console.WriteLine(11/3);
			Console.WriteLine(11.0 / 3);
			Console.WriteLine(11F / 3);
			Console.WriteLine(11.0 % 3);

			const int a = 100;
			const int b = 17;

			Console.WriteLine(a+b);
			Console.WriteLine(a - b);
			Console.WriteLine(a * b);
			Console.WriteLine(a / b);
			Console.WriteLine(a % b);

			const double c = 48.13;
			const double d = 2.5;

			Console.WriteLine(c + d);
			Console.WriteLine(c - d);
			Console.WriteLine(c * d);
			Console.WriteLine(c / d);
			Console.WriteLine(c % d);

		}
	}
}
