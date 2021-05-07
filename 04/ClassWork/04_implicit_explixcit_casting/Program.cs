using System;

namespace _04_implicit_explixcit_casting
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("04_implicit_explicit_casting");

			//implicit casting examples
			int a = 10;
			double b = a;

			var c = a + 0.1F;

			double g = 9.81;
			// int g2 = g; error

			//explicit casting

			int g2 = (int)g;
			Console.WriteLine(g);
			Console.WriteLine(g2);

			long e = 10;
			int f;
			checked
			{
				f = (int)e;

			}

			Console.WriteLine(e);
			Console.WriteLine(f);


		}
	}
}
