using System;
using System.Collections.Generic;

namespace HomeWork

{
	class Program
	{
		static void Main(string[] args)
		{
			//FileLogWriter fileLogWriter1 = new FileLogWriter(@"C:\Users\zalimbekova\test1_log.txt");
			//LogWriterFactory fileLogWriter1 = LogWriterFactory.GetInstance();
			using var fileLogWriter1 = (FileLogWriter)LogWriterFactory.GetLogWriter<FileLogWriter>(@"C:\Users\zalimbekova\test1_log.txt");

			var consoleWriter1 = (ConsoleLogWriter)LogWriterFactory.GetLogWriter<ConsoleLogWriter>(null);
			var multi = (MultipleLogWriter)LogWriterFactory.GetLogWriter<MultipleLogWriter>(new[] { (ILogWriter)fileLogWriter1, (ILogWriter)consoleWriter1 });

			///ConsoleLogWriter consoleWriter1 = new ConsoleLogWriter();

			//using var logwriter = new MultipleLogWriter(new[] { (ILogWriter)fileLogWriter1, (ILogWriter)consoleWriter1 });
			multi.LogInfo("starting the system");
			multi.LogWarning("the disc is almost full");
			multi.LogError("the system has crashed");

			//LogWriterFactory factory = new LogWriterFactory();
			//var log1 = factory.GetLogWriter<MultipleLogWriter<ILogWriter>>(ILogWriter);
		}
	}
}
