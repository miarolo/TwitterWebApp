//Only use when we need a WebApi!!!




//using System;
//using Microsoft.Practices.Unity;
//using System.Web.Http;
//using Unity.WebApi;
////using System.Data.Entity;
//using TWA.DependencyResolution;

//namespace TwitterWebApi
//{
//    public static class UnityConfig
//{
//	public static void RegisterComponents()
//	{
//		BusinessServiceModule _BusinessServiceModule = new BusinessServiceModule();
//		InfrastructureServiceModule _InfrastructureModule = new InfrastructureServiceModule();

//		var container = new UnityContainer();

//		// register all your components with the container here

//		_InfrastructureModule.Load(container);
//		_BusinessServiceModule.Load(container);

//		GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
//	}
//}
//}