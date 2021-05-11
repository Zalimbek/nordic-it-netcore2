using System;

namespace _05_rounding
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("05_rounding!");

			double i = 9.49;
			double j = 9.5;
			double k = 10.49;
			double l = 10.5;
			double m = 1.4;

			Console.WriteLine(Convert.ToInt32(i));
			Console.WriteLine(Convert.ToInt32(j));
			Console.WriteLine(Convert.ToInt32(k));
			Console.WriteLine(Convert.ToInt32(l));
			Console.WriteLine(Convert.ToInt32(m));

			double f=Math.Round(m,0);
			Console.WriteLine(f);

			double z = 0.15;
			Console.WriteLine(Math.Floor(z));
			Console.WriteLine(Math.Ceiling(z));
		}
	}
}
