using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork
{
	class LogWriterFactory
	{
		public ILogWriter GetLogWriter<T>(object parameters) where T : ILogWriter
		{
			if (T is ConsoleLogWriter)
			{
				return new T();
			}

			if (typeof(T) == FileLogWriter)
			{
				return new T(string fileName);
			}

			if (typeof(T) == MultipleLogWriter)
			{

				return new T(ILogWriter[] logWriters);
			}

		}
	}
}
