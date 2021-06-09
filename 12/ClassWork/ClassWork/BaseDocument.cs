using System;

namespace ClassWork
{
	partial class Program
	{
		public class BaseDocument
		{
			public string DocName { get; set; }
			public string DocNumber { get; set; }
			public DateTimeOffset IssueDate;
			public BaseDocument(
				string docName,
				string docNumber,
				DateTimeOffset issueDate)
			{
				DocName = docName;
				DocNumber = docNumber;
				IssueDate = issueDate;
			}
			public virtual string PropertiesString
			{
				get
				{
					return $"{DocName} has {DocNumber} and {IssueDate}";
				}
			}

			public void WriteToConsole()
			{
				Console.WriteLine(PropertiesString);
			}

			public override bool Equals(object obj)
			{
				return obj is BaseDocument && this.DocName==((BaseDocument)obj).DocName && DocNumber==((BaseDocument)obj).DocNumber && IssueDate == ((BaseDocument)obj).IssueDate;
			}
		}
	}
}
