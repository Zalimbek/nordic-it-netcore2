using System;

namespace HomeWork
{
	class ReminderItem
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

		public string WriteProperties()
		{
			return (nameof(AlarmDate) + ":" + AlarmDate + "\n" + nameof(AlarmMessage) + ":" + AlarmMessage + "\n"
				+ nameof(TimeToAlarm) + ":" + TimeToAlarm + "\n" + nameof(IsOutdated) + ":" + IsOutdated + "\n");
		}
	}
}
