using System;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter any word (exit to exit):");
			do
			{
				string word = Console.ReadLine();
				if (word=="exit")
				{
					break;
				}
				
				if (word.Length<=15)
				{
					Console.WriteLine($"The entered word has the following length: {word.Length}");
					continue;
				}

				Console.WriteLine("The word is too long, please try again");
			} while (true);
		}
	}
}

