using System;
using System.Collections.Generic;

namespace Sam3
{
	class Program
	{
		static void Main(string[] args)
		{
			Queue<int> Queue = new Queue<int>();
			Console.WriteLine("Enter the integer numbers for delayed evaluation of square root");
			Console.WriteLine("(type \"run\" command to run the evaluation or \"exit\" to close the program):");

			while (true)
			{
				string input = Console.ReadLine().ToLower();
				if (input == "run")
				{
					while (Queue.Count > 0)
					{
						int number = Queue.Dequeue();
						Console.WriteLine($"sqrt({number}) = {MathF.Sqrt(number):0.##}");
					}
					continue;
				}
				else if (input == "exit")
				{
					Console.WriteLine($"Number of cancelled tasks in the queue: {Queue.Count}. Cancelling...");
					break;
				}
				Queue.Enqueue(int.Parse(input));
		}
		}
	}
}


