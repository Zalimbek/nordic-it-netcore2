using System;

namespace ClassWork
{
	class Program
	{
		static void Main(string[] args)
		{
			var p = new Plane(2, 50);
			

			((IWriteProperties)p).WriteAllProperties();

		}
	}
}
