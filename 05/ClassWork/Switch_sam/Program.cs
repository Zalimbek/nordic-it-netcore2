using System;
using System.Text;

namespace Switch_sam
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.OutputEncoding = Encoding.Unicode;
			Console.InputEncoding = Encoding.Unicode;

			Console.WriteLine("Введите длительность договора аренды в годах: ");
			int arenda=0;
			try
			{
				arenda = int.Parse(Console.ReadLine());
			}
			catch(FormatException e)
			{
				Console.WriteLine($"Вы ввели нецелочисленное значение, код ошибки: {e.HResult}");
				throw;
			}
			catch (OverflowException e)
			{
				Console.WriteLine($"Вы ввели значение вне разрешенного диапазона: {e.HResult}");
				throw;
			}

			if (arenda >30)

			{
				var ex = new Exception("The program can't process the values more than 30");
				throw ex;
			}

			string yearsString = string.Empty;

			switch (arenda)
			{
				case 1:
				case 21:
					yearsString = "год";
					break;
				case 2:
				case 3:
				case 4:
				case 22:
				case 23:
				case 24:
					yearsString = "года";
					break;
				default:
					yearsString = "лет";
					break;
			}

			Console.WriteLine(
				"Договор аренды оформлен на период длительностью "
				+$"{arenda} {yearsString}");
		}
	}
}
