using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace HomeWork
{
	class FileLogWriter : ILogWriter, IDisposable
	{
		public string LogFileName { get; set; }

		private StreamWriter _fileLogWriter;

		private readonly string _logFormat = "{0:yyyy-MM-ddThh:mm:ss+0000}\t{1}\t{2}";
		public FileLogWriter(string fileName)
		{
			LogFileName = fileName;
			Stream stream = File.Open(
				LogFileName,
				FileMode.OpenOrCreate,
				FileAccess.ReadWrite,
				FileShare.Read);
			_fileLogWriter = new StreamWriter(stream);
			_fileLogWriter.BaseStream.Seek(0, SeekOrigin.End);
		}

		public void LogInfo(string message)
		{
			string record = GetLogRecord(message, LogRecordType.Info);
			LogRecord(record);
		}

		public void LogError(string message)
		{
			string record = GetLogRecord(message, LogRecordType.Error);
			LogRecord(record);
		}

		public void LogWarning(string message)
		{
			string record = GetLogRecord(message, LogRecordType.Warning);
			LogRecord(record);
		}

		private string GetLogRecord(string message, LogRecordType logRecordType)
		{
			return string.Format(_logFormat, DateTime.UtcNow, logRecordType, message);
		}

		private void LogRecord(string record)
		{
			_fileLogWriter.WriteLine(record);
		}

		public void Dispose()
		{
			if (_fileLogWriter != null)
				_fileLogWriter.Dispose();
		}
	}
}
