using System;
namespace Pet_class
{

	class Pet
	{
		private string _birthPlace;
		private char _sex;
		private byte _age;

		public string Name;
		public PetKind Kind;
		public byte Age;

		public char Sex
		{
			get
			{
				return _sex;
			}
			set
			{
				if (value == 'm' || value == 'M' || value == 'f' || value == 'F')
				{
					_sex = value;
				}
				else
				{
					throw new InvalidOperationException("Sex should be M or F");
				}
			}
		}

		public void SetPlaceOfBirth(string placeOfBirth)
		{
			_birthPlace = placeOfBirth;
		}

		public string GetPlaceOfBirth()
		{
			return _birthPlace;
		}

		public string Description
		{
			get
			{
				return $"{Name} is a {Kind} ({Sex}) of {Age} years old from {_birthPlace}";
			}
		}

	}

}