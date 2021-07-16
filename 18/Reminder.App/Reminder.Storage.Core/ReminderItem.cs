﻿using System;

namespace Reminder.Storage.Core
{
	public class ReminderItem
	{
		public Guid Id { get; set; }
		public DateTimeOffset Date { get; set; }

		public string Message { get; set; }
		public string ContactID { get; set; }
		public ReminderItemStatus Status { get; set; }

		public ReminderItem()
		{

		}
		public ReminderItem(Guid id, DateTimeOffset date, string message, string contactId, ReminderItemStatus status)
		{
			Id = id;
			Date = date;
			Message = message;
			ContactID = contactId;
			Status = status;
		}

		public ReminderItem(DateTimeOffset date, string message, string contactId, ReminderItemStatus status):this (Guid.NewGuid(), date, message, contactId,status )
		{
			Date = date;
			Message = message;
			ContactID = contactId;
			Status = status;
		}

	}
}
