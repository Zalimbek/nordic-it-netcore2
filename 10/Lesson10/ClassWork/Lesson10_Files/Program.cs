using System;
using System.IO;
using System.Text;
namespace Lesson10_Files
{
	class Program
	{
		static void Main(string[] args)
		{
			const string fileName = @"c:\test.txt";
			const string testMessage = @"Hello World";

			byte[] messageBytes = Encoding.UTF8.GetBytes(testMessage);
			FileStream fileStream = File.Open(fileName, FileMode.Create, FileAccess.Write, FileShare.Read);

			fileStream.Write(messageBytes);
			fileStream.Close();
		}
	}
}
