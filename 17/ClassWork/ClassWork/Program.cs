using System;

namespace ClassWork
{
	public enum WorkType
	{
		Work,
		DoNothing
	}
	class Program
	{
		public delegate void WorkPerformedEventHandler(int hours, WorkType workType);


		static void Main(string[] args)
		{
			WorkPerformedEventHandler del1 = WorkPerformed1;

			del1(8, WorkType.Work);
			del1(1, WorkType.DoNothing);
			//WorkPerformed1(8, WorkType.Work);
			//WorkPerformed1(1, WorkType.DoNothing);

			WorkPerformedEventHandler del2 = WorkPerformed2;
			WorkPerformedEventHandler del3 = WorkPerformed3;
			del3 += del1 + del2;
			del3(1, WorkType.Work);
		}

		public static void WorkPerformed1(int hours, WorkType workType)
		{
			Console.WriteLine($"1 Work of type' { workType}': { hours} hours");
		}
		public static void WorkPerformed2(int hours, WorkType workType)
		{
			Console.WriteLine($"2 Work of type' { workType}': { hours} hours");
		}
		public static void WorkPerformed3(int hours, WorkType workType)
		{
			Console.WriteLine($"3 Work of type' { workType}': { hours} hours");
		}
	}
}
