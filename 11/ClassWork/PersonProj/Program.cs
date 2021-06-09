using System;

namespace HomeWork
{
	partial class Program
	{
		static void Main(string[] args)
		{
			const int passYearsCount = 4;
			const int peopleCount = 3;

			Person[] persona = new Person[peopleCount];

			for (int i = 0; i < persona.Length; i++)
			{
				
				Console.WriteLine("Enter the name: ");
				string name = Console.ReadLine();
				Console.WriteLine("What is the age of a person? ");
				int age = int.Parse(Console.ReadLine());

				persona[i]=new Person(name, age);
			}

			persona[0].UpdateProperties("Andrei");
			persona[0].UpdateProperties("Andrei",20);
			persona[0].UpdateProperties(120);

			for (int i = 0; i < peopleCount; i++)
			{
				Console.WriteLine(persona[i].GetPropertiesString(passYearsCount));
			}
		}
	}
}
