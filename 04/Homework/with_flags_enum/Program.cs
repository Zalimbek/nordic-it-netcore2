using System;

namespace ConsoleApp1
{
	[Flags]
	enum Container : Int32
	{
		Small = 1,//0x0000001
		Medium = 2,//0x0000010
		Big = 4  //0x0000100
	}
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter volume of the pack of juice: ");
			Container usedPacks = 0;

			double pack = double.Parse(Console.ReadLine());
			var numberOfBigPacks = Math.Floor(pack / 20);
			var numberOfMedPacks = Math.Floor((pack - numberOfBigPacks * 20) / 5);
			var numberOfSmallPacks = Math.Ceiling(pack - numberOfBigPacks * 20 - numberOfMedPacks * 5);

			if (numberOfBigPacks > 0)
			{
				usedPacks = usedPacks | Container.Big;
			}

			if (numberOfMedPacks > 0)
			{
				usedPacks = usedPacks | Container.Medium;
			}

			if (numberOfSmallPacks > 0)
			{
				usedPacks = usedPacks | Container.Small;
			}
			Console.WriteLine($"You have to take {numberOfBigPacks} {Container.Big} container");
			Console.WriteLine("You have to take the following containers: ");

			if ((usedPacks & Container.Big) == Container.Big)
			{
				Console.WriteLine($"{numberOfBigPacks} {Container.Big}");
			}

			if ((usedPacks & Container.Medium) == Container.Medium)
			{
				Console.WriteLine($"{numberOfMedPacks} {Container.Medium}");
			}

			if ((usedPacks & Container.Small) == Container.Small)
			{
				Console.WriteLine($"{numberOfSmallPacks} {Container.Small}");
			}

		}
	}
}
