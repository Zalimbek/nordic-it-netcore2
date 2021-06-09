using System;

namespace ClassWork
{
	partial class Program
	{
		static void Main(string[] args)
		{
			//BaseDocument doc2 = new BaseDocument();
			//Passport doc1 = new Passport();
			//doc2.DocName = "Personal ID";
			//doc2.DocNumber = "12345";
			//doc2.IssueDate= DateTimeOffset.Parse("2012-01-01");
			//doc2.PersonName = "Alex";
			//doc2.Country = "USA";

			//doc1.DocName = "Personal ID";
			//doc1.DocNumber = "12345";
			//doc1.IssueDate = DateTimeOffset.Parse("2012-01-01");
			//doc1.PersonName = "Alex";
			//doc1.Country = "USA";
			//doc1.Equals(doc2);

			var docs = new BaseDocument[2];
			docs[0] = new BaseDocument("A", "B", DateTimeOffset.Parse("2012-01-01"));
			docs[2] = new BaseDocument("A", "B", DateTimeOffset.Parse("2012-01-02"));
			docs[3] = new Passport("C", DateTimeOffset.Parse("2012-01-03"));

			foreach (var doc in docs)
			{
				if (doc is Passport)
				{
					// Just cast to Employee and work with it!
					((Passport)doc).ChangeIssueDate(DateTimeOffset.UtcNow);
				 }
				
				doc.WriteToConsole();
				
			}
		}
	}
}
