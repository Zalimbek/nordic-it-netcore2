using System;
using System.Collections.Generic;
using System.Text;

namespace LogInterface
{
	class MultipleLogWriter:ILogWriter
	{

		public MultipleLogWriter(FileLogWriter fileLog, ConsoleLogWriter consoleLog)//-что значит принимать коллекцию классов? непосредственно сами методы?
		{
			FileLogWriter = fileLog;
			ConsoleLogWriter = consoleLog;

		}

}
