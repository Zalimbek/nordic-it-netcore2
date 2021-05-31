using System;
using System.Collections.Generic;

namespace Dicts
{
	class Program
	{
		static void Main(string[] args)
		{
			var contents = new Dictionary<string, long>()
			{
				{"Fisrt part", 1 },
				{"Second part", 5 },
				{ "Third part", 20}
			};

			contents.Add("Author's word", 0);
			contents.Add("Author's post word", 25);
			Console.WriteLine(contents["Second part"]);

			foreach (KeyValuePair<string, long>pair in contents)
			{
				if (pair.Value==5)
					Console.WriteLine(pair.Key);
					break;
			}
			Console.WriteLine(contents.ContainsKey("Editor's word"));
			contents["Second part"] = 10;
		}

	}
}
