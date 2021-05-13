using System;

namespace Lesson05_03_ternary_operator
{
	class Program
	{
		static void Main(string[] args)
		{
			//int a = 0;
			//if (DateTime.Now.Minute > 10)
			//{
			//	a = 3;
			//}
			//else
			//{
			//	a = 15;
			//}

			//a = (DateTime.Now.Minute > 10)
			//	? 3
			//	: 15;


			Console.WriteLine("Enter the number from 0 to 100: ");
			int number;

			try
			{
				number = int.Parse(Console.ReadLine());
			}
			catch (Exception e)
			{
				Console.WriteLine($"Вы ввели значение вне разрешенного диапазона: {e.HResult}");
				throw;
			}

			Console.WriteLine(
				(number<50)
				? "Enter the number greater than 50"
				: "The entered number is greater or equal 50");
		}
	}
}
