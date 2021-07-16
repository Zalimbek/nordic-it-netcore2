using System;
using System.Collections.Generic;
using System.Text;

namespace Events_Demo
{
	public class WorkPerformedEventArgs: EventArgs
	{
		public int Hours { get; set; }
		public WorkType WorkType { get; set; }


	}
}
