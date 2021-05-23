using System;

namespace Lesson7_modify_string
{
	class Program
	{
		static void Main(string[] args)
		{
			string a = "my test string";
			string b = a.Replace("test", "best");
			Console.WriteLine(a+"\n"+b);

			string c = a.Substring(3, 4);
			Console.WriteLine(a + "\n" + c);

			string[] lines = "here we go!".Split(' ');
			foreach (string line in lines)
			{
				Console.WriteLine($"{line}: {line.Length}");
			}

			Console.WriteLine(string.Join("\u2665", lines));
		}
	}
}
