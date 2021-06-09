using System;

namespace Interface_default
{
	class Program
	{
		static void Main(string[] args)
		{
			using SomeThing thing = new SomeThing();
		}

		public class SomeThing : IDisposable
		{
			public void Dispose()
			{
				Console.WriteLine("Dispose Done");
			}


		}
	}
}
