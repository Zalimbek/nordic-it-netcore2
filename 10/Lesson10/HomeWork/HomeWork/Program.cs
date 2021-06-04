using System;

namespace HomeWork
{
	partial class Program
	{
		static void Main(string[] args)
		{
			Person[] persona = new Person[3];

			for (int i = 0; i < persona.Length; i++)
			{
				persona[i] = new Person();
				Console.WriteLine("Enter the name: ");
				persona[i].Name = Console.ReadLine();
				Console.WriteLine("What is the age of a person? ");
				persona[i].Age = int.Parse(Console.ReadLine());
			}

			for (int i = 0; i < persona.Length; i++)
			{
				Console.WriteLine(persona[i].Description);
			}
		}
	}
}
