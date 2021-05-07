using System;

namespace _09_Colors_Example
{
	[Flags]
	enum Color : Int32
	{
		None = 0,
		Black = 1,
		Blue = 2,
		Cyan = 4,
		Grey = 8,
		Green = 16,
		Magenta = 32,
		Red = 64,
		White =128,
		Yellow=256
	};
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter the number of your first favourite color out of these\n" +
				"Black=1, Blue=2, Cyan=4, Grey=8, Green=16, Magenta=32, Red=64, White=128, Yellow=256: ");
			var col1 = Int32.Parse(Console.ReadLine());

			Console.WriteLine("Enter the number of your first favourite color out of these\n" +
				"Black=1, Blue=2, Cyan=4, Grey=8, Green=16, Magenta=32, Red=64, White=128, Yellow=256: ");
			var col2 = Int32.Parse(Console.ReadLine());

			Console.WriteLine("Enter the number of your first favourite color out of these\n" +
				"Black=1, Blue=2, Cyan=4, Grey=8, Green=16, Magenta=32, Red=64, White=128, Yellow=256: ");
			var col3 = Int32.Parse(Console.ReadLine());

			Console.WriteLine("Enter the number of your first favourite color out of these\n" +
				"Black=1, Blue=2, Cyan=4, Grey=8, Green=16, Magenta=32, Red=64, White=128, Yellow=256: ");
			Console.WriteLine();
			var col4 = Int32.Parse(Console.ReadLine());

			Color favColor = (Color)col1+col2+col3+col4;
			Console.WriteLine(favColor);

			Color allColors=(Color).511;
			Color notFav = allColors ^ favColor;
			Console.WriteLine(notFav);
		}
	}
}
