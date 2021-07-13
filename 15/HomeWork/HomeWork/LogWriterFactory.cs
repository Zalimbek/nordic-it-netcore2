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
		public static ILogWriter GetLogWriter<T>(object parameters) where T : ILogWriter
		{

			
			if (typeof(T)==typeof(ConsoleLogWriter))
			{
				return new ConsoleLogWriter();
			}

			else if (typeof(T) == typeof(FileLogWriter))
			{
				if (parameters.GetType() != typeof(string))
					throw new ArgumentException($"Parameter \" {nameof(parameters)}\" " +
												$"is assumed to be a string with a file name for " +
												$"\"{typeof(T)}\"",nameof(parameters));
				return new FileLogWriter((string)parameters);
			}

			else if (typeof(T) == typeof(MultipleLogWriter))
			{
				
				if (parameters.GetType() != typeof(ILogWriter[]))
					throw new ArgumentException($"Parameter \" {nameof(parameters)}\" " +
												$"is assumed to be an ILogWriter[] with internal log writers" +
												$"\"{typeof(T)}\"", nameof(parameters));
				return new MultipleLogWriter((ILogWriter[])parameters);
			}
			else
				throw new NotImplementedException();

		}
	}
}
