using System;
namespace Pet_class
{

	class Program
	{

		static void Main()
		{

			Pet pet1 = new Pet();
			pet1.Age = 10;
			pet1.Name = "Leo";
			pet1.Kind = PetKind.Mouse;
			pet1.Sex = 'f';
			pet1.SetPlaceOfBirth("Italy");
			Console.WriteLine(pet1.Description);


			Pet pet2 = new Pet
			{
				Name = "Bob",
				Age = 15,
				Kind = PetKind.Dog,
				Sex = 'M'
			};
			pet2.SetPlaceOfBirth("Germany");

			Console.WriteLine(pet2.Description);
		}
	}
}