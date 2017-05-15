using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TwitterWebApi.Controllers
{
	public class TwitterController : BaseApiControllerAPI<TwitterController>
    {
		//Add Services
		//private readonly INTERFACE _INTERFACE

		public TwitterController()
		{
			
		}


		//[HttpPost, Route("api/client/create", Name = nameof(Add))]
		//public HttpResponseMessage Add(HttpRequestMessage request, [FromBody] Client client)
		//{
		//	return Execute(request, () =>
		//	{
		//		_clientService.Add(client);
		//
		//		return request.CreateResponse(HttpStatusCode.Created);
		//	});
		//}
    }
}
