using System;

namespace ClassWork
{
	class Program
	{
		static void Main(string[] args)
		{
			object o1 = new object();
			object o2 = new object();

			Console.WriteLine(o1==o2); //False compare the links, not the objects, they have different addresses

			string s1 = "value1";
			string s2 = "value1";
			Console.WriteLine(s1==s2);
			Console.WriteLine(s1.Equals(s2)); //True

			string input = Console.ReadLine();
			if (input == "show message")
			{
				Console.WriteLine("message");
			}

			//if (input.Equals("show message"))// invalid if 
			if ("show message".Equals(input))
			{
				Console.WriteLine("message");
			}

			Console.WriteLine("===========================");
			Console.WriteLine("Test"=="test"); //False
			Console.WriteLine("Test".Equals("tesT",StringComparison.InvariantCultureIgnoreCase));
		}
	}
}
