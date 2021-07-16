using System;
using System.Threading;

namespace Events_Demo
{
	class Program
	{
		
		static void Main(string[] args)
		{
			

			Thread threadForAlice = new Thread(() =>
			  {
				  Worker workerAlice = new Worker("Alice");
				  workerAlice.WorkPerformed += OnWorkerWorkPerformed;
				  workerAlice.WorkComplete += OnWorkerWorkComplete;
				  workerAlice.DoWork(20, WorkType.Work);
			  });

			Thread threadForBob = new Thread(() =>
			  {
				  Worker workerBob = new Worker("Bob");
				  workerBob.WorkPerformed += OnWorkerWorkPerformed;
				  workerBob.WorkComplete += OnWorkerWorkComplete;
				  workerBob.DoWork(5, WorkType.DoNothing);
			  });
			threadForAlice.Start();
			threadForBob.Start();

			threadForAlice.Join();
			threadForBob.Join();

		}

		private static void OnWorkerWorkPerformed(int hours, WorkType workType)
		{
			Console.WriteLine($"1 Work of type' { workType}' performed for about { hours} hours");
		}

		static void OnWorkerWorkComplete(object sender, EventArgs e)
		{
			if (sender != null)
				Console.WriteLine($"{((Worker)sender).Name} has finished his work!");
		}
	}
}
