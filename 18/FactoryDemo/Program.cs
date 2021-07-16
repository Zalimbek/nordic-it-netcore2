using System;

namespace FactoryDemo
{
	class Program
	{
		static void Main(string[] args)
		{
			Passport passport=(Passport)DocumentFactory.CreateDocument<Passport>("My Passport", "XA9991233");
			DriverLicense driveLicense = (DriverLicense)DocumentFactory.CreateDocument<DriverLicense>("My Drive License", 76666);


		}
	}
}
