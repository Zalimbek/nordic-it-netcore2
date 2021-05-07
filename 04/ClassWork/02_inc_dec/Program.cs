using System;

namespace _02_inc_dec
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("02_inc_dec");

			int a = 0;
			int b = 0;

			Console.WriteLine(a++);
			Console.WriteLine(++b);

			Console.WriteLine(a);
			Console.WriteLine(b);

			var c = 15;
			var d = c++; //d=15, c=16
						 //var d = ++c;

			var x = 0;
			var y = x--; //y=0, x=-1
			var z = --x;// z=-2, x=-2
		}
	}
}
