using System;

namespace Events_Demo
{
	public class Worker
	{
		public string Name { get; set; }

		public event EventHandler<WorkPerformedEventArgs> WorkPerformed;

		public event EventHandler WorkComplete;
		public Worker()
		{

		}
		public Worker(string name)
		{
			Name = name;
		}
		public virtual void DoWork(int hours, WorkType workType)
		{
			for (int i = 0; i < hours; i++)
			{
				for (int j = 0; j < 100000; j++) ;
				var e = new WorkPerformedEventArgs
				{
					Hours = i + 1,
					WorkType = workType
				};

				OnWorkPerformed(this,e);
			}

			OnWorkComplete(this, EventArgs.Empty);

			//if (WorkComplete != null)
			//{
			//	WorkComplete(this , EventArgs.Empty);
			//}
		}
		protected virtual void OnWorkPerformed(object sender, WorkPerformedEventArgs e)
		{
			WorkPerformed?.Invoke(sender, e);// если не null,то вызовем invoke
		}

		protected virtual void OnWorkComplete(object sender, EventArgs e)
		{
			WorkComplete?.Invoke(sender, e);
		}
	}

}
