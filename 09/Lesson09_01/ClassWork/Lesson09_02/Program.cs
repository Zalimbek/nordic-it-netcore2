using System;

namespace Lesson09_02
{
	class Program
	{
		static void Main(string[] args)
		{
			const int length = 5;
			const int MaxValue = 1000;

			var arr =new int[length];
			var rnd = new Random();

			for (int i = 0; i < arr.Length; i++) //N
			{
				arr[i] = rnd.Next(MaxValue);
			}

			for (int i = 0; i < arr.Length; i++)
			{
				Console.WriteLine(arr[i]);
			}
			//2*N

			//string s = "[[][][]{}{}{}]";
			//foreach (char ch in s)
			//{
			//	s.Split()
			//}
		}
	}
}
