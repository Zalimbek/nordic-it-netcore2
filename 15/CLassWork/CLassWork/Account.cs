using System;
using System.Collections.Generic;
using System.Text;

namespace Generic_methods
{
	class Account<T>
	{
		public T Id { get; private set; }

		public string Name { get;  set; }

		public Account(T id, string name)
		{
			Id = id;
			Name = name;
		}

		public void WriteProperties()
		{
			Console.WriteLine(ToString());
		}

		public override string ToString()
		{
			return $"{nameof(Id)}: {Id} {nameof(Name)}: { Name}";
		}

		public Account()
		{ }

	}
}
