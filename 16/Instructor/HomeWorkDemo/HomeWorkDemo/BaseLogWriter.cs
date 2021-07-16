using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorkDemo
{
	public abstract class BaseLogWriter: ILogWriter
	{
		private readonly string _logRecordFormat = "{0:yyyy-MM-ddTHH:mm:ss}+0000\t{1}\t{2}";

		public void LogError(string message)
		{
			string record = GetLogRecord(message, LogRecordType.Error);
			LogRecord(record);
		}

		public void LogInfo(string message)
		{
			string record = GetLogRecord(message, LogRecordType.Info);
			LogRecord(record);
		}

		public void LogWarning(string message)
		{
			string record = GetLogRecord(message, LogRecordType.Warning);
			LogRecord(record);
		}

		private string GetLogRecord(string message, LogRecordType logRecordType)
		{
			return string.Format(
				_logRecordFormat,
				DateTime.UtcNow,
				logRecordType,
				message);
		}

		abstract public void LogRecord(string record);

		virtual public void Dispose()
		{
		}
	}
}
