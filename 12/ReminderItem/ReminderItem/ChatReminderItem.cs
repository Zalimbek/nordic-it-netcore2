using System;
using System.Collections.Generic;
using System.Text;

namespace ReminderItem_new
{
	public class ChatReminderItem : ReminderItem
	{
		public string ChatName { get; set; }
		public string AccountName { get; set; }
		public ChatReminderItem(DateTimeOffset alarmDate, string alarmMessage, string chatName, string accountName)
				: base(alarmDate, alarmMessage)
		{
			ChatName = chatName;
			AccountName = accountName;
		}

		public override string Properties
		{
			get
			{
				return (GetType().Name + "\n" + nameof(AlarmDate) + ":" + AlarmDate + "\n" + nameof(AlarmMessage) + ":" + AlarmMessage + "\n" +
				nameof(ChatName) + ":" + ChatName + "\n" + nameof(AccountName) + ":" + AccountName + "\n"
				+ nameof(TimeToAlarm) + ":" + TimeToAlarm + "\n" + nameof(IsOutdated) + ":" + IsOutdated + "\n");
			}
		}

		//public override void WriteProperties()
		//{
		//	Console.WriteLine(Properties);
		//}
	}
}
