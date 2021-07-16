using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDemo
{
	class DriverLicense: IDocument
	{
		public string Name { get; set; }
		public int Category { get; set; }
	}
}
