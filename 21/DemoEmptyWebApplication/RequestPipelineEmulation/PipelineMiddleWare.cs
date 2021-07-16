using System;
using System.Collections.Generic;
using System.Text;

namespace RequestPipelineEmulation
{
	public class PipelineMiddleWare
	{
		public string Name;
		public PipelineMiddleWare NextMiddleWare { get; set; }

		public Func<string, string> PreAction { get; set; }
		public Func<string, string> PostAction { get; set; }

		public string Run(string request)
		{
			Console.WriteLine($"Running {Name} started...");
			string request1 = PreAction?.Invoke(request);
			string request2 = NextMiddleWare?.Run(request1);
			string request3 = PostAction?.Invoke(request2);
			Console.WriteLine($"Running {Name} finished...");
			return request3;
		}
	}
}
