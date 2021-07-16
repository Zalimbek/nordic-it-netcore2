using Microsoft.VisualStudio.TestTools.UnitTesting;
using Reminder.Storage.Core;
using System;

namespace Reminder.Storage.InMemory.Tests
{
	[TestClass]
	public class InMemoryReminderStorageTests
	{
		[TestMethod]
		public void Get_Returns_Null_For_Absent_Id()

		{
			var storage = new inMemoryReminderStorage();
			ReminderItem actual=storage.Get(Guid.Empty);
			Assert.IsNull(actual);

		}

		[TestMethod]

		public void Get_Returns_Just_Added_Item()
		{
			Guid guid = Guid.NewGuid();
			DateTimeOffset date = DateTimeOffset.Now;
			string message = "TEST MSG";
			string contactId = "Test ID 123";
			ReminderItemStatus status = ReminderItemStatus.Failed;

			var expected = new ReminderItem(guid, date, message, contactId, status);

			var storage = new inMemoryReminderStorage();

			//test action

			storage.Add(expected);
			var actual = storage.Get(guid);
			//check results

			Assert.IsNotNull(actual);
			Assert.AreEqual(expected.Id, actual.Id);
			Assert.AreEqual(expected.Date, actual.Date);
			Assert.AreEqual(expected.ContactID, actual.ContactID);
			Assert.AreEqual(expected.Message, actual.Message);
			Assert.AreEqual(expected.Status, actual.Status);
		}

		[TestMethod]

		public void Get_Add_of_Item_With_Already_Added_Id_Throws_Exception()
		{
			var storage = new inMemoryReminderStorage();
			ReminderItem reminderItem = new ReminderItem()
			{
				Id = Guid.NewGuid()

			};
			storage.Add(reminderItem);

			Assert.ThrowsException<ArgumentException>(() =>
				{
					storage.Add(reminderItem);
				});
		}
	}
}
