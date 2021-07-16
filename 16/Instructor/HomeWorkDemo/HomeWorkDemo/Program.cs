using System;
using System.Collections.Generic;

namespace HomeWorkDemo
{
	class Program
	{
		static void Main(string[] args)
		{
			ConsoleLogWriter lw1 = new ConsoleLogWriter();

			//lw1.LogInfo("info test");
			//lw1.LogWarning("warning test");
			//lw1.LogError("error test");

			FileLogWriter lw2 = new FileLogWriter("log.txt");

			//lw2.LogInfo("info test");
			//lw2.LogWarning("warning test");
			//lw2.LogError("error test");

			using var lw3 = new MultipleLogWriter(new List<ILogWriter> { (ILogWriter)lw1, (ILogWriter)lw2 });
			lw3.LogInfo("info test *");
			lw3.LogWarning("warning test *");
			lw3.LogError("error test *");

			foreach (ILogWriter internalWriter in lw3)
			{
				internalWriter.LogInfo("test from ienumerable");
			}

			FileLogWriterSingletonBadPractice.FileName = @"c:\log.txt";
			FileLogWriterSingletonBadPractice.FileName = @"c:\log2.txt";
			FileLogWriterSingletonBadPractice.FileName = @"c:\log3.txt";
			FileLogWriterSingletonBadPractice fw = FileLogWriterSingletonBadPractice.GetInstance();

			FileLogWriterSingletonBadPractice.FileName = @"c:\log2.txt";
			FileLogWriterSingletonBadPractice fw2 = FileLogWriterSingletonBadPractice.GetInstance();
		}
	}
}
