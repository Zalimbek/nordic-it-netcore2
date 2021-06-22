using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace LogInterface_2
{
	class FileLogWriter : ILogWriter, IDisposable
	{
		public string LogFileName { get; private set; }

		private StreamWriter _fileLogWriter;
		public FileLogWriter(string fileName)
		{
			LogFileName = fileName;
			Stream stream = File.Open(
				LogFileName,
				FileMode.OpenOrCreate,
				FileAccess.ReadWrite,
				FileShare.Read);
			_fileLogWriter = new StreamWriter(stream);
		}

		public void LogInfo(string message)
		{
			_fileLogWriter.WriteLine(
				"{0:yyyy-MM-ddThh:mm:ss+0000}\tInfo\t{1}", DateTime.UtcNow, message);
			_fileLogWriter.Flush();
		}
		public void LogError(string message)
		{
			_fileLogWriter.WriteLine(
				"{0:yyyy-MM-ddThh:mm:ss+0000}\tError\t{1}", DateTime.UtcNow, message);
			_fileLogWriter.Flush();
		}
		public void LogWarning(string message)
		{
			_fileLogWriter.WriteLine(
				"{0:yyyy-MM-ddThh:mm:ss+0000}\tWarning\t{1}", DateTime.UtcNow, message);
			_fileLogWriter.Flush();
		}

		public void Dispose()
		{
			if (_fileLogWriter != null)
				_fileLogWriter.Dispose();
		}
	}
}
