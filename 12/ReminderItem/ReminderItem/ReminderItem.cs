using System;
using System.Collections.Generic;

namespace ReminderItem_new
{
	public class ReminderItem
	{
		public DateTimeOffset AlarmDate { get; set; }
		public string AlarmMessage { get; set; }

		public TimeSpan TimeToAlarm
		{
			get
			{
				return (DateTime.UtcNow - AlarmDate);
			}
		}
		public bool IsOutdated
		{
			get
			{
				return ((TimeToAlarm.TotalSeconds < 0)
					? false
					: true);
			}
		}

		public ReminderItem(DateTimeOffset alarmDate, string alarmMessage)
		{
			AlarmDate = alarmDate;
			AlarmMessage = alarmMessage;
		}

		public virtual string Properties
		{
			get
			{
				return (GetType().Name + "\n" + nameof(AlarmDate) + ":" + AlarmDate + "\n" + nameof(AlarmMessage) + ":" + AlarmMessage + "\n"
					+ nameof(TimeToAlarm) + ":" + TimeToAlarm + "\n" + nameof(IsOutdated) + ":" + IsOutdated + "\n");
			}
		}

		public virtual void WriteProperties()
		{
			Console.WriteLine(Properties);
		}
	}
}
