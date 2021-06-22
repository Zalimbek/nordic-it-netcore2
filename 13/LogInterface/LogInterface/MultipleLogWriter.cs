using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Collections;

namespace LogInterface
{
	class MultipleLogWriter : ILogWriter, IDisposable, IEnumerable<ILogWriter>
	{
		//private List<ILogWriter> _internalWriters;
		//public MultipleLogWriter()
		//{
		//	_internalWriters = new List<ILogWriter>();
		//}
		private List<ILogWriter> _internalWriters;
		public void Add(ILogWriter logFileWriter)
		{
			_internalWriters.Add(logFileWriter);
		}
		public MultipleLogWriter()
		{
			_internalWriters = new List<ILogWriter>();
		}
		public string LogFileName { get; private set; }
		private StreamWriter _fileLogWriter;
		public void FileLogWriter()
		{
			LogFileName = @"C:\Users\zalimbekova\test1_log.txt";
			Stream stream = File.Open(
				LogFileName,
				FileMode.OpenOrCreate,
				FileAccess.ReadWrite,
				FileShare.Read);
			_fileLogWriter = new StreamWriter(stream);
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

			if (_fileLogWriter != null)
				_fileLogWriter.Dispose();
			//if (_internalWriters != null)
										 //{
										 //	{
										 //		_internalWriters.Clear();
										 //		_internalWriters = null;
										 //	}
										 //}
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
