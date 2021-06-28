using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Collections;

namespace LogInterface
{
	class MultipleLogWriter : ILogWriter, IDisposable
	{
		public static ILogWriter[] _internalWriters;

		private static MultipleLogWriter _instance;
		public static ILogWriter logwriters

		{
			get { return logwriters; }
			set
			{
				if (_instance != null)
				{
					throw new InvalidOperationException("File log writer has initialized");
				}
				logwriters = value;
			}
		}

		public static MultipleLogWriter GetInstance()
		{
			if (_instance == null)
			{
				_instance = new MultipleLogWriter(_internalWriters);
			}
			return _instance;
		}

			private MultipleLogWriter(ILogWriter[] logWriters)
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
