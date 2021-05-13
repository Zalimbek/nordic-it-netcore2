using System;

namespace ConsoleApp1
{
	
	enum Container: Int32
		{Small=1,//0x0000001
		Medium=2,//0x0000010
		Big = 4  //0x0000100
	}
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter volume of the pack of juice: ");
			double pack = double.Parse(Console.ReadLine());
			var numberOfBigPacks =Math.Floor(pack/20);
			var numberOfMedPacks= Math.Floor((pack-numberOfBigPacks*20)/5);
			var rest= pack - numberOfBigPacks * 20-numberOfMedPacks*5;

			if (numberOfBigPacks == 0)
			{
				if (numberOfMedPacks == 0)
				{
					if (rest == 0)
					{
						Console.WriteLine("Please enter a valid number");
					}
					else
					{
						Console.WriteLine($"You have to take {Math.Ceiling(rest)} {Container.Small} containers");
					}
				}
				else
				{
					if ((rest % 1) != 0)
					{
						Console.WriteLine($"You have to take {numberOfMedPacks} {Container.Medium}, {Math.Ceiling(rest)} {Container.Small} containers");
					}
					else
					{
						Console.WriteLine($"You have to take {numberOfMedPacks} {Container.Medium} containers");
					} 
				}
			}
			else
			{
				if ((numberOfBigPacks % 1) != 0)
				{
					Console.WriteLine($"You have to take {numberOfBigPacks} {Container.Big}, {numberOfMedPacks} {Container.Medium}, {Math.Ceiling(rest)} {Container.Small} containers");
				}
				else
				{
					Console.WriteLine($"You have to take {numberOfBigPacks} {Container.Big} container");
				}
			}
		}
	}
}
