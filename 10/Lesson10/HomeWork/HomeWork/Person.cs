using System;

namespace HomeWork
{
	partial class Program
	{
		class Person
		{
			private int _age;

			public int Age
			{
				get
				{
					return _age;
				}
				set
				{
					if (value >= 0 && value < 110)
					{
						_age = value;
					}
					else
					{
						throw new InvalidOperationException("Age should be in range [0..110]");
					}
				}
			}

			public string Name { get; set; }
			public string Description
			{
				get
				{
					return $"Name: {Name}, age in 4 years: {Age+4}";
				}
			}
		}


		}
	}

