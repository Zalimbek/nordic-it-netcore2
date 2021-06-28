using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ErrorList_program
{
	class ErrorList : IDisposable, IEnumerable<string>
	{
		public string CategoryName { get; private set; }
		private List<string> _errors { get; set; }
		public ErrorList(string category)
		{
			CategoryName = category;
			_errors = new List<string>();
		}
		public static string OutputPrefixFormat { get; set; }

		static ErrorList()
		{
			OutputPrefixFormat = "{0:MM dd, yyyy (hh:mm tt}";
		}
		
		public void Add(string  error)
		{
			_errors.Add(error);
		}
		public void Dispose()
		{
			if (_errors != null)
			{
				{
					_errors.Clear();
					_errors = null;
				}
			}
		}

		public IEnumerator<string> GetEnumerator()
		{
			return _errors.GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
		public void WriteToConsole()
		{
			foreach (var error in _errors)
			{
				Console.WriteLine(DateTime.Now.ToString(OutputPrefixFormat) + ":" + CategoryName + error);
			}

		}
	}
}
