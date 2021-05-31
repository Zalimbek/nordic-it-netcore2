using System;
using System.Collections.Generic;

namespace Lesson08_queue
{
	class Program
	{
		static void Main(string[] args)
		{
			Queue<int> integerQueue = new Queue<int>();

			integerQueue.Enqueue(1);
			integerQueue.Enqueue(2);
			integerQueue.Enqueue(3);

			while (true)
			{
				if (integerQueue.Count == 0)
					break;
				int elementToProcess = integerQueue.Dequeue();
				Console.WriteLine($"elementToProcess={ elementToProcess}");
				Console.WriteLine($"integerQueue.Count={ integerQueue.Count}");
			}
		}
	}
}
