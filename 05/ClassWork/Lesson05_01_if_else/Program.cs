using System;

namespace Lesson05_01_if_else
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Press any key");
			char c = Console.ReadKey(true).KeyChar;

			if (char.IsLetter(c))
			{
				Console.WriteLine("You entered a letter");
			}
			else if (char.IsDigit(c))
			{
				Console.WriteLine("You entered a digit");
			}
			else if (char.IsPunctuation(c))
			{
				Console.WriteLine("You entered a punctuation sign");
			}
			else
			{
				Console.WriteLine("You entered a strange key");
			}

		}
	}
}
