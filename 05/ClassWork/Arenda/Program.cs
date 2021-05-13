using System;
using System.Text;

namespace Arenda
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.OutputEncoding = Encoding.Unicode;
			Console.InputEncoding = Encoding.Unicode;

			Console.WriteLine("Введите длительность договора аренды в годах: ");

			int arenda = int.Parse(Console.ReadLine());

			if (arenda>30 || arenda <1)
			{
				Console.WriteLine("Вы ввели неверное значение!");
			}
			else if (arenda==1 || arenda==21)
			{
				Console.WriteLine($"Договор аренды оформлен на период длительностью {arenda} год");
			}
			else if (arenda >=2 & arenda <=4 || arenda >= 22 & arenda <= 24)
			{
				Console.WriteLine($"Договор аренды оформлен на период длительностью {arenda} года");
			}
			else if (arenda >= 5 & arenda <= 20 || arenda>=25)
			{
				Console.WriteLine($"Договор аренды оформлен на период длительностью {arenda} лет");
			}

		}
	}
}
