using System;

namespace Interface
{
	class Program
	{
		interface WindowsWindow
		{
			void Move(int x, int y);
			void Open(int x, int y, string title);

		}

		class ModalDialog : WindowsWindow
		{
			public void Move(int x, int y)
			{
				Console.WriteLine("create"); ;
			}

			public void Open(int x, int y, string title)
			{
				throw new NotImplementedException();
			}
		}
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
		}
	}
}
