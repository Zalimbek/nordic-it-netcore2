using System;
using System.Text;
using System.IO;

namespace Lesson08_working_with_file
{
	class Program
	{
		static void Main(string[] args)
		{
			const string fileName = @".\..\..\..\..\test.txt";
			const string testMessage = "Hello, world!";

			byte[] messageAnsiBytes = Encoding.ASCII.GetBytes(testMessage);

			File.WriteAllBytes(fileName, messageAnsiBytes);
			const string fileNameToRead = @".\..\..\..\read.txt";

			string fileContent = File.ReadAllText(fileNameToRead);
			Console.WriteLine(fileContent);

			Directory.CreateDirectory(@"d:\test");
		}
	}
}
