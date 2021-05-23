using System;
using System.Text;

namespace Words_start_with_A
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.OutputEncoding = Encoding.Unicode;
			Console.InputEncoding = Encoding.Unicode;

			Console.WriteLine("Введите строку из нескольких слов: ");
			string s = Console.ReadLine();
			int i = 0;
			int counter = 0;
			string[] words = s.Split(' ');

			if (words.Length == 1)
			{
				Console.WriteLine("Слишком мало слов :( Попробуйте ещё раз:");
			}
			else
			{
				while (i < words.Length)
				{
					if (words[i].StartsWith("A") || words[i].StartsWith("a") || words[i].StartsWith("а") || words[i].StartsWith("А"))
					{
						counter++;
					}
					i++;
				}
				Console.WriteLine($"Количество слов, начинающихся с буквы 'А': {counter}");

			}
		}
	}
}
