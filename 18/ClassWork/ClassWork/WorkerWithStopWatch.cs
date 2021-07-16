using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace Events_Demo
{
	public class WorkerWithStopWatch: Worker
	{
		private long _lastWorkElapsedms = 0;
		public override void DoWork(int hours, WorkType workType)
		{
			Stopwatch sw = new Stopwatch();
			sw.Start();
			base.DoWork(hours, workType);
			sw.Stop();
			_lastWorkElapsedms = sw.ElapsedMilliseconds;
			Debug.WriteLine($"Worker ' {Name}' finished his work in {sw.ElapsedMilliseconds} ms");
		}

		protected override void OnWorkComplete(object sender, EventArgs e)
		{

			base.OnWorkComplete(sender, e);

		}
	}
}
