using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity.WebApi;
using Unity;
using Microsoft.Practices.Unity;
using TWA.Interfaces.Services;
using TWA.Business.Services;
using Autofac;

namespace TWA.DependencyResolution
{
    public class BusinessServiceModule : Module   
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(
                System.Reflection.Assembly.GetAssembly(typeof(TwitterService)),
                System.Reflection.Assembly.GetAssembly(typeof(ITwitterService)))
                   .Where(t => t.Name.EndsWith("Service"))
                   .AsImplementedInterfaces();

            //Only be using this when we need a factory for creating logins.
            //builder.RegisterType<IdentityFactory>();
        }
    }
}


// Only need this shit for a webapi
//namespace TWA.DependencyResolution
//{
//	public class BusinessServiceModule
//	{
//		public void Load(UnityContainer container)
//		{
//			//Register all Services
//			//container.RegisterType<interface, Service>();
//			container.RegisterType<ITwitterService, TwitterService>();
//		}

//	}
//}
