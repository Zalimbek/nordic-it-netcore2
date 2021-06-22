using System;
using System.Collections.Generic;

namespace LogInterface
{
	class Program
	{
		static void Main(string[] args)
		{
			using var fileLogWriter1 = new FileLogWriter(@"C:\Users\zalimbekova\test1_log.txt");
			//fileLogWriter1.LogInfo("starting the system");
			//fileLogWriter1.LogWarning("the disc is almost full");
			//fileLogWriter1.LogError("the system has crashed");

			var consoleWriter1 = new ConsoleLogWriter();
			//consoleWriter1.LogInfo("starting the system");
			//var consoleWriter2 = new ConsoleLogWriter();
			//consoleWriter2.LogWarning("the disc is almost full");
			//var consoleWriter3 = new ConsoleLogWriter();
			//consoleWriter3.LogError("the system has crashed");

			using (var logger = new MultipleLogWriter())
			{
				//logger.Add(fileLogWriter1);
				logger.Add(consoleWriter1);
				logger.LogInfo("Test information message");
				//logger.LogWarning("Test warning message");
				//logger.LogError("Test error message");
			}

		}
	}
}
