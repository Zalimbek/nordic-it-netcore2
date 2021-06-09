using System;

namespace PhoneBook
{
	class Program
	{
		static void Main(string[] args)
		{
			var phonebook = new PhoneBook();
			phonebook.AddContact(new Contact("Andrei", "88005555555", "Moscow"));
			phonebook.AddContact(new Contact("Masha", "88005555099", "Moscow"));
			Console.WriteLine(phonebook.FindContact("Andrei")?.Description);
			Console.WriteLine(phonebook.FindContact("Ivan")?.Description);
		}
	}
}
