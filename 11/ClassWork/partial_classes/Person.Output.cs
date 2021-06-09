using System;

namespace partial_classes
{
	partial class Person
	{

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
	}
}




