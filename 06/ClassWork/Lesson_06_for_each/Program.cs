using System;

namespace Sam_03_for
{
	class Program
	{
		static void Main(string[] args)
		{
			var marks = new[]
			{
				new [] { 2,3,3,2,3},
				new [] {2,4,5,3},
				null,
				new [] { 5,5,5,5},
				new [] {4}
			};

			foreach (int[] array in marks)
			{
				Console.WriteLine(array !=null ? array.Length : -1);
			}
		}
	}
}
