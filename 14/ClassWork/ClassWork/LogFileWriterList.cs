using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Interface_Idesposable
{
	class LogFileWriterList : IEnumerable<LogFileWriter>, IDisposable
	{
		private List<LogFileWriter> _logFileWriters;
		public LogFileWriterList()
		{
			_logFileWriters = new List<LogFileWriter>();
		}

		public void Add(LogFileWriter logFileWriter)
		{
			_logFileWriters.Add(logFileWriter);
		}

		public void Dispose()
		{
			if (_logFileWriters != null)
			{
				foreach (LogFileWriter writer in _logFileWriters)
				{
					writer?.Dispose();
				}
			}
		}

		public IEnumerator<LogFileWriter> GetEnumerator()
		{
			return _logFileWriters.GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}

}
