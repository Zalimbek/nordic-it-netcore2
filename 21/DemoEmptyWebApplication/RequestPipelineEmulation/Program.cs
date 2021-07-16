using System;

namespace RequestPipelineEmulation
{
	class Program
	{
		static void Main(string[] args)
		{
			PipelineMiddleWare requestHandler = new PipelineMiddleWare
			{
				Name = "requestHandler",
				PreAction = (request) =>
				{
					return request;
				},

				PostAction = (response) =>
				{
					return response;
				}
			};

			PipelineMiddleWare authHandler = new PipelineMiddleWare
			{
				Name = "authHandler",
				NextMiddleWare = requestHandler,
				PreAction = (request) => { if (!request.StartsWith("from: zhamilia"))
						return "403:unauthorized";
					else
						return request;
				},
				PostAction = (response) =>
				{
					return response;
				}
			};

			PipelineMiddleWare ExceptionHandler = new PipelineMiddleWare
			{
				Name = "ExceptionHandler",
				NextMiddleWare = authHandler,
				PreAction = (request) =>
				{
					return request;
				},

				PostAction = (response) =>
				{
					return "data";
				}

			};

			string request = "from: zhamilia";
			string response=ExceptionHandler.Run(request);
		}
	}
}
