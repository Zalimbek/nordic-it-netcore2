using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace HomeWork
{
	partial class ConsoleLogWriter : ILogWriter
	{
		private readonly string _logFormat = "{0:yyyy-MM-ddThh:mm:ss+0000}\t{1}\t{2}";

		public void LogInfo(string message)
		{
			string record= GetLogRecord(message, LogRecordType.Info);
			LogRecord(record);
		}

		public void LogError(string message)
		{
			string record = GetLogRecord(message,LogRecordType.Error);
			LogRecord(record);
		}

		public void LogWarning(string message)
		{
			string record = GetLogRecord(message, LogRecordType.Warning);
			LogRecord(record);
		}

		private string GetLogRecord(string message, LogRecordType logRecordType)
		{
			return  string.Format(_logFormat, DateTime.UtcNow,logRecordType, message);
		}

		private void LogRecord(string record)
		{
			Console.WriteLine(record);
		}
	}
}
