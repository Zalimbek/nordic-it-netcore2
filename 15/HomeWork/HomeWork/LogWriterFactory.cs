using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork
{
	class LogWriterFactory
	{
		public T GetLogWriter<T>(object parameters) where T : ILogWriter,new ()
		{
			if (T.Equals(ConsoleLogWriter))
			{
				return new T();
			}

			if (typeof(T) == "FileLogWriter")
			{
				return new T(string fileName);
			}

			else if (typeof(T) == MultipleLogWriter)
			{

				return new T(ILogWriter[] logWriters);
			}

		}
	}
}
