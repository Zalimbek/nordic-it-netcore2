using System;
using System.Threading;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Please enter the first name:");
			string[] names=new string[3];
			names[0]=Console.ReadLine();
			Console.WriteLine("Please enter the second name:");
			names[1] = Console.ReadLine();
			Console.WriteLine("Please enter the third name:");
			names[2] = Console.ReadLine();
			Console.WriteLine("What is the age of the first person?");
			int[] ages = new int[3];
			ages[0] =int.Parse(Console.ReadLine());
			Console.WriteLine("What is the age of the second person?");
			ages[1] = int.Parse(Console.ReadLine());
			Console.WriteLine("What is the age of the third person?");
			ages[2] = int.Parse(Console.ReadLine());

			for (int i = 0; i < 3; i++)
			{
				Console.WriteLine($"Name: { names[i]}, age in 4 years: {ages[i]+4}");
			}

			Console.ReadKey();
		}
	}
}
