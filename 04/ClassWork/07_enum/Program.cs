using System;

namespace _07_enum
{
	enum Day { Mo,Tu,We,Th,Fr,Sa,Su};
	enum DayTime : byte
	{ 
		Morning=100,
		Midday=150,
		Evening=200,
		Night=250
	}

	enum Season : byte
	{
		Winter=3,
		Spring=6,
		Summer=9,
		Autumn=12
	}

	class Program
	{
		static void Main(string[] args)
		{
			Season now = Season.Spring;
			Console.WriteLine(((int)now)+3);
		}
	}
}

//class Program
//	{
//		static void Main(string[] args)
//		{
//			var today = Day.We;

//			Console.WriteLine(today);
//			Console.WriteLine("Enter current day time:");
//			var dayTime = (DayTime)Enum.Parse(typeof(DayTime), Console.ReadLine());
//			Console.WriteLine(dayTime);
//		}
//	}
//}

