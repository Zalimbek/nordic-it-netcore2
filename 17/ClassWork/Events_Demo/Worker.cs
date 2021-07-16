using System;

namespace Events_Demo
{
	public class Worker
	{
		public string Name { get; set; }

		public event WorkPerformedEventHandler WorkPerformed;

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
				OnWorkPerformed(i + 1, workType);
			}

			OnWorkComplete(this, EventArgs.Empty);

			//if (WorkComplete != null)
			//{
			//	WorkComplete(this , EventArgs.Empty);
			//}
		}
		protected virtual void OnWorkPerformed(int hours, WorkType workType)
		{
			WorkPerformed?.Invoke(hours, workType);// если не null,то вызовем invoke
		}

		protected virtual void OnWorkComplete(object sender, EventArgs e)
		{
			WorkComplete?.Invoke(sender, e);
		}
	}

}
