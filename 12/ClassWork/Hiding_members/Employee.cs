using System;
using System.Collections.Generic;
using System.Text;

namespace Hiding_members
{
	class Employee : Person
	{
		public string EmployeeCode {get;set;}

		public DateTimeOffset HireDate { get; set; }

		public override string ShortDescription
		{
			get
			{
				return $"{GetType().Name }" +
					$"code: { EmployeeCode}, " +
					$"name: { Name}, " +
					$"date of birth: { DateOfBirth:dd-MM-yy}, " +
					$"hire date: { HireDate:dd-MM-yy} ";
			}
		}

		public Employee(
			string name, DateTimeOffset dateOfBirth, string employeeCode, DateTimeOffset hireDate): base(name,dateOfBirth)
		{
			EmployeeCode = employeeCode;
			HireDate = hireDate;
		}

	}
}
