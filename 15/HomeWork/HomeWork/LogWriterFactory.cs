using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork
{
	public static class LogWriterFactory
	{
		//private static LogWriterFactory _instance;
		//public static LogWriterFactory GetInstance()
		//{
		//	if (_instance == null)
		//	{
		//		_instance = new LogWriterFactory();
		//	}
		//	return _instance;
		//}
		public static ILogWriter GetLogWriter<T>(object parameters) where T : ILogWriter,new()
		{
			
			ILogWriter result = new T();
			
			if (typeof(T)==typeof(ConsoleLogWriter))
			{
				parameters = null;
				return result;
			}

			else if (typeof(T) == typeof(FileLogWriter))
			{
				((FileLogWriter)result).LogFileName=(string)parameters;
			}

			else if (typeof(T) == typeof(MultipleLogWriter))
			{

				((MultipleLogWriter)result)._internalWriters = (ILogWriter[])parameters;
			}
			else
				throw new NotImplementedException();
			return result;

		}
	}
}
