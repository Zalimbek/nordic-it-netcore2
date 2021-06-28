using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace LogInterface
{
	class FileLogWriter : ILogWriter, IDisposable
	{
		private static string _fileName;

		public static string FileName {
			get { return _fileName; }
			set 
			{
				if (_instance != null)
				{
					throw new InvalidOperationException("File log writer has initialized");
				}
				_fileName = value;
			}
		}
		private static FileLogWriter _instance;

		private StreamWriter _fileLogWriter;

		private readonly string _logFormat = "{0:yyyy-MM-ddThh:mm:ss+0000}\t{1}\t{2}";

		public static FileLogWriter GetInstance()
		{
			if (_instance == null)
			{
				_instance = new FileLogWriter(FileName);
			}
			return _instance;
		}
		private FileLogWriter(string fileName)
		{
			_fileName = fileName;
			Stream stream = File.Open(
				fileName,
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
