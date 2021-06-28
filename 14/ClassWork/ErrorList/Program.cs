using System;

namespace ErrorList_program
{
	class Program
	{
		static void Main(string[] args)
		{
			using (var errors = new ErrorList("Fatal Error"))
			{
				string prefixFormat = "{0:MM dd, yyyy (hh:mm}\t{1}";
				string prefix = DateTime.Now.ToString(prefixFormat);
				errors.Add("I/O error");
				errors.Add("Some weird thing");

				foreach(string error in errors)
				{
					Console.WriteLine(errors.CategoryName+":"+error) ;
				}
			}
		}
	}
}
