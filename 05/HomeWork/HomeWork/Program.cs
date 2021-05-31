using System;
using System.Text;

namespace HomeWork
{
	enum Figure : int
	{
		Circle = 1,
		Triangle = 2,
		Rectangle = 3
	}
	class Program
	{
		static void Main(string[] args)
		{
			Console.InputEncoding = Encoding.Unicode;
			Console.OutputEncoding = Encoding.Unicode;

			Console.WriteLine(" Введите тип фигуры (1 круг, 2 равносторонний треугольник, 3 прямоугольник): ");
			int figureType = 0;
			double S = 0;
			double P = 0;

			try
			{
				figureType = int.Parse(Console.ReadLine());
			}
			catch (FormatException e)
			{
				Console.WriteLine("Ошибка! Введено нечисловое значение!");
				throw;
			}
			catch (OverflowException)
			{
				Console.WriteLine("Вы ввели неверное значение");
				throw;
			}

			if (figureType == (int)Figure.Circle)
			{
				Console.WriteLine("Введите диаметр круга: ");
				float diametr = 0;

				try
				{
					diametr = float.Parse(Console.ReadLine());
				}
				catch (FormatException e)
				{
					Console.WriteLine("Ошибка! Введено нечисловое значение!");
					throw;
				}

				S = Math.Round(Math.PI * Math.Pow(diametr / 2, 2), 2);
				P = Math.Round(Math.PI * diametr, 2);
			}
			else if (figureType == (int)Figure.Triangle)
			{
				Console.WriteLine("Введите длину стороны треугольника: ");
				float storona = 0;

				try
				{
					storona = float.Parse(Console.ReadLine());
				}
				catch (FormatException e)
				{
					Console.WriteLine("Ошибка! Введено нечисловое значение!");
					throw;
				}

				S = Math.Round(Math.Sqrt(3) / 4 * Math.Pow(storona, 2), 2);
				P = Math.Round(3 * storona, 2);
			}
			else if (figureType== (int)Figure.Rectangle)
			{
				Console.WriteLine("Введите длину прямоугольника: ");
				float storona = 0;
				float visota = 0;

				try
				{
					storona = float.Parse(Console.ReadLine());
				}
				catch (FormatException e)
				{
					Console.WriteLine("Ошибка! Введено нечисловое значение!");
					throw;
				}

				Console.WriteLine("Введите высоту прямоугольника: ");

				try
				{
					visota = float.Parse(Console.ReadLine());
				}
				catch (FormatException e)
				{
					Console.WriteLine("Ошибка! Введено нечисловое значение!");
					throw;
				}
				S = Math.Round(visota * storona, 2);
				P = Math.Round(visota + storona, 2);
			}
			
			Console.WriteLine($"Площадь поверхности: {S}");
			Console.WriteLine($"Длина периметра: {P}");

		}
	}
}
