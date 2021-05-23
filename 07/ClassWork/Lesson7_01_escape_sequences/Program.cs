using System;
using System.Text;


namespace Lesson7_01_escape_sequences
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.OutputEncoding = Encoding.UTF8;
			Console.WriteLine("Hello	World!");
			Console.WriteLine("Hello\tWorld!");
			Console.WriteLine("Hello\nWorld!");
			Console.WriteLine("\u2665");
		}
	}
}
