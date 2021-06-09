using System;
using System.Collections.Generic;
using System.Text;

namespace ClassWork
{
	class Plane : Abstract_class
	{
		public byte EngineCount { get; private set; }

		public Plane(int maxHeight, byte enginesCount) : base(maxHeight, 0)
		{
			EngineCount = enginesCount;
		}

		public override void WriteAllProperties()
		{
			Console.WriteLine($"EngineCount: {EngineCount}\nCurrentHeight: {CurrentHeight}\nMaxHeight: {MaxHeight}");
		}
	}
}
