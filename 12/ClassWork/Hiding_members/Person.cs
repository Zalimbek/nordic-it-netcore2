using System;
using System.Diagnostics;

namespace Hiding_members
{

	class Person
	{
		public string Name { get; set; }
		public DateTimeOffset DateOfBirth { get; set; }

		public virtual string ShortDescription
		{
			get
			{
				return $"{GetType().Name} " +
					$"name: {Name}, " +
					$"date of birth: {DateOfBirth:dd-MM-yy}";
			}
		}

		public Person(
			string name, DateTimeOffset dateOfBirth)
		{
			Name = name;
			DateOfBirth = dateOfBirth;
			Debug.WriteLine("Constructor Person(name, dateOfBirth) called");
		}

		public void WriteShortDescription()
		{
			Console.WriteLine(ShortDescription);
		}

		public override string ToString()
		{
			return ShortDescription;
		}

	}


}

