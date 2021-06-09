using System;

namespace HomeWork
{
	class Program
	{
		static void Main(string[] args)
		{
			var reminder1 = new ReminderItem(DateTimeOffset.Parse("10.06.2021 8:00:00"), "Too early to wake up");
			var reminder2 = new ReminderItem(DateTimeOffset.Parse("09.06.2021 8:00:00"), "Time to wake up!");
			Console.WriteLine(reminder1.WriteProperties());
			Console.WriteLine(reminder2.WriteProperties());
		}
	}
}
