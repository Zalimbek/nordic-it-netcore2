using System;

namespace _08_Enum_Flags
{
	[Flags]
	//enum Day : byte
	//{
	//	None=0,
	//	Mo=1,
	//	Tu=2,
	//	We=4,
	//	Th=8,
	//	Fr=16,
	//	Sa=32,
	//	Su=64
	//	//XX=128
	//};
	enum Day : byte
	{
		None = 0,
		Mo = 0x1,
		Tu = 0x2,
		We = 0x4,
		Th = 0x8,
		Fr = 0x10,
		Sa = 0x20,
		Su = 0x40
		//XX=128
	};
	class Program
	{
		static void Main(string[] args)
		{
			Day workingDays = (Day)31;
			Console.WriteLine(workingDays);

			//add separate bit
			workingDays = workingDays | Day.Sa;
			Console.WriteLine(workingDays);

			//delete separate bit
			workingDays = workingDays ^ Day.Mo;
			Console.WriteLine(workingDays);

			bool ThursdayIsWorking = (workingDays & Day.Th) != Day.Th;
			Console.WriteLine(ThursdayIsWorking);


		}
	}
}
