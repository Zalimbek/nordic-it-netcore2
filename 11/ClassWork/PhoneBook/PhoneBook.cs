using System.Collections.Generic;

namespace PhoneBook
{
	class PhoneBook
	{
		private Dictionary<string, Contact> _contacts;

		public PhoneBook()
		{
			_contacts = new Dictionary<string, Contact>();
		}

		public void AddContact(Contact contact)
		{
			_contacts.Add(contact.Name, contact);
		}

		public Contact FindContact(string name)
		{
			return _contacts.ContainsKey(name)
				? _contacts[name]
				: null;
		}
	}
}
