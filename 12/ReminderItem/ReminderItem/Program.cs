using System;
using System.Collections.Generic;

namespace ReminderItem_new
{
	class Program
	{
		static void Main(string[] args)
		{

			var reminders = new List<ReminderItem>();
			reminders.Add(new PhoneReminderItem(DateTimeOffset.Parse("04.06.2021 10:00:00"), "Time to wake up!", "+18043249888"));
			reminders.Add(new PhoneReminderItem(DateTimeOffset.Parse("10.06.2021 10:00:00"), "Time to wake up!", "+1"));
			reminders.Add(new ChatReminderItem(DateTimeOffset.Parse("10.06.2021 10:00:00"), "too early", "Sedrick", "Pat"));

			foreach (var rem in reminders)
			{
				if (rem is PhoneReminderItem)
				{
					rem.WriteProperties();
				}
				else
					rem.WriteProperties();

			}
		}
	}
}
