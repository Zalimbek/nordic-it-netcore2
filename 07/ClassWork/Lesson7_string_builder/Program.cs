using System;
using System.Text;

namespace Lesson7_string_builder
{
	class Program
	{
		static void Main(string[] args)
		{
			string s = "Price";
			s += "|";
			s += "Quantity";
			s += "|";
			s += "Total";

			StringBuilder sb = new StringBuilder();
			s += "|";
			s += "Quantity";
			s += "|";
			s += "Total";
			sb.Remove(5, 13);
			sb.Insert(5, 25);
			sb.AppendFormat("Date: {0:yyyy-MM-dd}", DateTimeOffset.Now);
			if (sb.Length > 0)
			{
				var result = sb.ToString();
				Console.WriteLine(result);
			}
		}
	}
}
