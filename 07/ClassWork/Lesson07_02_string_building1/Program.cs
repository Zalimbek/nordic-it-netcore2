using System;

namespace Lesson07_02_string_building1
{
	class Program
	{
		static void Main(string[] args)
		{
			string hello = "Hello";
			string world = "World";
			//Console.WriteLine(hello+" "+world+"!");

			// String format method
			string welcomeStringTemplate = "Hello {0}\nWelcome to {1}!";
			Console.WriteLine(
				string.Format(welcomeStringTemplate, "Andrei", "Hell"));

			Console.WriteLine(
				string.Format(
					welcomeStringTemplate, "World", "Space"));

			// format values
			float[] distances = { 1.0F, -21.536F, 0.021F };

			foreach (float distance in distances)
			{
				Console.WriteLine(string.Format("Distance is {0:#.##}", distance));
				Console.WriteLine(string.Format("Distance is {0:0.0#}", distance));
				Console.WriteLine(string.Format("Distance is {0:0.00}", distance));
			}
				DateTimeOffset[] dates = { DateTimeOffset.MinValue, DateTimeOffset.Now, DateTimeOffset.MaxValue };

			foreach (var date in dates)
			{
				Console.WriteLine(string.Format("date is {0:dd.MM.yyyy HH:mm:ss.ffffff}", date));
				Console.WriteLine(string.Format("date is {0:MMM-dd (dddd)}", date));
				Console.WriteLine(string.Format("date is {0:t}", date));

				// interpolation
				double i = 431.2131;
				double j = 321.2111;

				Console.WriteLine($"{i:0.00} / {j:0.00}={i/j:0.00}");
			}
		}
	}
}
