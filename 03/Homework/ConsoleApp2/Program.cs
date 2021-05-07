using System;
using System.Text;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			// m - # of columns; n - # of rows
			Console.WriteLine("Enter number of columns:");
			int m = int.Parse(Console.ReadLine());
			Console.WriteLine("Enter number of rows:");
			int n = int.Parse(Console.ReadLine());
			int[] columns = new int[m];
			int[] rows = new int[n];

			for (int i = 0; i < m; i++)
			{
				columns[i] = i + 1;
				Console.WriteLine($"Column: { columns[i]}");
			}

			for (int j = 0; j < n; j++)
			{
				rows[j] = j + 1;
				Console.WriteLine($"Row: { rows[j]}");
			}
			string Tabl = "";

			for (int i = 0; i < columns.Length; i++)
			{
				for (int j = 0; j < rows.Length; j++)
				{
					Tabl += "\t" + columns[i] * rows[j];
				}
				Tabl += "\n";
			}

			Console.WriteLine(Tabl);
			Console.ReadKey();
		}
	}
}
