using System;

namespace HomeWorkDemo
{
	public interface ILogWriter: IDisposable
	{
		void LogInfo(string message);

		void LogWarning(string message);

		void LogError(string message);
	}
}
