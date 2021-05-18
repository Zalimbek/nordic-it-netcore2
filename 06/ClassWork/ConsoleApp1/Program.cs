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
				int i = int.Parse(Console.ReadLine());
				sum += i; // sum=sum+i
			} while (sum < 100);

			Console.WriteLine($"Sum is: {sum}");
		}
	}
}
