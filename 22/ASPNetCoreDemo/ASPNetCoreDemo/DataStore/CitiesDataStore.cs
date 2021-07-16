using ASPNetCoreDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetCoreDemo.DataStore
{
	public class CitiesDataStore
	{
		private static CitiesDataStore _instance;


		public List<City> Cities;

		public CitiesDataStore()
		{
			Cities = new List<City>
			{
				new City(1, "Moscow", "Capital of Russia",99),
				new City(2, "St-Petersburg", "One of the biggest culture centers",100),
				new City(3, "New York", "City I would visit",98),
			};
		}

		public static CitiesDataStore GetInstance()
		{
			if (_instance == null)
				_instance = new CitiesDataStore();
			return _instance;
		}
	}
}
