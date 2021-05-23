using System;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			Int64 number = 0;
			int counter = 0;
			int evenCounter = 0;
			string numberStr = string.Empty;

			Console.WriteLine("Enter a positive natural number less or equal 2 mrd: ");
			numberStr = Console.ReadLine();

			try
			{
				number = int.Parse(numberStr);
			}
			catch (FormatException e)
			{
				Console.WriteLine($"Error {e.HResult}. Please try again.");
				throw;
			}
			catch (OverflowException ex)
			{
				Console.WriteLine($"Error {ex.HResult}. Please try again.");
				throw;
			}

			if (number > 2000000000 || number < 1)
			{
				var exception = new Exception("Enter a valid number");
				throw exception;
			}
			else
			{
				string[] digits = new string[numberStr.Length];
				for (int i = 0; i < numberStr.Length; i++)
				{
					digits[i] = numberStr.Substring(counter, 1); // 1 is split length
					if (Convert.ToInt32(digits[i]) % 2 == 0)
					{
						evenCounter++;
					}
					counter++;
				}
				//Int64 individualFactor = 0;
				//Int64 tennerFactor = Convert.ToInt64(Math.Pow(10, numberStr.Length));
				//do
				//{
				//	number -= tennerFactor * individualFactor;
				//	tennerFactor /= 10;
				//	individualFactor = number / tennerFactor;
				//	if (individualFactor % 2 == 0)
				//	{
				//		counter++;
				//	}
				//} while (tennerFactor > 1);
				Console.WriteLine($"The number {numberStr} has {evenCounter} even digits");
			}

		}
	}
}