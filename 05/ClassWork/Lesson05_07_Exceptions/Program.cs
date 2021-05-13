using System;

namespace Lesson05_07_Exceptions
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Please enter the number value less than 100");
			string input = Console.ReadLine();
			int num = int.Parse(input);

			if (num>=100)

			{
				var ex = new Exception("The program can't work with value more or equals to 100");
				throw ex;
			}
		}
	}
}
