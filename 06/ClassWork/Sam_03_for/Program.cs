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
			

			for (int i = 0; i < marks.Length; i++)
			{
				float sum = 0;
				double? avg = null;
				if (marks[i]!=null)
				{
					for (int j = 0; j < marks[i].Length; j++)
					{
						sum += marks[i][j];
						avg = Math.Round(sum / marks[i].Length, 1);
					}
					Console.WriteLine($"The average mark for day #{i} is {avg}");
				}
				else
				Console.WriteLine($"The average mark for day #{i} is"+ (avg.HasValue 
					? avg.ToString() 
					: " N/A"));
			}
			
		}
	}
}
