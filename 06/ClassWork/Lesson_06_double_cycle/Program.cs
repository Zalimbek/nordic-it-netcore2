using System;

namespace Lesson_06_double_cycle
{
	class Program
	{
		static void Main(string[] args)
		{
			do
			{

				bool Ok = true;
				int a = 0;
				bool externalExit = false;
				do
				{
					try
					{
						Console.WriteLine("Enter a number: ");
						a = int.Parse(Console.ReadLine());

						if (a<0)
						{
							externalExit = true;
							break;
						}
					}
					catch
					{
						continue;
					}
					break;
				} while (true);
				if (externalExit)
					break;

				Console.WriteLine($"{a}*{a}={a * a}");
				Console.WriteLine("Enter continue");
			} while (Console.ReadLine() == "continue");
			Console.WriteLine("The end");


			//int b;
			//do
			//{
			//	Console.WriteLine("Enter b number:");
			//	try
			//}

		}
	}
}

