using System;

namespace LogInterface
{
	class Program
	{
		static void Main(string[] args)
		{
			using var fileLogWriter1 = new FileLogWriter();
			((ILogWriter)fileLogWriter1).LogInfo("starting the system");
			((ILogWriter)fileLogWriter1).LogWarning("the disc is almost full");
			((ILogWriter)fileLogWriter1).LogError("the system has crashed");

			using var shellForLogs = new ConsoleLogWriter();
			shellForLogs.Add( );// как здесь указать конструктор, если у него нет параметров? 

			//	; new FileLogWriter().LogWarning("the disc is almost full"),
			//	new FileLogWriter().LogError("the system has crashed");
		}
	}
}
