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
			// defining parameters sum, sub, mul, dev

			float sum = 0;
			float sub = 0;
			float mul = 0;
			float dev = 0;
			
			// Enter first value and check if it is 0
			CheckPoint1:
			Console.Write("Введите первое число, отличное от нуля: ");
			string userInput1 = Console.ReadLine();
			float number1 = float.Parse(userInput1);

			if (number1 == 0)
			{
				Console.WriteLine("Введите число, отличное от нуля!");
				goto CheckPoint1;
			}
			else
			{
			CheckPoint2:
			// Enter second value and check if it is 0
				Console.Write("Введите второе число, отличное от нуля: ");
				string userInput2 = Console.ReadLine();
				float number2 = float.Parse(userInput2);
				if (number2 == 0)
				{
					Console.WriteLine("Введите число, отличное от нуля!");
					goto CheckPoint2;
				}
				else
				{
					sum = number1 + number2;
					sub = number1 - number2;
					mul = number1 * number2;
					dev = number1 / number2;

					Console.WriteLine($"Сумма двух чисел= {sum}");
					Console.WriteLine($"Разность двух чисел= {sub}");
					Console.WriteLine($"Произведение двух чисел= {mul}");
					Console.WriteLine($"Частное двух чисел= {dev}");
				}
			}
		}
	}
}