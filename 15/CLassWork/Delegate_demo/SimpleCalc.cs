using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace Delegate_demo
{
	public static class SimpleCalc
	{
		public static int Sum(int x, int y)
		{
			Debug.WriteLine($"{nameof(Sum)} called");
			return x + y;
		}

		public static int Multiply(int x, int y)
		{
			Debug.WriteLine($"{nameof(Multiply)} called");
			return x * y;
		}
	}
}
