using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Collections;

namespace HomeWork
{
	class MultipleLogWriter : ILogWriter, IDisposable
	{
		private ILogWriter[] _internalWriters;

		public MultipleLogWriter(ILogWriter[] logWriters)
		{
			_internalWriters = logWriters;
		}

		public void LogInfo(string message)
		{
			foreach (ILogWriter writer in _internalWriters)
			{
				writer.LogInfo(message);
			}
		}
		public void LogError(string message)
		{
			foreach (ILogWriter writer in _internalWriters)
			{
				writer.LogError(message);
			}
		}
		public void LogWarning(string message)
		{
			foreach (ILogWriter writer in _internalWriters)
			{
				writer.LogWarning(message);
			}
		}
		public void Dispose()
		{
			foreach (var logWriter in _internalWriters)
			{
				if (logWriter is IDisposable && logWriter!= null)
					(logWriter as IDisposable).Dispose();
			}
		}
	}
}
