using System;
using System.Collections.Generic;

namespace LogInterface
{
	class Program
	{
		static void Main(string[] args)
		{
			using var fileLogWriter1 = new FileLogWriter(@"C:\Users\zalimbekova\test1_log.txt");
			//((ILogWriter)fileLogWriter1).LogInfo("starting the system");
			//((ILogWriter)fileLogWriter1).LogWarning("the disc is almost full");
			//((ILogWriter)fileLogWriter1).LogError("the system has crashed");

			var consoleWriter1 = new ConsoleLogWriter();
			//((ILogWriter)logMessage1).LogInfo("starting the system");
			//var logMessage2 = new ConsoleLogWriter();
			//((ILogWriter)logMessage2).LogWarning("the disc is almost full");
			//var logMessage3 = new ConsoleLogWriter();
			//((ILogWriter)logMessage3).LogError("the system has crashed");

			//var logger = new List<MultipleLogWriter>();
			//logger.Add(new FileLogWriter(@"C:\Users\zalimbekova\test1_log.txt"));
			using (var logger = new MultipleLogWriter())
			{
				logger.Add(fileLogWriter1);
				logger.Add(consoleWriter1);
				logger.LogInfo("Test information message");
				logger.LogWarning("Test warning message");
				logger.LogError("Test error message");
			}

		}
	}
}
