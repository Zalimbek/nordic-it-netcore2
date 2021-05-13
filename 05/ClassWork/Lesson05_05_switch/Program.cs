using System;

namespace Lesson05_05_switch
{
	class Program
	{
		public enum Color
		{
			Red, //0
			Green,//1
			Blue //2
		}


		static void Main(string[] args)
		{
			//var random = new Random();
			Color color = (Color)(new Random()).Next(0, 3);
			switch (color)
			{
				case Color.Red:
					Console.WriteLine("Red");
					break;
				case Color.Green:
					Console.WriteLine("Green");
					break;
				default:
					Console.WriteLine("Unknown");
					break;
			}
		}
	}
}
