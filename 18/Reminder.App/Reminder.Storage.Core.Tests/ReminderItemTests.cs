using Microsoft.VisualStudio.TestTools.UnitTesting;
using Reminder.Storage.Core;
using System;

namespace Reminder.Storage.Core.Tests
{
	[TestClass]
	public class ReminderItemTests
	{
		[TestMethod]
		public void Empty_Constructor_Creates_Instance_With_Empty_Guid()
		{
			//prepare tests data

			ReminderItem reminderItem;

			//action
			reminderItem = new ReminderItem();

			//check results

			Assert.IsNotNull(reminderItem); //убедиться, что 
			Assert.AreEqual(Guid.Empty,reminderItem.Id);
		}

		[TestMethod]
		public void Constructor_Without_Id_Initialized_Instance_With_New_Guid()
		{
			//prepare tests data

			ReminderItem reminderItem;

			//action
			reminderItem = new ReminderItem(DateTimeOffset.MinValue, string.Empty, string.Empty, ReminderItemStatus.Awaiting);
			//check results

			Assert.IsNotNull(reminderItem);
			Assert.AreNotEqual(Guid.Empty, reminderItem.Id);

		}

	}
}
