using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Http;
using TWA.UI;

namespace TwitterWebApi
{
    public class Global : System.Web.HttpApplication
	{
		protected void Application_Start()
		{
            DIConfig.RegisterIOC();
            
			AreaRegistration.RegisterAllAreas();
			//UnityConfig.RegisterComponents();
			GlobalConfiguration.Configure(WebApiConfig.Register);
			RouteConfig.RegisterRoutes(RouteTable.Routes);
		}
	}
}
