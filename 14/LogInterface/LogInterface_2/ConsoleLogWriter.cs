using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace LogInterface_2
{
	class ConsoleLogWriter : ILogWriter
	{


		public ConsoleLogWriter()
		
		public void LogInfo(string message)
		{
			string record = GetLogRecord(message, logRecordType.Info);
			//"{0:yyyy-MM-ddThh:mm:ss+0000}\tInfo\t{1}", DateTime.UtcNow, message);
		}
		public void LogError(string message)
		{

			Console.WriteLine("{0:yyyy-MM-ddThh:mm:ss+0000}\tError\t{1}", DateTime.UtcNow, message);
		}
		public void LogWarning(string message)
		{
			Console.WriteLine("{0:yyyy-MM-ddThh:mm:ss+0000}\tWarning\t{1}", DateTime.UtcNow, message);
		}

		private string GetLogRecord(string message, string logRecordType )
		{
			return string.Format(_logrecordFormat, DateTime.UtcNow, logRecordType, message);
		}

		private void LogRecord(string record)
		{
			Console.WriteLine();
		}

	}
}
