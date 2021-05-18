using System;

namespace Lesson_06_while
{
	class Program
	{
		static void Main(string[] args)
		{
			float[] numbers = { -1.5F, 2.32F, 17.21F, -2F };
			float sum = 0;
			int i = 0;
			while (i<4)
		
			{
					sum += numbers[i++];
				//i++;
					Console.WriteLine($"The sum of numbers is {sum}");
			} 
		}
	}
}
