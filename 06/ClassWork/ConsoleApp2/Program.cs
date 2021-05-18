using System;

namespace Lesson_06_for_pifagor
{
	class Program
	{
		static void Main(string[] args)
		{
			const int startX = -1;
			const int endX = 5;

			const int startY = -3;
			const int endY = 3;

			for (int i = startX; i < endX; i++)
			{
				for (int j = startY; j < endY; j++)
				{
					Console.Write($"{i*j}".PadRight(6));
				}
				Console.WriteLine();
			}
		}
	}
}
