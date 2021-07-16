using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDemo
{
	public static class DocumentFactory
	{
		public static IDocument CreateDocument<T>(string name, object parameters) where T : IDocument, new()
		{
			IDocument result = new T();
			result.Name = name;

			if (typeof(T) == typeof(Passport))

			{
				((Passport)result).Number = (string)parameters;
			}
			else if (typeof(T) == typeof(DriverLicense))
			{
				((DriverLicense)result).Category = (int)parameters;
			}
			else
				throw new NotImplementedException();
			return result;
			}
		}
	}


