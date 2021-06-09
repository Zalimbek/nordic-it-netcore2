using System;

namespace factory
{
	class Program
	{
		static void Main(string[] args)
		{
			ButtonFactory buttonFactory = new ButtonFactory();
			Button[] buttons = new Button[10];
			for (int i = 0; i < buttons.Length; i++)
			{
				buttonFactory.PushButtonOnCreate = i < 5;
				buttons[i] = buttonFactory.CreateButton();
			}

			foreach (var button in buttons)
			{
				var state = button.IsPushed ? "pushed" : "not pushed";
				Console.WriteLine($"Button state is {state}");
			}
		}
	}
}
