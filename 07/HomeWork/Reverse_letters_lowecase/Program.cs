using System;
using System.Text;

namespace Reverse_letters_lowecase
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.InputEncoding = Encoding.Unicode;
			Console.OutputEncoding = Encoding.Unicode;
			string s = String.Empty;
			Console.WriteLine("Введите непустую строку: ");

			s = Console.ReadLine();
		
			if (s == string.Empty)
			{
				Console.WriteLine("Вы ввели пустую строку :( Попробуйте ещё раз:");
			}
			else
			{
				s = s.ToLower();
				char[] str = s.ToCharArray();
				Array.Reverse(str);
				Console.WriteLine(new string(str));
			}
		}
	}
}
