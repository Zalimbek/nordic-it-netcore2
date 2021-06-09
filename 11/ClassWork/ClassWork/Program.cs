using System;
namespace Pet_class
{

	class Program
	{

		static void Main()
		{
			var rand = new Random();
			int rnd = rand.Next();
			Console.WriteLine(rnd);
			TimeSpan ts = TimeSpan.FromDays(7);


			Pet pet1 = new Pet();
			pet1.DateOfBirth = DateTimeOffset.Parse("2012-01-01T12:00:00+0300");
			pet1.Name = "Leo";
			pet1.Kind = PetKind.Mouse;
			pet1.Sex = 'f';
			pet1.SetPlaceOfBirth("Italy");
			pet1.WriteDescription("pet");


			Pet pet2 = new Pet
			{
				Name = "Bob",
				DateOfBirth = DateTimeOffset.Parse("2016-06-01T12:00:00+0300"),
				Kind = PetKind.Dog,
				Sex = 'M'
			};
			pet2.SetPlaceOfBirth("Germany");

			pet2.WriteDescription("pet",true);
		}
	}
}