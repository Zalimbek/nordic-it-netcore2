using System;
using System.Collections;
using System.Collections.Generic;

namespace HomeWorkDemo
{
	public class MultipleLogWriter : ILogWriter, IEnumerable<ILogWriter>
	{
		private List<ILogWriter> _logWriters;

		public MultipleLogWriter(List<ILogWriter> logWriters)
		{
			_logWriters = logWriters;
		}

		public void Dispose()
		{
			foreach (var logWriter in _logWriters)
			{
				if (logWriter is IDisposable && logWriter != null)
					(logWriter as IDisposable).Dispose();
			}
		}

		public void LogError(string message)
		{
			foreach (ILogWriter logWriter in _logWriters)
			{
				logWriter.LogError(message);
			}
		}

		public void LogInfo(string message)
		{
			foreach (ILogWriter logWriter in _logWriters)
			{
				logWriter.LogInfo(message);
			}
		}

		public void LogWarning(string message)
		{
			foreach (ILogWriter logWriter in _logWriters)
			{
				logWriter.LogWarning(message);
			}
		}

		public IEnumerator<ILogWriter> GetEnumerator()
		{
			return _logWriters.GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return _logWriters.GetEnumerator();
		}
	}
}
