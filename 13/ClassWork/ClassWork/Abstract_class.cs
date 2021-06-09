using System;
using System.Collections.Generic;
using System.Text;

namespace ClassWork
{
	public abstract class Abstract_class
	{
		public int MaxHeight { get; private set; }
		public int CurrentHeight { get; private set; }
		public Abstract_class(int maxHeight)
		{
			MaxHeight = maxHeight;
			CurrentHeight = 0;
		}
		
	

		public void TakeUpper(int delta)
		{

			if (delta <= 0)
			{
				throw new ArgumentOutOfRangeException("delta is out of range!");
			}
			else if (CurrentHeight + delta > MaxHeight)
			{
				CurrentHeight = MaxHeight;
			}
			else
			{
				CurrentHeight = CurrentHeight + delta;
			}

		}

		public void TakeLower(int delta)
		{
			if (delta <= 0)
			{
				throw new ArgumentOutOfRangeException("delta is out of range!");
			}
			if (CurrentHeight - delta > 0)
			{
				CurrentHeight = CurrentHeight - delta;
			}
			if (CurrentHeight - delta == 0)
			{
				CurrentHeight = 0;
			}
			else
			{
				throw new InvalidOperationException("Crash!");
			}
		}

	}
}
