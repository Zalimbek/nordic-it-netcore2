namespace PhoneBook
{
	class Contact
	{
		public string Name { get; set; }
		public string PhoneNumber { get; set; }
		public string Address { get; set; }

		public Contact(string name, string phoneNumber, string address)
		{
			Name = name;
			PhoneNumber = phoneNumber;
			Address = address;
		}

		public string Description
		{
			get { return $"{Name}, {PhoneNumber}, {Address}"; }
		}
	}
}
