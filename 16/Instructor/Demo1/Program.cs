using System;
using System.Collections.Generic;

namespace Demo1
{
	delegate int GetNumberFromNumbers(int[] numbers);

	class Program
	{
		static void Main(string[] args)
		{
			int[] numbers = new[] { 1, 2, 3 };

			// Custom delegate

			GetNumberFromNumbers method1;

			method1 = Sum;

			Console.WriteLine(method1(numbers));

			// Function delegate

			Func<int[], int> method2;

			method2 = Sum;

			Console.WriteLine(method2(numbers));

			// lambda in delegate

			Func<int, int, int> min1 = Min;
			Console.WriteLine(min1(10, -2));

			Func<int, int, int> min2 = (int a, int b) => Math.Min(a, b);
			Console.WriteLine(min2(10, -2));

			// examples

			string[] inputArray = new[]
			{
				"d",
				"a",
				"0b",
				"0ba",
				"0c"
			};

			//string[] outputArray = Sort(
			//	inputArray,
			//	(a, b) => a[0] < b[0]);

			string[] outputArray = Sort(
				inputArray,
				(a, b) =>
				{
					int count = Math.Min(a.Length, b.Length);
					
					for (int i = 0; i < count; i++)
					{
						if (a[i] == b[i])
							continue;

						return a[i] < b[i];
					}

					return a.Length < b.Length;
				});

			foreach (string line in outputArray)
			{
				Console.WriteLine(line);
			}
		}

		static string[] Sort(string[] inputArray, Func<string, string, bool> firstLessThanSecond)
		{
			string[] array = (string[])inputArray.Clone();

			for (int i = 0; i < array.Length - 1; i++)
			{
				for (int j = 0; j < array.Length - 1 - i; j++)
				{
					if (!firstLessThanSecond(array[j], array[j + 1]))
					{
						string temp = array[j];
						array[j] = array[j + 1];
						array[j + 1] = temp;
					}
				}
			}

			return array;
		}

		static int Min(int a, int b)
		{
			//if (a < b)
			//	return a;
			//else
			//	return b;

			//return a < b ? a : b;

			return Math.Min(a, b);
		}

		static int Sum(int[] items)
		{
			int result = 0;

			foreach (int number in items)
			{
				result += number;
			}

			return result;
		}
	}
}
