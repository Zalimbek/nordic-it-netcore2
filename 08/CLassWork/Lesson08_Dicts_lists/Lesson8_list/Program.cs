using System;
using System.Collections.Generic;

namespace Lesson8_list
{
	class Program
	{
		static void Main(string[] args)
		{
			var intArray = new[] { 1, 2, 3 };
			var intList = new List<int> { 1, 2, 3 };

			intList.Add(4);
			intList.AddRange(intArray);


			intList.Insert(3, 10);
			intList.Sort();

			Console.WriteLine(string.Join(',', intList));

		}
	}
}
