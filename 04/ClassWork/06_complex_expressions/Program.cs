using System;

namespace _06_complex_expressions
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("06_complex_expressions!");
			//double a = 3;
			//double b = 4;
			//double c = Math.Sqrt(a * a + Math.Pow(b, 2));
			//Console.WriteLine(c);

			//double a = 1;
			//double h = 2.5;
			//double n = 6;
			//Console.WriteLine(n*a/2*(a/(2*Math.Tan(Math.PI/n))+Math.Sqrt(h*h+Math.Pow(a/(2*Math.Tan(Math.PI/2)),2))));

			

			Console.WriteLine("Enter a:");
			var a = double.Parse(Console.ReadLine());

			Console.WriteLine("Enter n:");
			var n = double.Parse(Console.ReadLine());

			Console.WriteLine("Enter h:");
			var h = double.Parse(Console.ReadLine());

			var X = Math.Tan(Math.PI / n);

			var y = a / (2 * X);

			var Sbok = (n * a / 2) * Math.Sqrt(h * h + y * y);
			Console.WriteLine(Sbok);

			var Spol = (n * a / 2) * (y + Math.Sqrt(h * h + y * y));
			Console.WriteLine(Spol);

		}
	}
}
