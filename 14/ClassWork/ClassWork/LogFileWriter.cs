using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Interface_Idesposable
{
	class LogFileWriter : IDisposable
		{
		private StreamWriter _logFileWriter;
		public string LogFileName { get; private set; }

		public LogFileWriter(string fileName)
		{
			LogFileName = fileName;
			Stream stream = File.Open(
				LogFileName,
				FileMode.OpenOrCreate,
				FileAccess.ReadWrite,
				FileShare.Read);

			//System.IO.File -write to the file- static class 
			_logFileWriter = new StreamWriter(stream);
		}

		public void WriteToLog(string logRecord)
		{
			_logFileWriter.WriteLine(
				
				"{0:yyyy-MM-dd hh:mm:ss.fff}+00:00\t{1}", DateTime.UtcNow,logRecord);
			_logFileWriter.Flush();
		}

		public void Dispose()
		{
			if (_logFileWriter != null)
				_logFileWriter.Dispose();

		}
		//public void CloseFileStream()
		//{
		//	_logFileWriter?.Close();
		//}
	}
}
