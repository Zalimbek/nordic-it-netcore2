using System;
using System.Collections.Generic;
using System.Text;

namespace LogInterface
{
	class MultipleLogWriter:ILogWriter
	{

		public MultipleLogWriter(ILogWriter info, ILogWriter error, ILogWriter warning)//-что значит принимать коллекцию классов? непосредственно сами методы?
		{
			LogInfo = info;

		}

		public void LogInfo(string message)
		{
			Console.WriteLine("{0:yyyy-MM-ddThh:mm:ss+0000}\tInfo\t{1}", DateTime.UtcNow, message);
		}
		public void LogError(string message)
		{

			Console.WriteLine("{0:yyyy-MM-ddThh:mm:ss+0000}\tError\t{1}", DateTime.UtcNow, message);
		}
		public void LogWarning(string message)
		{
			Console.WriteLine("{0:yyyy-MM-ddThh:mm:ss+0000}\tWarning\t{1}", DateTime.UtcNow, message);
		}
}
