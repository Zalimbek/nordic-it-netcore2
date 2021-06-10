using System;

namespace Hiding_members
{
	partial class Program
	{
		private static void Main()
		{
			Person p1 = new Person("Andrei", DateTimeOffset.Parse("1982-03-14"));
			p1.WriteShortDescription();

			//{
			//	Name = "Andrei",
			//	DateOfBirth = DateTimeOffset.Parse("1982-03-14")
			//};

			Employee e1 = new Employee("Andrei", DateTimeOffset.Parse("1982-03-14"), "000001", DateTimeOffset.Parse("2016-10-01"));
			//{
			//	Name = "Andrei",
			//	DateOfBirth = DateTimeOffset.Parse("1982-03-14"),
			//	EmployeeCode = "000001",
			//	HireDate = DateTimeOffset.Parse("2016-10-01")
			//};

			e1.WriteShortDescription();

			//object o = new Person("Andrei", DateTimeOffset.Parse("1982-03-14"));
			//((Person)o).DateOfBirth
			//Console.WriteLine(o);
		}
	}
}
