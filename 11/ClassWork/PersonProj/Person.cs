using System;

namespace HomeWork
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
		//public int AgeInFourYears
		//{
		//	get { return Age + 4; }
		//}
		public Person(string name, int age) // constructor
		{
			Name = name;
			Age = age;
		}
		public int GetAgeInSomeYears(int yearsCount)
		{
			return Age + yearsCount;
		}
		public string GetPropertiesString(int yearsCount)
		{
			{
				return $"Name: {Name}, age in {yearsCount} years: {GetAgeInSomeYears(yearsCount)}";
			}
		}

		public string GetPropertiesStringShort(int yearsCount)
		{
			{
				return $"Name: {Name}";
			}
		}
		public void UpdateProperties(string name)
		{
			Name = name;
		}

		public void UpdateProperties(int age)
		{
			Age = age;
		}

		//	public bool UpdateProperties(string name, int age)
		//	{
		//		try
		//		{
		//			Name = name;
		//			Age = age;
		//			return true;
		//		}
		//		catch (Exception)
		//		{
		//			return false;
		//		}
		//	}
	}


}

