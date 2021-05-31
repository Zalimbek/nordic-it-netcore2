using System;
using System.Diagnostics;

namespace Lesson09_bubble_sorting
{
	class Program
	{
		static void Main(string[] args)
		{
			const int arraylength = 1000;
			const int MaxValue = int.MaxValue;

			for (int i = 1; i < 11; i++)

			{
				var sw = new Stopwatch();

				int[] arr = GetSourceArray(i*arraylength, MaxValue);

				//WriteArray(arr);
				//Console.WriteLine(DateTimeOffset.Now.ToString("hh:mm:ss.fffffff"));

				sw.Start();
				int[] bubbleSortArray = BubbleSort(arr);

				BubbleSort(arr);
				sw.Stop();
				long bubbleMs = sw.ElapsedMilliseconds;
				sw.Reset();

				sw.Start();
				int[] DotNetsortArray = DoNotSort(arr);
				sw.Stop();
				long dotNetMs = sw.ElapsedMilliseconds;


				Console.WriteLine($"Bubble:{bubbleMs}ms\t\t.NET: {dotNetMs}ms");
			}
			//Console.WriteLine(DateTimeOffset.Now.ToString("hh:mm:ss.fffffff")); //посчитать сколько времени занимает наш расчет
			//WriteArray(arr);
		}

		static int[] DoNotSort(int[] arr)
		{
			var result = (int[])arr.Clone();
			Array.Sort(result);
			return result;

		}
		static int[] BubbleSort(int[] arr)
		{
			//var result = new int[arr.Length];
			//arr.CopyTo(result,0);

			var result = (int[])arr.Clone();

			for (int j = 0; j < result.Length - 1; j++)
			{
				for (int i = 0; i < result.Length - 1-j; i++)
				{
					if (result[i] > result[i + 1])
					{
						int temp = result[i + 1];
						result[i + 1] = result[i];
						result[i] = temp;
					}
				}
			}
			return result;
		}
		static void WriteArray(int[] array)
		{
			Console.WriteLine(string.Join(", ", array));
		}

		static int[] GetSourceArray(int length, int MaxValue)
		{
			int[] arr = new int[length];

			var rnd = new Random();
			for (int i = 0; i < arr.Length; i++)
			{
				arr[i] = rnd.Next(MaxValue);
			}
			return arr;
		}
		
		// Сложность N^2
		
	}
}
