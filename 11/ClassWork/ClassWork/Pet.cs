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
		//public byte Age;
		public DateTimeOffset DateOfBirth;

		public byte Age
		{
			get
			{
				TimeSpan age = DateTimeOffset.Now - DateOfBirth;
				return (byte)Math.Floor(age.TotalDays / 365.242);

			}
		}

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
		public string ShortDescription
		{
			get
			{
				return $"{Name} is a {Kind}";
			}
		}

		public Pet(string name, PetKind kind, char sex, DateTimeOffset dateOfBirth)
		{
			Name = name;
			Kind = kind;
			Sex = sex;
			DateOfBirth = dateOfBirth;
		}

		public Pet()
		{

		}

		public void WriteDescription(string prefix, bool showFullDescription=false)
		{
			Console.WriteLine(
				prefix+ " "+
				(showFullDescription
				? Description
				: ShortDescription));
		}
	}

}