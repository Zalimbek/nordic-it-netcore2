using System;

namespace _03_comparison
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("03_comparison");

			Console.WriteLine(10>15);
			Console.WriteLine(10<=15);
			Console.WriteLine(10!=15);
			Console.WriteLine("10"=="10");
			Console.WriteLine('1'=='0');

			var a = 18;
			var b = a++;

			Console.WriteLine(a);
			Console.WriteLine(b);
			Console.WriteLine(a==b);
			Console.WriteLine(a!=b);
			Console.WriteLine(a>b);
			Console.WriteLine(a<b);
			Console.WriteLine(a>=b);
			Console.WriteLine(a<=b);
		}
	}
}
