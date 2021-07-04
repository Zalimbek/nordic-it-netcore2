using System;
using System.Collections.Generic;
using System.Text;

namespace Account_task
{
	class Account<T>
	{
		public T Id { get; private set; }

		public string Name { get; private set; }

		public Account(T id, string name)
		{
			Id = id;
			Name = name;
		}

		public void WriteProperties()
		{
			Console.WriteLine($"{nameof(Id)}: {Name}\n{nameof(Name)}: { Id}");
		}

	}
}
