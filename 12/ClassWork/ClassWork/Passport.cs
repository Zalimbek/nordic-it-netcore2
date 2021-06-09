using System;

namespace ClassWork
{
	partial class Program
	{
		public class Passport : BaseDocument
		{
			public string Country { get; set; }
			public string PersonName { get; set; }

			public Passport(string docNumber, DateTimeOffset issueDate)
			: base("Passport", docNumber, issueDate)
			{
			}

			public Passport(string docNumber , DateTimeOffset issueDate, string country, string personName)
				: this( docNumber, issueDate)
			{
				Country = country;
				PersonName = personName;
			}

			public override string PropertiesString
			{
				get
				{
					return $"{DocName} has {Country}, {IssueDate},{DocNumber}and {PersonName}";
				}
			}

			public void ChangeIssueDate(DateTimeOffset newIssueDate)
			{
				IssueDate = newIssueDate;
			}
		}
	}
}
