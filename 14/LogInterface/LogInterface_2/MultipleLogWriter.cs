using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Collections;

namespace LogInterface_2
{
	class MultipleLogWriter : ILogWriter, IDisposable
	{
		
		private ILogWriter[] _internalWriters;
		public MultipleLogWriter(ILogWriter[] internalWriters)
		{
			_internalWriters = internalWriters;
		}

		public void LogInfo(string message)
		{
			foreach (ILogWriter writer in _internalWriters)
			{
				Console.WriteLine("{0:yyyy-MM-ddThh:mm:ss+0000}\tInfo\t{1}", DateTime.UtcNow, message);
				"{0:yyyy-MM-ddThh:mm:ss+0000}\tInfo\t{1}", DateTime.UtcNow, message);
				_fileLogWriter.Flush();
			}
		}

		public void LogError(string message)
		{

			foreach (ILogWriter writer in _internalWriters)
			{
				Console.WriteLine("{ 0:yyyy-MM-ddThh:mm:ss+0000}\tError\t{1}", DateTime.UtcNow, message);
				//_fileLogWriter.WriteLine(
				//"{0:yyyy-MM-ddThh:mm:ss+0000}\tError\t{1}", DateTime.UtcNow, message);
				//_fileLogWriter.Flush();

			}
		}
		public void LogWarning(string message)
		{

			foreach (ILogWriter writer in _internalWriters)
			{
				Console.WriteLine("{ 0:yyyy-MM-ddThh:mm:ss+0000}\tWarning\t{1}", DateTime.UtcNow, message);
				//_fileLogWriter.WriteLine(
				//"{0:yyyy-MM-ddThh:mm:ss+0000}\tWarning\t{1}", DateTime.UtcNow, message);
				//_fileLogWriter.Flush();

			}
		}

		public void Dispose()
		{
			if (_internalWriters != null)
			{
				foreach (FileLogWriter writer in _internalWriters)
				{
					writer?.Dispose();
				}
			}
		}

	}
}
