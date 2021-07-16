using System;
using System.IO;

namespace HomeWorkDemo
{	
	public class FileLogWriter : BaseLogWriter
	{
		private StreamWriter _logFileWriter;

		public FileLogWriter(string fileName)
		{
			_logFileWriter = new StreamWriter(
				File.Open(
					fileName,
					FileMode.OpenOrCreate,
					FileAccess.ReadWrite,
					FileShare.Read));

			_logFileWriter.BaseStream.Seek(0, SeekOrigin.End);
		}

		public override void Dispose()
		{
			if (_logFileWriter != null)
				_logFileWriter.Dispose();
		}
		
		public override void LogRecord(string record)
		{
			_logFileWriter.WriteLine(record);
		}
	}
}
