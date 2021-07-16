using System;
using System.IO;

namespace HomeWorkDemo
{
	public class FileLogWriterSingletonBadPractice : BaseLogWriter
	{
		private static string _fileName;

		public static string FileName
		{
			get { return _fileName; }
			set
			{
				if (_instance != null)
				{
					throw new InvalidOperationException("File log writer instance already initialized. We are very sorry.");
				}

				_fileName = value;
			}
		}

		private static FileLogWriterSingletonBadPractice _instance;

		public static FileLogWriterSingletonBadPractice GetInstance()
		{
			if (_instance == null)
			{
				_instance = new FileLogWriterSingletonBadPractice(FileName);
			}

			return _instance;
		}

		private StreamWriter _logFileWriter;

		private FileLogWriterSingletonBadPractice(string fileName)
		{
			_logFileWriter = new StreamWriter(
				File.Open(
					fileName,
					FileMode.OpenOrCreate,
					FileAccess.ReadWrite,
					FileShare.Read));

			_logFileWriter.BaseStream.Seek(0, SeekOrigin.End);
		}

		public override void Dispose()
		{
			if (_logFileWriter != null)
				_logFileWriter.Dispose();
		}

		public override void LogRecord(string record)
		{
			_logFileWriter.WriteLine(record);
		}
	}
}
