using System;
using System.Collections.Generic;

namespace LogInterface
{
	class Program
	{
		static void Main(string[] args)
		{
			FileLogWriter fileLogWriter1 = new FileLogWriter(@"C:\Users\zalimbekova\test1_log.txt");

			ConsoleLogWriter consoleWriter1 = new ConsoleLogWriter();

			using var logwriter = new MultipleLogWriter(new[] { (ILogWriter)fileLogWriter1, (ILogWriter)consoleWriter1 });
			logwriter.LogInfo("starting the system");
			logwriter.LogWarning("the disc is almost full");
			logwriter.LogError("the system has crashed");
		}
	}
}
