﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetCoreDemo.Models
{
	public class City
	{
		public int Id { get; set; }
		public string Name { get; set; }

		public string Description { get; set; }
		public int NumberOfPoi { get; set; }

		public City()
		{

		}

		public City(int id, string name, string description, int numberofPoi)
		{
			Id = id;
			Name = name;
			Description = description;
			NumberOfPoi = numberofPoi;

		}
	}
}
