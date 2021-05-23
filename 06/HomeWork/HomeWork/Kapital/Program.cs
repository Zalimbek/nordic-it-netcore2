using System;
using System.Text;

namespace Kapital
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.OutputEncoding = Encoding.Unicode;
			Console.InputEncoding = Encoding.Unicode;
			float vznos = 0;
			float prozent = 0;
			float nakoplenie = 0;
			float nakoplenieCurrent = 0;
			int counter = 0;

			Console.WriteLine("Введите сумму первоначального взноса в рублях: ");
			try
			{
				vznos = float.Parse(Console.ReadLine());
			}
			catch (FormatException)
			{
				Console.WriteLine("Вы ввели значение неверного формата");
				throw;
			}
			Console.WriteLine("Введите ежедневный процент дохода в виде десятичной дроби(1 % = 0,01):");
			try
			{
				prozent = float.Parse(Console.ReadLine());
			}
			catch (FormatException)
			{
				Console.WriteLine("Вы ввели значение неверного формата");
				throw;
			}
			if (prozent < 0)
			{
				Console.WriteLine("Процент не может быть отрицательным числом ");
			}
			else
			{
				Console.WriteLine("Введите желаемую сумму накопления в рублях: ");
				try
				{
					nakoplenie = float.Parse(Console.ReadLine());
				}
				catch (FormatException)
				{
					Console.WriteLine("Вы ввели значение неверного формата");
					throw;
				}
				nakoplenieCurrent = vznos;
				do
				{
					nakoplenieCurrent = nakoplenieCurrent + nakoplenieCurrent * prozent;
					counter++;
				} while (nakoplenieCurrent < nakoplenie);
				Console.WriteLine($"Необходимое количество дней для накопления желаемой суммы: {counter}");
			}

		}
	}
}
