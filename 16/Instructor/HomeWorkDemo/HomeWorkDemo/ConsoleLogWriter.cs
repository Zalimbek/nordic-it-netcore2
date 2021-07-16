using System;

namespace HomeWorkDemo
{
	public class ConsoleLogWriter : BaseLogWriter
	{
		public override void LogRecord(string record)
		{
			Console.WriteLine(record);
		}
	}
}
