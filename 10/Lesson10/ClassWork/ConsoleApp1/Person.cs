using System;

namespace ConsoleApp1
{
	class Person
	{
		private DateTimeOffset _dateOfBirth;

		private int _age;

		public int Age
		{
			get
			{
				return _age;
			}
			set
			{
				if (value >= 0 && value < 140)
				{
					_age = value;
				}
				else
				{
					throw new InvalidOperationException("Age should be in range [0..140]");
				}
			}
		}

		public string Name { get; set; }

		public void SetDateOfBirth(DateTimeOffset dateOfBirth)
		{
			_dateOfBirth = dateOfBirth;
		}

		public DateTimeOffset GetDateOfBirth()
		{
			return _dateOfBirth;
		}
	}
}
