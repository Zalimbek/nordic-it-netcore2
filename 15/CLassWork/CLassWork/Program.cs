using System;
using System.Collections.Generic;
using System.Text;

namespace Generic_methods
{
	class Program
	{
		static void Main(string[] args)
		{
			int a= -1;
			int b = 100;
			Console.WriteLine($"a={a},b={b}");
			Swapper.Swap<int>(ref a, ref b);

			Console.WriteLine($"a={a},b={b}");

			// Account
			var account1 = new Account<int>(1, "Andrei");
			var account2 = new Account<int>(2, "Petr");

			Console.WriteLine($"{nameof(account1)}={account1}, {nameof(account2)}={account2}");

			Swapper.Swap(ref account1, ref account2);
			Console.WriteLine($"{nameof(account1)}={account1}, {nameof(account2)}={account2}");

			UpdateName(ref account1);

			Console.WriteLine($"{nameof(account1)}={account1}");

			AccountFabrique fabrique = new AccountFabrique();
			var account = fabrique.CreateAccount<int>(10, "Nadia");
			var account12 = fabrique.CreateAccount<Account<int>>();
		}
		private static void UpdateName(ref Account<int> account) //
		{
			account.Name = "Mr." + account.Name;
			account = new Account<int>(3, "Sveta");
		}
	}
}
