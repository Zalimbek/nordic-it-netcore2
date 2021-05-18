using System;

namespace Lesson_06_foreach_crypto
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter text to crypt: ");
			string source = Console.ReadLine();

			Console.WriteLine("Enter shift crypto key: ");
			char key = Console.ReadKey().KeyChar;
		
			Console.Write("Encrypted string:");

			foreach(char letter in source)
			{
				Console.Write((char)letter+key);
			}
			Console.WriteLine();

		}
	}
}
