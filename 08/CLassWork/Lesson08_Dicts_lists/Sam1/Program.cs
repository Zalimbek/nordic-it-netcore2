using System;
using System.Collections.Generic;

namespace Sam1
{
	class Program
	{
		static void Main(string[] args)
		{
			var doubleList = new List<double>();
			string input;

			do
			{
				Console.Write("Enter the value in double format: ");
				input = Console.ReadLine();
				if (input == "stop")
					break;
				try
				{
					doubleList.Add(double.Parse(input));
				}
				catch
				{
					Console.WriteLine("Wrong Input");
					throw;
				}
			} while (true);

				int i = 0;
				double sum = 0;
				foreach (double element in doubleList)
				{
					sum +=element;
					i++;
				}
				Console.WriteLine($"Sum= {sum}, average={sum / i}");

			}
	}
	}
