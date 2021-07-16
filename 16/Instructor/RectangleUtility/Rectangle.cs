using System;

namespace RectangleUtility
{
	public class Rectangle<T> where T: struct
	{
		public T SideA { get; }

		public T SideB { get; }

		public Rectangle(T sideA, T sideB)
		{
			SideA = sideA;
			SideB = sideA;
		}

		public T Calculate(Func<T, T, T> calculationLogic)
		{
			return calculationLogic(SideA, SideB);
		}
	}
}
