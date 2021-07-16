using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetCoreDemo.Models
{
	public class CityAddModel
	{
		public string Name { get; set; }

		public string Description { get; set; }
		public int NumberOfPoi { get; set; }

		public CityAddModel()
		{

		}

		public CityAddModel(string name, string description, int numberofPoi)
		{
			Name = name;
			Description = description;
			NumberOfPoi = numberofPoi;

		}
	}
}
