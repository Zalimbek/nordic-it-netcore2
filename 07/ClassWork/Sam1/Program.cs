using System;

namespace Sam1
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter two real numbers to multiply them: ");
			var d1 = double.Parse(Console.ReadLine());
			var d2 = double.Parse(Console.ReadLine());

			Console.WriteLine(
				d1.ToString("0.#") + "*" + d2.ToString("0.#") + "=" + (d1 * d2).ToString("0.#"));

			Console.WriteLine("{0:0.##}+{1:0.##}={2:0.##}",d1,d2,d1+d2);
			Console.WriteLine($"{d1:#.##}-{d2:#.##}={d1-d2:#.##}");
		}
	}
}
