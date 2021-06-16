using System;
using System.Collections.Generic;
using System.Text;

namespace ReminderItem_new
{
	public class PhoneReminderItem : ReminderItem
	{
		public string PhoneNumber { get; set; }
		public PhoneReminderItem(DateTimeOffset alarmDate, string alarmMessage, string phoneNumber)
			: base(alarmDate, alarmMessage)
		{
			PhoneNumber = phoneNumber;
		}

		public override string Properties
		{
			get
			{
				return (GetType().Name + "\n" + nameof(AlarmDate) + ":" + AlarmDate + "\n" + nameof(AlarmMessage) + ":" + AlarmMessage + "\n" +
				nameof(PhoneNumber) + ":" + PhoneNumber + "\n"
				+ nameof(TimeToAlarm) + ":" + TimeToAlarm + "\n" + nameof(IsOutdated) + ":" + IsOutdated + "\n");
			}
		}

		//public override void WriteProperties()
		//{
		//	Console.WriteLine(Properties);
		//}
	}
}

