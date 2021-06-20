using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace LogInterface
{
	class ConsoleLogWriter: IEnumerable<FileLogWriter>, IDisposable, ILogWriter
	{
		private List<FileLogWriter> _shellForlogs;

		public ConsoleLogWriter()
		{
			_shellForlogs = new List<FileLogWriter>();
		}

		public void Add(FileLogWriter certainLog)
		{
			_shellForlogs.Add(certainLog);
		}
		public void LogInfo(string message)
		{
			Console.WriteLine("{0:yyyy-MM-ddThh:mm:ss+0000}\tInfo\t{1}", DateTime.UtcNow, message);
		}
		public void LogError(string message)
		{

			Console.WriteLine("{0:yyyy-MM-ddThh:mm:ss+0000}\tError\t{1}", DateTime.UtcNow, message);
		}
		public void LogWarning(string message)
		{
			Console.WriteLine("{0:yyyy-MM-ddThh:mm:ss+0000}\tWarning\t{1}", DateTime.UtcNow, message);
		}

		public void Dispose()
		{
			if (_shellForlogs != null)
			{
				foreach (FileLogWriter writer in _shellForlogs)
				{
					writer?.Dispose();
				}
			}
		}
		public IEnumerator<FileLogWriter> GetEnumerator()
		{
			return _shellForlogs.GetEnumerator();
		}
		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}
}
