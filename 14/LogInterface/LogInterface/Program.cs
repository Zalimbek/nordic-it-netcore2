using System;
using System.Collections.Generic;

namespace LogInterface
{
	class Program
	{
		static void Main(string[] args)
		{ 
			ConsoleLogWriter consoleWriter1 = ConsoleLogWriter.GetInstance();
			//consoleWriter1.LogInfo("starting the system");
			//consoleWriter1.LogWarning("the disc is almost full");
			//consoleWriter1.LogError("the system has crashed");

			FileLogWriter.FileName = @"C:\Users\zalimbekova\log1.txt";
			using FileLogWriter fileLog1 = FileLogWriter.GetInstance();

			//fileLog1.LogInfo("starting the system");
			//fileLog1.LogWarning("the disc is almost full");
			//fileLog1.LogError("the system has crashed");

			MultipleLogWriter._internalWriters = new[] { (ILogWriter)fileLog1, consoleWriter1 }; 
			using MultipleLogWriter logwriter = MultipleLogWriter.GetInstance();
			logwriter.LogInfo("starting the system");
			logwriter.LogWarning("the disc is almost full");
			logwriter.LogError("the system has crashed");

		}
	}
}
