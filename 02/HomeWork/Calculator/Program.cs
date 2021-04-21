using System;
using System.Text;

namespace Calculator
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.InputEncoding = Encoding.Unicode;  // support unicode for input
			Console.OutputEncoding = Encoding.Unicode; // support unicode for output
			Console.Write("Введите первое число: ");
			string fromConsole1 = Console.ReadLine();
			float number1 = float.Parse(fromConsole1);
			Console.Write("Введите второе число: ");
			string fromConsole2 = Console.ReadLine();
			float number2 = float.Parse(fromConsole2);
			float sum = number1 + number2;
			float sub = number1 - number2;
			float mul = number1 * number2;
			float dev = number1 / number2;
			Console.WriteLine($"Сумма двух чисел= {sum}");
			Console.WriteLine($"Разность двух чисел= {sub}");
			Console.WriteLine($"Произведение двух чисел= {mul}");
			if (number2==0)
				Console.WriteLine("На ноль делить нельзя!");
			else
				Console.WriteLine($"Частное двух чисел= {dev}");
		}
		}
	}

