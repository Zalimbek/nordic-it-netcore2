using System;

namespace Interface_Idesposable
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Log writing is running");
			using (var logFileWriter1 = new LogFileWriter(@"C:\Users\zalimbekova\test_log.txt"))
			{
				logFileWriter1.WriteToLog("test log record 1");
				logFileWriter1.WriteToLog("test log record 2");
			}

			using var logFileWriter = new LogFileWriter(@"C:\Users\zalimbekova\test_log.txt");
			logFileWriter.WriteToLog("test log record 1");
			logFileWriter.WriteToLog("test log record 2");

			//logFileWriter.WriteToLog("test log record");
			//logFileWriter.CloseFileStream();

			using var logFileWriters = new LogFileWriterList();
			logFileWriters.Add(new LogFileWriter(@"C:\Users\zalimbekova\test1_log.txt"));
			logFileWriters.Add(new LogFileWriter(@"C:\Users\zalimbekova\test2_log.txt"));

			foreach (LogFileWriter writer in logFileWriters)
			{
				writer.WriteToLog("test");
			}
		}
	}
}
