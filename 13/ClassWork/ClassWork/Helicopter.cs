using System;
using System.Collections.Generic;
using System.Text;

namespace ClassWork
{
	class Helicopter: Abstract_class, IWriteProperties
	{
		public byte BladesCount { get; private set; }

		public Helicopter(int maxHeight, byte bladeCount) : base(maxHeight)
		{
			BladesCount = bladeCount;
		}

		public void WriteAllProperties()
		{
			Console.WriteLine($"BladesCount: {BladesCount}\nCurrentHeight: {CurrentHeight}\nMaxHeight: {MaxHeight}");
		}
	}
}
