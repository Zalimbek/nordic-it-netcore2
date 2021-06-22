using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Collections;

namespace LogInterface_2
{
	class MultipleLogWriter : ILogWriter, IDisposable,IEnumerable<ILogWriter>
	{
		
		private ILogWriter[] _internalWriters;
		public MultipleLogWriter(ILogWriter[] internalWriters)
		{
			_internalWriters = internalWriters;
		}

		//private StreamWriter _fileLogWriter;
		//public FileLogWriter(string fileName)
		//{
		//	LogFileName = fileName;
		//	Stream stream = File.Open(
		//		LogFileName,
		//		FileMode.OpenOrCreate,
		//		FileAccess.ReadWrite,
		//		FileShare.Read);
		//	_fileLogWriter = new StreamWriter(stream);
		//}

		//public void LogInfo(string message)
		//{
		//	foreach (ILogWriter writer in _internalWriters)
		//	{
		//		Console.WriteLine("{ 0:yyyy-MM-ddThh:mm:ss+0000}\tInfo\t{1}", DateTime.UtcNow, message);
		//		_fileLogWriter.WriteLine(
		//		"{0:yyyy-MM-ddThh:mm:ss+0000}\tInfo\t{1}", DateTime.UtcNow, message);
		//		_fileLogWriter.Flush();

		//	}
			
		//}
		//public void LogError(string message)
		//{

		//	LogFileName = @"C:\Users\zalimbekova\test1_log.txt";
		//	Stream stream = File.Open(
		//		LogFileName,
		//		FileMode.OpenOrCreate,
		//		FileAccess.ReadWrite,
		//		FileShare.Read);
		//	_fileLogWriter = new StreamWriter(stream);
		//	foreach (ILogWriter writer in _internalWriters)
		//	{
		//		Console.WriteLine("{ 0:yyyy-MM-ddThh:mm:ss+0000}\tError\t{1}", DateTime.UtcNow, message);
		//		_fileLogWriter.WriteLine(
		//		"{0:yyyy-MM-ddThh:mm:ss+0000}\tError\t{1}", DateTime.UtcNow, message);
		//		_fileLogWriter.Flush();

		//	}
		//}
		//public void LogWarning(string message)
		//{
		//	LogFileName = @"C:\Users\zalimbekova\test1_log.txt";
		//	Stream stream = File.Open(
		//		LogFileName,
		//		FileMode.OpenOrCreate,
		//		FileAccess.ReadWrite,
		//		FileShare.Read);
		//	_fileLogWriter = new StreamWriter(stream);
		//	foreach (ILogWriter writer in _internalWriters)
		//	{
		//		Console.WriteLine("{ 0:yyyy-MM-ddThh:mm:ss+0000}\tWarning\t{1}", DateTime.UtcNow, message);
		//		_fileLogWriter.WriteLine(
		//		"{0:yyyy-MM-ddThh:mm:ss+0000}\tWarning\t{1}", DateTime.UtcNow, message);
		//		_fileLogWriter.Flush();

		//	}
		//}
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


		public IEnumerator<ILogWriter> GetEnumerator()
		{
			throw new NotImplementedException();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			throw new NotImplementedException();
		}
	}
}
