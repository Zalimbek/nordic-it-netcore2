using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPNetCoreDemo.DataStore;
using ASPNetCoreDemo.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASPNetCoreDemo.Controllers
{
	[ApiController]
	[Route("api/cities")]
	public class CitiesController : Controller
	{
		[HttpGet]
		public IActionResult GetCities()
		{
			var _store = CitiesDataStore.GetInstance();
			var cities = _store.Cities;
			var models = cities.Select(c => new CityGetModel(c.Id, c.Name, c.Description, c.NumberOfPoi)).ToList();

			var result = Ok(models);
			return result;


		}
		[HttpGet("{id}")]
		public IActionResult GetCity(int id)
		{
			var _store = CitiesDataStore.GetInstance();
			var city = _store.Cities
				.Where(c => c.Id == id)
				.FirstOrDefault();
			//var result= new JsonResult(city);
			//if (city == null)
			//	result.StatusCode = 404;
			//else result.StatusCode = 200;

			//return result;

			if (city == null)
				return NotFound();
			return Ok(new CityGetModel(city.Id, city.Name, city.Description, city.NumberOfPoi));

		}

	}
}
