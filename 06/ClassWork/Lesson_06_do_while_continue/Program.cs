using System;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			int sum = 0;

			Console.WriteLine("Enter integer values");
			do
			{
				int i;

				try
				{
					i = int.Parse(Console.ReadLine());
				}
				catch (Exception)
				{
					Console.WriteLine("Wrong input value");
					continue;
				}
				sum += i; // sum=sum+i
			} while (sum < 100);

			Console.WriteLine($"Sum is: {sum}");
		}
	}
}
