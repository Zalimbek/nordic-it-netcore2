using System;

namespace ConsoleApp1
{
	enum Container: Int32
		{Small=1,
		Medium=2,
		Big=4
		}
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter volume of the pack of juice: ");
			double pack = double.Parse(Console.ReadLine());
			var v20 =Math.Floor(pack/20);
			var v5= Math.Floor((pack-v20*20)/5);
			var rest= pack - v20 * 20-v5*5;

			if (v20 == 0)
			{
				if (v5 == 0)
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
						Console.WriteLine($"You have to take {v5} {Container.Medium}, {Math.Ceiling(rest)} {Container.Small} containers");
					}
					else
					{
						Console.WriteLine($"You have to take {v5} {Container.Medium} containers");
					} 
				}
			}
			else
			{
				if ((v20 % 1) != 0)
				{
					Console.WriteLine($"You have to take {v20} {Container.Big}, {v5} {Container.Medium}, {Math.Ceiling(rest)} {Container.Small} containers");
				}
				else
				{
					Console.WriteLine($"You have to take {v20} {Container.Big} container");
				}
			}
		}
	}
}
