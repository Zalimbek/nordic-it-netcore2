using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace Sam2
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.InputEncoding = Encoding.Unicode;
			Console.OutputEncoding = Encoding.Unicode;

			var game = new Dictionary<string, string>()
			{
				{"Россия", "Москва" },
				{"Грузия", "Тбилиси" },
				{ "Украина", "Киев"}
			};

			do
			{
				Random random = new Random();
				int rnd = random.Next(game.Count);
				KeyValuePair<string, string> pair = game.ElementAt(rnd);
				Console.WriteLine($"Введите столицу для страны {pair.Key}:");
				string fromConsole = Console.ReadLine();

				if (fromConsole.ToLower() == pair.Value.ToLower())
					Console.WriteLine("You are cool!");
				else
					break;
			} while (true);


		}
	}
}
