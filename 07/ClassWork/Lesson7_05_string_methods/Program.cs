using System;

namespace Lesson7_05_string_methods
{
	class Program
	{
		static void Main(string[] args)
		{
			string s = "lorem ipsum test test test";
			Console.WriteLine(s.Contains("ips")); //true
			Console.WriteLine(s.StartsWith("test")); //false

			int searchFromIndex = 0;


			int i = 0;

			while (i < s.Length)
			{
				int index = s.IndexOf("s", searchFromIndex); //8
				if (index == -1)
					break;

				Console.WriteLine(index);
				searchFromIndex = index + 1;
			}
		}
	}
}
