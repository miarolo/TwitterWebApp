using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace TwitterWebApi.Controllers
{
    public class BaseApiControllerAPI<TApiController> : ApiController where TApiController : BaseApiControllerAPI<TApiController>
{
	private static readonly object LockObject = new object();

	/// <summary>
	/// Injects the controller with our context.
	/// </summary>       
	public BaseApiControllerAPI() { }


	protected virtual HttpResponseMessage Execute(HttpRequestMessage request, Func<HttpResponseMessage> work)
	{
		if (work != null)
		{
			try
			{
				lock (LockObject)
				{
					return work();
				}
			}
			catch (Exception ex)
			{

				return request.CreateResponse(HttpStatusCode.InternalServerError);
			}
		}

		return request.CreateResponse(HttpStatusCode.BadRequest);
	}

	protected virtual async Task<HttpResponseMessage> ExecuteAsync(HttpRequestMessage request, Func<Task<HttpResponseMessage>> work)
	{
		if (work != null)
		{
			try
			{
				return await work();
			}
			catch (Exception ex)
			{

				return request.CreateResponse(HttpStatusCode.InternalServerError);
			}
		}

		return request.CreateResponse(HttpStatusCode.BadRequest);
	}
}
}