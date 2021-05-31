using System;
using System.Collections.Generic;

namespace Sam4_stack
{
	class Program
	{
		static void Main(string[] args)
		{
			Stack<string> plates = new Stack<string>();
			do
			{
				Console.WriteLine("Enter wash/dry or exit");
				string str = Console.ReadLine();

				if (str == "wash")
				{
					plates.Push("wash");
					Console.WriteLine(plates.Count);
				}
				else if (str == "dry" & plates.Count>0)
				{
					plates.Pop();
					Console.WriteLine(plates.Count);
				}
				else if (str == "dry" & plates.Count == 0)
				{
					Console.WriteLine("No plates to wash");
				}
				else if (str == "exit")
					break;
			} while (true);
		}
	}
}
