using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace LogInterface
{
	class ConsoleLogWriter : ILogWriter
	{

		public ConsoleLogWriter()
		{
		}
		public void LogInfo(string message)
		{
			Console.WriteLine("{0:yyyy-MM-ddThh:mm:ss+0000}\tInfo\t{1}", DateTime.UtcNow, message);
		}
		public void LogError(string message)
		{

			Console.WriteLine("{0:yyyy-MM-ddThh:mm:ss+0000}\tError\t{1}", DateTime.UtcNow, message);
		}
		public void LogWarning(string message)
		{
			Console.WriteLine("{0:yyyy-MM-ddThh:mm:ss+0000}\tWarning\t{1}", DateTime.UtcNow, message);
		}

	}
}
