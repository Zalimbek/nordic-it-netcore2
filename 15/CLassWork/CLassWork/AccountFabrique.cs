using System;
using System.Collections.Generic;
using System.Text;

namespace Generic_methods
{
	class AccountFabrique
	{
		public T CreateAccount<T>() where T:Account<int>, new()
		{
			return new T();
		}
	}
}
