using System;

namespace Account_task
{
	class Program
	{
		static void Main(string[] args)
		{
			Account<int> account1 = new Account<int>(123, "Kevin");
			Account<string> account2 = new Account<string>("qweasd", "Uriy");
			Account<Guid> account3 = new Account<Guid>(Guid.NewGuid(), "Max");

			account1.WriteProperties();
			account2.WriteProperties();
			account3.WriteProperties();

		}
	}
}
